namespace inventoryManagentSystem
{
    partial class EmployeeLogin
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
            login_username = new TextBox();
            unlbl = new Label();
            pwordlbl = new Label();
            login_password = new TextBox();
            login_btn = new Button();
            register_label = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // login_username
            // 
            login_username.Location = new Point(230, 122);
            login_username.Name = "login_username";
            login_username.Size = new Size(170, 23);
            login_username.TabIndex = 0;
            // 
            // unlbl
            // 
            unlbl.AutoSize = true;
            unlbl.Location = new Point(108, 125);
            unlbl.Name = "unlbl";
            unlbl.Size = new Size(60, 15);
            unlbl.TabIndex = 1;
            unlbl.Text = "Username";
            // 
            // pwordlbl
            // 
            pwordlbl.AutoSize = true;
            pwordlbl.Location = new Point(108, 186);
            pwordlbl.Name = "pwordlbl";
            pwordlbl.Size = new Size(57, 15);
            pwordlbl.TabIndex = 2;
            pwordlbl.Text = "Password";
            // 
            // login_password
            // 
            login_password.Location = new Point(230, 178);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(170, 23);
            login_password.TabIndex = 3;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(186, 243);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(125, 23);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += loginbtn_Click;
            // 
            // register_label
            // 
            register_label.Location = new Point(0, 0);
            register_label.Name = "register_label";
            register_label.Size = new Size(100, 23);
            register_label.TabIndex = 9;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 8;
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 336);
            Controls.Add(label2);
            Controls.Add(register_label);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(pwordlbl);
            Controls.Add(unlbl);
            Controls.Add(login_username);
            Name = "EmployeeLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox login_username;
        private Label unlbl;
        private Label pwordlbl;
        private TextBox login_password;
        private Button login_btn;
        private Label register_label;
        private Label label2;
    }
}
