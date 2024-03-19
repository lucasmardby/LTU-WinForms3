namespace LTUWinForms3
{
    public partial class MainForm : Form
    {
        private Person person = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            CreateContextMenu();
        }
        private void CreateContextMenu()
        {
            this.ContextMenuStrip = menuMain;
        }
        private void InitializeGUI()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPersonalNumber.Text = string.Empty;
            lstbxResult.Items.Clear();

            grpInfo.Visible = false;

            grpRegister.Visible = false;
            lblRegisterPerson.Visible = false;
        }
        private void InitializeRegisterPerson()
        {
            lblGreet.Visible = false;
            lblTip.Visible = false;

            grpInfo.Visible = false;
            grpRegister.Visible = true;
            lblRegisterPerson.Visible = true;
        }
        private void InitializeInformation()
        {
            lblGreet.Visible = true;
            lblTip.Visible = true;

            grpInfo.Visible = true;
            grpRegister.Visible = false;
            lblRegisterPerson.Visible = false;
        }

        private void registToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeRegisterPerson();
        }
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeInformation();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReadUserInput();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReadUserInput()
        {
            ReadFirstName();
            ReadLastName();

            bool numOk = ReadPersonalNumber();

            if (numOk == true)
            {
                ReadGender();
                DisplayResults();
            }
            else
            {
                lstbxResult.Items.Clear();
                lstbxResult.Items.Add($"Incorrect personal number! Try again!");
            }
        }

        private void ReadFirstName()
        {
            person.SetFirstName(txtFirstName.Text.Trim());
        }
        private void ReadLastName()
        {
            person.SetLastName(txtLastName.Text.Trim());
        }
        private bool ReadPersonalNumber()
        {
            bool ok = person.SetPersonalNumber(txtPersonalNumber.Text);

            if (ok == true)
                return true;
            else
                return false;
        }
        private void ReadGender()
        {
            person.SetGender();
        }

        private void DisplayResults()
        {
            lstbxResult.Items.Clear();
            lstbxResult.Items.Add($"{person.GetFirstName()}");
            lstbxResult.Items.Add($"{person.GetLastName()}");
            lstbxResult.Items.Add($"{person.GetPersonalNumber()}");
            lstbxResult.Items.Add($"{person.GetGender()}");
        }

        
    }
}
