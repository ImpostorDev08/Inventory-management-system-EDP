namespace inventoryManagentSystem
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_btn2 = new Button();
            login_password2 = new TextBox();
            pwordlbl = new Label();
            unlbl = new Label();
            login_username2 = new TextBox();
            SuspendLayout();
            // 
            // login_btn2
            // 
            login_btn2.Location = new Point(199, 240);
            login_btn2.Name = "login_btn2";
            login_btn2.Size = new Size(125, 23);
            login_btn2.TabIndex = 9;
            login_btn2.Text = "Login";
            login_btn2.UseVisualStyleBackColor = true;
            login_btn2.Click += login_btn2_Click;
            // 
            // login_password2
            // 
            login_password2.Location = new Point(243, 175);
            login_password2.Name = "login_password2";
            login_password2.PasswordChar = '*';
            login_password2.Size = new Size(170, 23);
            login_password2.TabIndex = 8;
            // 
            // pwordlbl
            // 
            pwordlbl.AutoSize = true;
            pwordlbl.Location = new Point(121, 183);
            pwordlbl.Name = "pwordlbl";
            pwordlbl.Size = new Size(57, 15);
            pwordlbl.TabIndex = 7;
            pwordlbl.Text = "Password";
            // 
            // unlbl
            // 
            unlbl.AutoSize = true;
            unlbl.Location = new Point(121, 122);
            unlbl.Name = "unlbl";
            unlbl.Size = new Size(60, 15);
            unlbl.TabIndex = 6;
            unlbl.Text = "Username";
            // 
            // login_username2
            // 
            login_username2.Location = new Point(243, 119);
            login_username2.Name = "login_username2";
            login_username2.Size = new Size(170, 23);
            login_username2.TabIndex = 5;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 336);
            Controls.Add(login_btn2);
            Controls.Add(login_password2);
            Controls.Add(pwordlbl);
            Controls.Add(unlbl);
            Controls.Add(login_username2);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn2;
        private TextBox login_password2;
        private Label pwordlbl;
        private Label unlbl;
        private TextBox login_username2;
    }
}