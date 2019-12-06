namespace DBS_GUI
{
    partial class GameDetailForm
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
            this.DescriptionGroup = new System.Windows.Forms.GroupBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.AboutGroup = new System.Windows.Forms.GroupBox();
            this.WishCheck = new System.Windows.Forms.CheckBox();
            this.PurchasedCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.PublisherBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.WishButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.DescriptionGroup.SuspendLayout();
            this.AboutGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionGroup
            // 
            this.DescriptionGroup.Controls.Add(this.DescriptionBox);
            this.DescriptionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DescriptionGroup.Location = new System.Drawing.Point(23, 261);
            this.DescriptionGroup.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionGroup.Name = "DescriptionGroup";
            this.DescriptionGroup.Padding = new System.Windows.Forms.Padding(2);
            this.DescriptionGroup.Size = new System.Drawing.Size(476, 275);
            this.DescriptionGroup.TabIndex = 0;
            this.DescriptionGroup.TabStop = false;
            this.DescriptionGroup.Text = "Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(4, 28);
            this.DescriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(468, 239);
            this.DescriptionBox.TabIndex = 0;
            // 
            // AboutGroup
            // 
            this.AboutGroup.Controls.Add(this.WishCheck);
            this.AboutGroup.Controls.Add(this.PurchasedCheck);
            this.AboutGroup.Controls.Add(this.label3);
            this.AboutGroup.Controls.Add(this.label2);
            this.AboutGroup.Controls.Add(this.label1);
            this.AboutGroup.Controls.Add(this.GenreBox);
            this.AboutGroup.Controls.Add(this.PublisherBox);
            this.AboutGroup.Controls.Add(this.TitleBox);
            this.AboutGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.AboutGroup.Location = new System.Drawing.Point(192, 11);
            this.AboutGroup.Margin = new System.Windows.Forms.Padding(2);
            this.AboutGroup.Name = "AboutGroup";
            this.AboutGroup.Padding = new System.Windows.Forms.Padding(2);
            this.AboutGroup.Size = new System.Drawing.Size(294, 246);
            this.AboutGroup.TabIndex = 2;
            this.AboutGroup.TabStop = false;
            this.AboutGroup.Text = "About";
            // 
            // WishCheck
            // 
            this.WishCheck.AutoSize = true;
<<<<<<< HEAD
            this.WishCheck.Enabled = false;
            this.WishCheck.Location = new System.Drawing.Point(99, 155);
            this.WishCheck.Margin = new System.Windows.Forms.Padding(2);
            this.WishCheck.Name = "WishCheck";
            this.WishCheck.Size = new System.Drawing.Size(90, 24);
=======
            this.WishCheck.Location = new System.Drawing.Point(99, 155);
            this.WishCheck.Margin = new System.Windows.Forms.Padding(2);
            this.WishCheck.Name = "WishCheck";
            this.WishCheck.Size = new System.Drawing.Size(85, 24);
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            this.WishCheck.TabIndex = 7;
            this.WishCheck.Text = "Wishlist";
            this.WishCheck.UseVisualStyleBackColor = true;
            this.WishCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // PurchasedCheck
            // 
            this.PurchasedCheck.AutoSize = true;
<<<<<<< HEAD
            this.PurchasedCheck.Enabled = false;
            this.PurchasedCheck.Location = new System.Drawing.Point(99, 118);
            this.PurchasedCheck.Margin = new System.Windows.Forms.Padding(2);
            this.PurchasedCheck.Name = "PurchasedCheck";
            this.PurchasedCheck.Size = new System.Drawing.Size(113, 24);
=======
            this.PurchasedCheck.Location = new System.Drawing.Point(99, 118);
            this.PurchasedCheck.Margin = new System.Windows.Forms.Padding(2);
            this.PurchasedCheck.Name = "PurchasedCheck";
            this.PurchasedCheck.Size = new System.Drawing.Size(107, 24);
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            this.PurchasedCheck.TabIndex = 6;
            this.PurchasedCheck.Text = "Purchased";
            this.PurchasedCheck.UseVisualStyleBackColor = true;
            this.PurchasedCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
<<<<<<< HEAD
            this.label3.Size = new System.Drawing.Size(64, 20);
=======
            this.label3.Size = new System.Drawing.Size(58, 20);
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            this.label3.TabIndex = 5;
            this.label3.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
<<<<<<< HEAD
            this.label2.Size = new System.Drawing.Size(88, 20);
=======
            this.label2.Size = new System.Drawing.Size(83, 20);
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            this.label2.TabIndex = 4;
            this.label2.Text = "Publisher:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
<<<<<<< HEAD
            this.label1.Size = new System.Drawing.Size(48, 20);
=======
            this.label1.Size = new System.Drawing.Size(45, 20);
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(99, 88);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(189, 26);
            this.GenreBox.TabIndex = 2;
            // 
            // PublisherBox
            // 
            this.PublisherBox.Location = new System.Drawing.Point(99, 60);
            this.PublisherBox.Margin = new System.Windows.Forms.Padding(2);
            this.PublisherBox.Name = "PublisherBox";
            this.PublisherBox.Size = new System.Drawing.Size(189, 26);
            this.PublisherBox.TabIndex = 1;
<<<<<<< HEAD
            this.PublisherBox.TextChanged += new System.EventHandler(this.PublisherBox_TextChanged);
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(99, 32);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(189, 26);
            this.TitleBox.TabIndex = 0;
<<<<<<< HEAD
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            // 
            // WishButton
            // 
            this.WishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.WishButton.Location = new System.Drawing.Point(28, 223);
            this.WishButton.Margin = new System.Windows.Forms.Padding(2);
            this.WishButton.Name = "WishButton";
            this.WishButton.Size = new System.Drawing.Size(73, 34);
            this.WishButton.TabIndex = 3;
            this.WishButton.Text = "Wishlist";
            this.WishButton.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.WishButton.Click += new System.EventHandler(this.WishButton_Click);
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.BuyButton.Location = new System.Drawing.Point(105, 223);
            this.BuyButton.Margin = new System.Windows.Forms.Padding(2);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(83, 34);
            this.BuyButton.TabIndex = 4;
            this.BuyButton.Text = "Buy Now";
            this.BuyButton.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
=======
>>>>>>> b79e8bd5ed5ccee801158c95bbcfcbe2d7ad730b
            // 
            // GameDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 547);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.WishButton);
            this.Controls.Add(this.AboutGroup);
            this.Controls.Add(this.DescriptionGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameDetailForm";
            this.Text = "Game View";
            this.Load += new System.EventHandler(this.GameDetailForm_Load);
            this.DescriptionGroup.ResumeLayout(false);
            this.DescriptionGroup.PerformLayout();
            this.AboutGroup.ResumeLayout(false);
            this.AboutGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DescriptionGroup;
        private System.Windows.Forms.GroupBox AboutGroup;
        private System.Windows.Forms.CheckBox WishCheck;
        private System.Windows.Forms.CheckBox PurchasedCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox PublisherBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Button WishButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox DescriptionBox;
    }
}