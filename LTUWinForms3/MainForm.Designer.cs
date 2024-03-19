namespace LTUWinForms3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnOk = new Button();
            txtFirstName = new TextBox();
            txtPersonalNumber = new TextBox();
            txtLastName = new TextBox();
            lstbxResult = new ListBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPersonalNumber = new Label();
            btnExit = new Button();
            menuMain = new ContextMenuStrip(components);
            registToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            grpRegister = new GroupBox();
            lblInfo3 = new Label();
            lblInfo2 = new Label();
            lblInfo = new Label();
            lblGreet = new Label();
            lblTip = new Label();
            lblRegisterPerson = new Label();
            grpInfo = new GroupBox();
            menuMain.SuspendLayout();
            grpRegister.SuspendLayout();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(240, 89);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(122, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new Point(122, 89);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(100, 23);
            txtPersonalNumber.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(122, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // lstbxResult
            // 
            lstbxResult.FormattingEnabled = true;
            lstbxResult.ItemHeight = 15;
            lstbxResult.Location = new Point(66, 143);
            lstbxResult.Name = "lstbxResult";
            lstbxResult.Size = new Size(156, 109);
            lstbxResult.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(48, 34);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(48, 63);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // lblPersonalNumber
            // 
            lblPersonalNumber.AutoSize = true;
            lblPersonalNumber.Location = new Point(12, 92);
            lblPersonalNumber.Name = "lblPersonalNumber";
            lblPersonalNumber.Size = new Size(99, 15);
            lblPersonalNumber.TabIndex = 7;
            lblPersonalNumber.Text = "Personal Number";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(240, 118);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { registToolStripMenuItem, informationToolStripMenuItem, exitToolStripMenuItem });
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(156, 70);
            menuMain.Text = "Main Menu";
            // 
            // registToolStripMenuItem
            // 
            registToolStripMenuItem.Name = "registToolStripMenuItem";
            registToolStripMenuItem.Size = new Size(155, 22);
            registToolStripMenuItem.Text = "Register Person";
            registToolStripMenuItem.Click += registToolStripMenuItem_Click;
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(155, 22);
            informationToolStripMenuItem.Text = "Information";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(155, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // grpRegister
            // 
            grpRegister.Controls.Add(txtFirstName);
            grpRegister.Controls.Add(lblFirstName);
            grpRegister.Controls.Add(btnOk);
            grpRegister.Controls.Add(lstbxResult);
            grpRegister.Controls.Add(btnExit);
            grpRegister.Controls.Add(lblLastName);
            grpRegister.Controls.Add(txtLastName);
            grpRegister.Controls.Add(lblPersonalNumber);
            grpRegister.Controls.Add(txtPersonalNumber);
            grpRegister.Location = new Point(15, 176);
            grpRegister.Name = "grpRegister";
            grpRegister.Size = new Size(325, 265);
            grpRegister.TabIndex = 9;
            grpRegister.TabStop = false;
            grpRegister.Text = "Register Person";
            // 
            // lblInfo3
            // 
            lblInfo3.AutoSize = true;
            lblInfo3.Location = new Point(34, 55);
            lblInfo3.Name = "lblInfo3";
            lblInfo3.Size = new Size(68, 15);
            lblInfo3.TabIndex = 15;
            lblInfo3.Text = "March 2024";
            // 
            // lblInfo2
            // 
            lblInfo2.AutoSize = true;
            lblInfo2.Location = new Point(6, 36);
            lblInfo2.Name = "lblInfo2";
            lblInfo2.Size = new Size(130, 15);
            lblInfo2.TabIndex = 14;
            lblInfo2.Text = "made by Lucas Mårdby";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(27, 19);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(82, 15);
            lblInfo.TabIndex = 13;
            lblInfo.Text = "Assignment 3,";
            // 
            // lblGreet
            // 
            lblGreet.AutoSize = true;
            lblGreet.Location = new Point(141, 27);
            lblGreet.Name = "lblGreet";
            lblGreet.Size = new Size(66, 15);
            lblGreet.TabIndex = 10;
            lblGreet.Text = "GREETINGS";
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Location = new Point(111, 58);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(134, 15);
            lblTip.TabIndex = 11;
            lblTip.Text = "(Right Mouse for Menu)";
            // 
            // lblRegisterPerson
            // 
            lblRegisterPerson.AutoSize = true;
            lblRegisterPerson.Location = new Point(81, 73);
            lblRegisterPerson.Name = "lblRegisterPerson";
            lblRegisterPerson.Size = new Size(198, 15);
            lblRegisterPerson.TabIndex = 12;
            lblRegisterPerson.Text = "Register name and personal number";
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblInfo);
            grpInfo.Controls.Add(lblInfo2);
            grpInfo.Controls.Add(lblInfo3);
            grpInfo.Location = new Point(111, 86);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(139, 80);
            grpInfo.TabIndex = 16;
            grpInfo.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 522);
            Controls.Add(grpInfo);
            Controls.Add(lblRegisterPerson);
            Controls.Add(lblTip);
            Controls.Add(lblGreet);
            Controls.Add(grpRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuMain.ResumeLayout(false);
            grpRegister.ResumeLayout(false);
            grpRegister.PerformLayout();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private TextBox txtFirstName;
        private TextBox txtPersonalNumber;
        private TextBox txtLastName;
        private ListBox lstbxResult;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPersonalNumber;
        private Button btnExit;
        private ContextMenuStrip menuMain;
        private ToolStripMenuItem registToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox grpRegister;
        private Label lblGreet;
        private Label lblTip;
        private Label lblRegisterPerson;
        private Label lblInfo;
        private Label lblInfo2;
        private Label lblInfo3;
        private GroupBox grpInfo;
    }
}
