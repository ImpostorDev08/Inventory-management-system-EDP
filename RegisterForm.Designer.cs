namespace inventoryManagentSystem
{
    partial class RegisterForm
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
            register_btn = new Button();
            register_password = new TextBox();
            pwordlbl = new Label();
            unlbl = new Label();
            register_username = new TextBox();
            register_cPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            login_label = new Label();
            SuspendLayout();
            // 
            // register_btn
            // 
            register_btn.Location = new Point(205, 258);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(161, 23);
            register_btn.TabIndex = 9;
            register_btn.Text = "Signup";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // register_password
            // 
            register_password.Location = new Point(228, 152);
            register_password.Name = "register_password";
            register_password.Size = new Size(186, 23);
            register_password.TabIndex = 8;
            // 
            // pwordlbl
            // 
            pwordlbl.AutoSize = true;
            pwordlbl.Location = new Point(106, 160);
            pwordlbl.Name = "pwordlbl";
            pwordlbl.Size = new Size(57, 15);
            pwordlbl.TabIndex = 7;
            pwordlbl.Text = "Password";
            // 
            // unlbl
            // 
            unlbl.AutoSize = true;
            unlbl.Location = new Point(106, 109);
            unlbl.Name = "unlbl";
            unlbl.Size = new Size(60, 15);
            unlbl.TabIndex = 6;
            unlbl.Text = "Username";
            // 
            // register_username
            // 
            register_username.Location = new Point(228, 106);
            register_username.Name = "register_username";
            register_username.Size = new Size(186, 23);
            register_username.TabIndex = 5;
            // 
            // register_cPassword
            // 
            register_cPassword.Location = new Point(228, 201);
            register_cPassword.Name = "register_cPassword";
            register_cPassword.Size = new Size(186, 23);
            register_cPassword.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 209);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 10;
            label1.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 302);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 13;
            label2.Text = "Already have an account?";
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.ForeColor = SystemColors.HotTrack;
            login_label.Location = new Point(281, 302);
            login_label.Name = "login_label";
            login_label.Size = new Size(69, 15);
            login_label.TabIndex = 12;
            login_label.Text = "Sign in here";
            login_label.Click += login_label_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 336);
            Controls.Add(label2);
            Controls.Add(login_label);
            Controls.Add(register_cPassword);
            Controls.Add(label1);
            Controls.Add(register_btn);
            Controls.Add(register_password);
            Controls.Add(pwordlbl);
            Controls.Add(unlbl);
            Controls.Add(register_username);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register_btn;
        private TextBox register_password;
        private Label pwordlbl;
        private Label unlbl;
        private TextBox register_username;
        private TextBox register_cPassword;
        private Label label1;
        private Label label2;
        private Label login_label;
    }
}