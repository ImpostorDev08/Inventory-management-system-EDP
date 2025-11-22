namespace inventoryManagentSystem
{
    partial class UserAchiveData
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
            panel3 = new Panel();
            productarchive_btn = new Button();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(productarchive_btn);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(20, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 661);
            panel3.TabIndex = 6;
            // 
            // productarchive_btn
            // 
            productarchive_btn.Location = new Point(969, 14);
            productarchive_btn.Name = "productarchive_btn";
            productarchive_btn.Size = new Size(75, 23);
            productarchive_btn.TabIndex = 2;
            productarchive_btn.Text = "Update";
            productarchive_btn.UseVisualStyleBackColor = true;
            productarchive_btn.Click += productarchive_btn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 46);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(1017, 585);
            dataGridView2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 18);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 0;
            label9.Text = "All Archived Users";
            // 
            // UserAchiveData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "UserAchiveData";
            Size = new Size(1091, 707);
            Load += UserAchiveData_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button productarchive_btn;
        private DataGridView dataGridView2;
        private Label label9;
    }
}
