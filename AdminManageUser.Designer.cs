namespace inventoryManagentSystem
{
    partial class AdminManageUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            addUsers_clearbtn = new Button();
            addUsers_archivebtn = new Button();
            addUsers_updatebtn = new Button();
            addUsers_addbtn = new Button();
            addUsers_status = new ComboBox();
            label4 = new Label();
            addUsers_role = new ComboBox();
            label3 = new Label();
            addUsers_password = new TextBox();
            label2 = new Label();
            addUsers_username = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(382, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 657);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(668, 594);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 17);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 0;
            label5.Text = "All User's Data";
            // 
            // addUsers_clearbtn
            // 
            addUsers_clearbtn.Location = new Point(185, 457);
            addUsers_clearbtn.Name = "addUsers_clearbtn";
            addUsers_clearbtn.Size = new Size(123, 46);
            addUsers_clearbtn.TabIndex = 11;
            addUsers_clearbtn.Text = "Clear";
            addUsers_clearbtn.UseVisualStyleBackColor = true;
            addUsers_clearbtn.Click += addUsers_clearbtn_Click;
            // 
            // addUsers_archivebtn
            // 
            addUsers_archivebtn.Location = new Point(20, 457);
            addUsers_archivebtn.Name = "addUsers_archivebtn";
            addUsers_archivebtn.Size = new Size(123, 46);
            addUsers_archivebtn.TabIndex = 10;
            addUsers_archivebtn.Text = "Archive";
            addUsers_archivebtn.UseVisualStyleBackColor = true;
            addUsers_archivebtn.Click += addUsers_archivebtn_Click;
            // 
            // addUsers_updatebtn
            // 
            addUsers_updatebtn.Location = new Point(185, 367);
            addUsers_updatebtn.Name = "addUsers_updatebtn";
            addUsers_updatebtn.Size = new Size(123, 46);
            addUsers_updatebtn.TabIndex = 9;
            addUsers_updatebtn.Text = "Update";
            addUsers_updatebtn.UseVisualStyleBackColor = true;
            addUsers_updatebtn.Click += addUsers_updatebtn_Click;
            // 
            // addUsers_addbtn
            // 
            addUsers_addbtn.Location = new Point(20, 367);
            addUsers_addbtn.Name = "addUsers_addbtn";
            addUsers_addbtn.Size = new Size(123, 46);
            addUsers_addbtn.TabIndex = 8;
            addUsers_addbtn.Text = "Add";
            addUsers_addbtn.UseVisualStyleBackColor = true;
            addUsers_addbtn.Click += addUsers_addbtn_Click;
            // 
            // addUsers_status
            // 
            addUsers_status.FormattingEnabled = true;
            addUsers_status.Items.AddRange(new object[] { "Active", "Inactive", "Approval" });
            addUsers_status.Location = new Point(20, 301);
            addUsers_status.Name = "addUsers_status";
            addUsers_status.Size = new Size(288, 23);
            addUsers_status.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 283);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Status";
            // 
            // addUsers_role
            // 
            addUsers_role.FormattingEnabled = true;
            addUsers_role.Items.AddRange(new object[] { "Admin", "Cashier" });
            addUsers_role.Location = new Point(20, 226);
            addUsers_role.Name = "addUsers_role";
            addUsers_role.Size = new Size(288, 23);
            addUsers_role.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 208);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // addUsers_password
            // 
            addUsers_password.Location = new Point(20, 153);
            addUsers_password.Name = "addUsers_password";
            addUsers_password.Size = new Size(288, 23);
            addUsers_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // addUsers_username
            // 
            addUsers_username.Location = new Point(20, 76);
            addUsers_username.Name = "addUsers_username";
            addUsers_username.Size = new Size(288, 23);
            addUsers_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 46);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel1
            // 
            panel1.Controls.Add(addUsers_clearbtn);
            panel1.Controls.Add(addUsers_archivebtn);
            panel1.Controls.Add(addUsers_updatebtn);
            panel1.Controls.Add(addUsers_addbtn);
            panel1.Controls.Add(addUsers_status);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addUsers_role);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addUsers_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addUsers_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 657);
            panel1.TabIndex = 2;
            // 
            // AdminManageUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminManageUser";
            Size = new Size(1091, 712);
            Load += AdminManageUser_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Button addUsers_clearbtn;
        private Button addUsers_archivebtn;
        private Button addUsers_updatebtn;
        private Button addUsers_addbtn;
        private ComboBox addUsers_status;
        private Label label4;
        private ComboBox addUsers_role;
        private Label label3;
        private TextBox addUsers_password;
        private Label label2;
        private TextBox addUsers_username;
        private Label label1;
        private Panel panel1;
    }
}
