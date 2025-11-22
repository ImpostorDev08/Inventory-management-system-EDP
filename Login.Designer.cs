namespace inventoryManagentSystem
{
    partial class Login
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
            employeelogin_btn = new Button();
            adminlogin_btn = new Button();
            SuspendLayout();
            // 
            // employeelogin_btn
            // 
            employeelogin_btn.Location = new Point(78, 52);
            employeelogin_btn.Name = "employeelogin_btn";
            employeelogin_btn.Size = new Size(284, 38);
            employeelogin_btn.TabIndex = 0;
            employeelogin_btn.Text = "Employee Login";
            employeelogin_btn.UseVisualStyleBackColor = true;
            employeelogin_btn.Click += employeelogin_btn_Click;
            // 
            // adminlogin_btn
            // 
            adminlogin_btn.Location = new Point(78, 119);
            adminlogin_btn.Name = "adminlogin_btn";
            adminlogin_btn.Size = new Size(284, 42);
            adminlogin_btn.TabIndex = 1;
            adminlogin_btn.Text = "Admin Login";
            adminlogin_btn.UseVisualStyleBackColor = true;
            adminlogin_btn.Click += adminlogin_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 212);
            Controls.Add(adminlogin_btn);
            Controls.Add(employeelogin_btn);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Button employeelogin_btn;
        private Button adminlogin_btn;
    }
}