namespace inventoryManagentSystem
{
    partial class AdminManageProducts
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
            addProducts_clearBtn = new Button();
            addProducts_archiveBtn = new Button();
            addProducts_updateBtn = new Button();
            addProducts_brand = new ComboBox();
            addProducts_category = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            addProducts_addBtn = new Button();
            addProducts_description = new TextBox();
            addProducts_prodName = new TextBox();
            label3 = new Label();
            addProducts_prodID = new TextBox();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            addProducts_size = new TextBox();
            label5 = new Label();
            addProducts_stock = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // addProducts_clearBtn
            // 
            addProducts_clearBtn.Location = new Point(562, 119);
            addProducts_clearBtn.Name = "addProducts_clearBtn";
            addProducts_clearBtn.Size = new Size(105, 53);
            addProducts_clearBtn.TabIndex = 18;
            addProducts_clearBtn.Text = "Clear";
            addProducts_clearBtn.UseVisualStyleBackColor = true;
            addProducts_clearBtn.Click += addProducts_clearBtn_Click;
            // 
            // addProducts_archiveBtn
            // 
            addProducts_archiveBtn.Location = new Point(379, 119);
            addProducts_archiveBtn.Name = "addProducts_archiveBtn";
            addProducts_archiveBtn.Size = new Size(113, 53);
            addProducts_archiveBtn.TabIndex = 17;
            addProducts_archiveBtn.Text = "Archive";
            addProducts_archiveBtn.UseVisualStyleBackColor = true;
            addProducts_archiveBtn.Click += addProducts_archiveBtn_Click;
            // 
            // addProducts_updateBtn
            // 
            addProducts_updateBtn.Location = new Point(216, 119);
            addProducts_updateBtn.Name = "addProducts_updateBtn";
            addProducts_updateBtn.Size = new Size(113, 53);
            addProducts_updateBtn.TabIndex = 16;
            addProducts_updateBtn.Text = "Update";
            addProducts_updateBtn.UseVisualStyleBackColor = true;
            addProducts_updateBtn.Click += addProducts_updateBtn_Click;
            // 
            // addProducts_brand
            // 
            addProducts_brand.FormattingEnabled = true;
            addProducts_brand.Items.AddRange(new object[] { "Nike", "Adidas", "Puma", "Converse", "Vans", "Under Armour" });
            addProducts_brand.Location = new Point(352, 22);
            addProducts_brand.Name = "addProducts_brand";
            addProducts_brand.Size = new Size(121, 23);
            addProducts_brand.TabIndex = 14;
            // 
            // addProducts_category
            // 
            addProducts_category.FormattingEnabled = true;
            addProducts_category.Items.AddRange(new object[] { "Sports", "Casual", "Formal", "Boots" });
            addProducts_category.Location = new Point(352, 65);
            addProducts_category.Name = "addProducts_category";
            addProducts_category.Size = new Size(121, 23);
            addProducts_category.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1004, 405);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "All Products";
            // 
            // addProducts_addBtn
            // 
            addProducts_addBtn.Location = new Point(55, 119);
            addProducts_addBtn.Name = "addProducts_addBtn";
            addProducts_addBtn.Size = new Size(109, 53);
            addProducts_addBtn.TabIndex = 15;
            addProducts_addBtn.Text = "Add";
            addProducts_addBtn.UseVisualStyleBackColor = true;
            addProducts_addBtn.Click += addProducts_addBtn_Click;
            // 
            // addProducts_description
            // 
            addProducts_description.Location = new Point(809, 22);
            addProducts_description.Multiline = true;
            addProducts_description.Name = "addProducts_description";
            addProducts_description.Size = new Size(235, 150);
            addProducts_description.TabIndex = 11;
            // 
            // addProducts_prodName
            // 
            addProducts_prodName.Location = new Point(117, 65);
            addProducts_prodName.Name = "addProducts_prodName";
            addProducts_prodName.Size = new Size(138, 23);
            addProducts_prodName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 73);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // addProducts_prodID
            // 
            addProducts_prodID.Location = new Point(107, 22);
            addProducts_prodID.Name = "addProducts_prodID";
            addProducts_prodID.Size = new Size(138, 23);
            addProducts_prodID.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(addProducts_clearBtn);
            panel2.Controls.Add(addProducts_archiveBtn);
            panel2.Controls.Add(addProducts_updateBtn);
            panel2.Controls.Add(addProducts_addBtn);
            panel2.Controls.Add(addProducts_brand);
            panel2.Controls.Add(addProducts_category);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(addProducts_description);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addProducts_size);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addProducts_stock);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addProducts_prodName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addProducts_prodID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 496);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 203);
            panel2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 73);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 12;
            label8.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(714, 22);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 10;
            label7.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 25);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 8;
            label6.Text = "Brand";
            // 
            // addProducts_size
            // 
            addProducts_size.Location = new Point(553, 68);
            addProducts_size.Name = "addProducts_size";
            addProducts_size.Size = new Size(138, 23);
            addProducts_size.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 73);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 6;
            label5.Text = "Size(US)";
            // 
            // addProducts_stock
            // 
            addProducts_stock.Location = new Point(552, 19);
            addProducts_stock.Name = "addProducts_stock";
            addProducts_stock.Size = new Size(138, 23);
            addProducts_stock.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 27);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 30);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Product ID";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(20, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 475);
            panel3.TabIndex = 4;
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
            dataGridView2.Size = new Size(1017, 415);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 18);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 0;
            label9.Text = "All Products";
            // 
            // AdminManageProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "AdminManageProducts";
            Size = new Size(1091, 707);
            Load += AdminManageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addProducts_clearBtn;
        private Button addProducts_archiveBtn;
        private Button addProducts_updateBtn;
        private ComboBox addProducts_brand;
        private ComboBox addProducts_category;
        private Label label1;
        private Button addProducts_addBtn;
        private TextBox addProducts_description;
        private TextBox addProducts_prodName;
        private Label label3;
        private TextBox addProducts_prodID;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox addProducts_size;
        private Label label5;
        private TextBox addProducts_stock;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private DataGridView dataGridView2;
        private Label label9;
    }
}
