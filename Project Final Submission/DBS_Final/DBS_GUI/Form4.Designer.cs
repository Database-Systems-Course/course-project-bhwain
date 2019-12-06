namespace DBS_GUI
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.CreditBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.WishGroup = new System.Windows.Forms.GroupBox();
            this.WishBox = new System.Windows.Forms.ListBox();
            this.PurchasedBox = new System.Windows.Forms.ListBox();
            this.PurchasedGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.WishGroup.SuspendLayout();
            this.PurchasedGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(259, 21);
            this.FNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.ReadOnly = true;
            this.FNameBox.Size = new System.Drawing.Size(194, 20);
            this.FNameBox.TabIndex = 1;
            this.FNameBox.TextChanged += new System.EventHandler(this.FNameBox_TextChanged);
            // 
            // CreditBox
            // 
            this.CreditBox.Location = new System.Drawing.Point(259, 93);
            this.CreditBox.Margin = new System.Windows.Forms.Padding(2);
            this.CreditBox.Name = "CreditBox";
            this.CreditBox.ReadOnly = true;
            this.CreditBox.Size = new System.Drawing.Size(194, 20);
            this.CreditBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label2.Location = new System.Drawing.Point(169, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label5.Location = new System.Drawing.Point(169, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Balance:";
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.EditButton.Location = new System.Drawing.Point(379, 117);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(74, 35);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WishGroup
            // 
            this.WishGroup.Controls.Add(this.WishBox);
            this.WishGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.WishGroup.Location = new System.Drawing.Point(33, 152);
            this.WishGroup.Margin = new System.Windows.Forms.Padding(2);
            this.WishGroup.Name = "WishGroup";
            this.WishGroup.Padding = new System.Windows.Forms.Padding(2);
            this.WishGroup.Size = new System.Drawing.Size(222, 253);
            this.WishGroup.TabIndex = 10;
            this.WishGroup.TabStop = false;
            this.WishGroup.Text = "Wishlist";
            // 
            // WishBox
            // 
            this.WishBox.FormattingEnabled = true;
            this.WishBox.ItemHeight = 18;
            this.WishBox.Location = new System.Drawing.Point(5, 28);
            this.WishBox.Name = "WishBox";
            this.WishBox.Size = new System.Drawing.Size(212, 202);
            this.WishBox.TabIndex = 0;
            this.WishBox.SelectedIndexChanged += new System.EventHandler(this.WishBox_SelectedIndexChanged);
            // 
            // PurchasedBox
            // 
            this.PurchasedBox.FormattingEnabled = true;
            this.PurchasedBox.ItemHeight = 18;
            this.PurchasedBox.Location = new System.Drawing.Point(5, 28);
            this.PurchasedBox.Name = "PurchasedBox";
            this.PurchasedBox.Size = new System.Drawing.Size(212, 202);
            this.PurchasedBox.TabIndex = 1;
            // 
            // PurchasedGroup
            // 
            this.PurchasedGroup.Controls.Add(this.PurchasedBox);
            this.PurchasedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.PurchasedGroup.Location = new System.Drawing.Point(259, 152);
            this.PurchasedGroup.Margin = new System.Windows.Forms.Padding(2);
            this.PurchasedGroup.Name = "PurchasedGroup";
            this.PurchasedGroup.Padding = new System.Windows.Forms.Padding(2);
            this.PurchasedGroup.Size = new System.Drawing.Size(220, 253);
            this.PurchasedGroup.TabIndex = 11;
            this.PurchasedGroup.TabStop = false;
            this.PurchasedGroup.Text = "Purchased";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label3.Location = new System.Drawing.Point(169, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label4.Location = new System.Drawing.Point(169, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 433);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PurchasedGroup);
            this.Controls.Add(this.WishGroup);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreditBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "Customer Profile";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.WishGroup.ResumeLayout(false);
            this.PurchasedGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox CreditBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.GroupBox WishGroup;
        private System.Windows.Forms.ListBox WishBox;
        private System.Windows.Forms.ListBox PurchasedBox;
        private System.Windows.Forms.GroupBox PurchasedGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}