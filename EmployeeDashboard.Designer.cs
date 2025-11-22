namespace inventoryManagentSystem
{
    partial class EmployeeDashboard
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
            label9 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            stock = new TextBox();
            productupdate_btn = new Button();
            logout_btn = new Button();
            label2 = new Label();
            panel2 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 19);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 0;
            label9.Text = "All Products";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(stock);
            panel3.Controls.Add(productupdate_btn);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(254, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(825, 717);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Stock:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(786, 660);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // stock
            // 
            stock.Location = new Point(603, 16);
            stock.Name = "stock";
            stock.Size = new Size(107, 23);
            stock.TabIndex = 4;
            // 
            // productupdate_btn
            // 
            productupdate_btn.Location = new Point(727, 14);
            productupdate_btn.Name = "productupdate_btn";
            productupdate_btn.Size = new Size(82, 23);
            productupdate_btn.TabIndex = 3;
            productupdate_btn.Text = "Update";
            productupdate_btn.UseVisualStyleBackColor = true;
            productupdate_btn.Click += productupdate_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.Location = new Point(12, 590);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(218, 38);
            logout_btn.TabIndex = 3;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 140);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Welcome, User";
            // 
            // panel2
            // 
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 717);
            panel2.TabIndex = 6;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 717);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " EmployeeDashboard";
            Load += EmployeeDashboard_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label9;
        private Panel panel3;
        private Button productupdate_btn;
        private TextBox stock;
        private DataGridView dataGridView2;
        private Label label1;
        private Button logout_btn;
        private Label label2;
        private Panel panel2;
    }
}