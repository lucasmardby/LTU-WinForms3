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
            btnOk = new Button();
            txtFirstName = new TextBox();
            txtPersonalNumber = new TextBox();
            txtLastName = new TextBox();
            lstbxResult = new ListBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            label3 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(246, 142);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(128, 84);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new Point(128, 142);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(100, 23);
            txtPersonalNumber.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(128, 113);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // lstbxResult
            // 
            lstbxResult.FormattingEnabled = true;
            lstbxResult.ItemHeight = 15;
            lstbxResult.Location = new Point(72, 196);
            lstbxResult.Name = "lstbxResult";
            lstbxResult.Size = new Size(156, 109);
            lstbxResult.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(54, 87);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(54, 116);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 145);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "Personal Number";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(246, 171);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 418);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lstbxResult);
            Controls.Add(txtLastName);
            Controls.Add(txtPersonalNumber);
            Controls.Add(txtFirstName);
            Controls.Add(btnOk);
            Name = "MainForm";
            Text = "Form1";
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
        private Label label3;
        private Button btnExit;
    }
}
