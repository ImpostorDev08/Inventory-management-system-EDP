namespace inventoryManagentSystem
{
    partial class Form2
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
            addbtn = new Button();
            Invbtn = new Button();
            dltbtn = new Button();
            SuspendLayout();
            // 
            // addbtn
            // 
            addbtn.Location = new Point(87, 123);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(147, 91);
            addbtn.TabIndex = 0;
            addbtn.Text = "Add product";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // Invbtn
            // 
            Invbtn.Location = new Point(299, 123);
            Invbtn.Name = "Invbtn";
            Invbtn.Size = new Size(147, 91);
            Invbtn.TabIndex = 1;
            Invbtn.Text = "Inventory";
            Invbtn.UseVisualStyleBackColor = true;
            Invbtn.Click += Invbtn_Click;
            // 
            // dltbtn
            // 
            dltbtn.Location = new Point(526, 123);
            dltbtn.Name = "dltbtn";
            dltbtn.Size = new Size(147, 91);
            dltbtn.TabIndex = 2;
            dltbtn.Text = "Archive";
            dltbtn.UseVisualStyleBackColor = true;
            dltbtn.Click += dltbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 383);
            Controls.Add(dltbtn);
            Controls.Add(Invbtn);
            Controls.Add(addbtn);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
        }

        #endregion

        private Button addbtn;
        private Button Invbtn;
        private Button dltbtn;
    }
}