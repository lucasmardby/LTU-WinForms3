namespace LTUWinForms3
{
    public partial class MainForm : Form
    {
        private Person person = new();

        //MainForm, responsible for the GUI
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            CreateContextMenu();
        }
        /// <summary>
        /// Instansiate ContextMenu control
        /// </summary>
        private void CreateContextMenu()
        {
            this.ContextMenuStrip = menuMain;
        }
        /// <summary>
        /// Initializes all controls
        /// </summary>
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
        /// <summary>
        /// Called when Register Person is selected in menu, making that part of the GUI visible
        /// </summary>
        private void InitializeRegisterPerson()
        {
            lblGreet.Visible = false;
            lblTip.Visible = false;

            grpInfo.Visible = false;
            grpRegister.Visible = true;
            lblRegisterPerson.Visible = true;
        }
        /// <summary>
        /// Called when Information is selected in menu, making that part of the GUI visible
        /// </summary>
        private void InitializeInformation()
        {
            lblGreet.Visible = true;
            lblTip.Visible = true;

            grpInfo.Visible = true;
            grpRegister.Visible = false;
            lblRegisterPerson.Visible = false;
        }
        /// <summary>
        /// Calls InitializeRegisterPerson() when Register Person is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeRegisterPerson();
        }
        /// <summary>
        /// Calls InitializeInformation() when Information Person is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeInformation();
        }
        /// <summary>
        /// Closes the program when Exit is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ok button in Register Person, calling ReadUserInput() to read all the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            ReadUserInput();
        }
        /// <summary>
        /// Exit button, closing the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Calls Read methods for all textboxes, getting first name, last name, and personal number
        /// If the personal number is correct, it moves on to checking gender and displaying values;
        /// if not, it displays that it's incorrect
        /// </summary>
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
        /// <summary>
        /// Reads firstName
        /// </summary>
        private void ReadFirstName()
        {
            person.SetFirstName(txtFirstName.Text.Trim());
        }
        /// <summary>
        /// Reads lastName
        /// </summary>
        private void ReadLastName()
        {
            person.SetLastName(txtLastName.Text.Trim());
        }
        /// <summary>
        /// Reads personal number
        /// </summary>
        /// <returns></returns>
        private bool ReadPersonalNumber()
        {
            bool ok = person.SetPersonalNumber(txtPersonalNumber.Text);

            if (ok == true)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Reads gender
        /// </summary>
        private void ReadGender()
        {
            person.SetGender();
        }
        /// <summary>
        /// Displays all results in the listbox
        /// </summary>
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
