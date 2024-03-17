namespace LTUWinForms3
{
    public partial class MainForm : Form
    {
        private Person person = new();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        private void InitializeGUI()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPersonalNumber.Text = string.Empty;
            lstbxResult.Items.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReadUserInput();
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
