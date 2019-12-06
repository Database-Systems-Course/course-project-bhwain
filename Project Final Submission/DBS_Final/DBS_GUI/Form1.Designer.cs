namespace DBS_GUI
{
    partial class Homepage
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
            this.NewGroup = new System.Windows.Forms.GroupBox();
            this.ToolsGroup = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.FaqButton = new System.Windows.Forms.Button();
            this.NewsButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NewGroup.SuspendLayout();
            this.ToolsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGroup
            // 
            this.NewGroup.Controls.Add(this.listBox1);
            this.NewGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NewGroup.Location = new System.Drawing.Point(157, 52);
            this.NewGroup.Margin = new System.Windows.Forms.Padding(2);
            this.NewGroup.Name = "NewGroup";
            this.NewGroup.Padding = new System.Windows.Forms.Padding(2);
            this.NewGroup.Size = new System.Drawing.Size(611, 436);
            this.NewGroup.TabIndex = 4;
            this.NewGroup.TabStop = false;
            this.NewGroup.Text = "WHAT\'S NEW";
            this.NewGroup.Enter += new System.EventHandler(this.NewGroup_Enter);
            // 
            // ToolsGroup
            // 
            this.ToolsGroup.Controls.Add(this.button8);
            this.ToolsGroup.Controls.Add(this.FaqButton);
            this.ToolsGroup.Controls.Add(this.NewsButton);
            this.ToolsGroup.Controls.Add(this.ProfileButton);
            this.ToolsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ToolsGroup.Location = new System.Drawing.Point(8, 52);
            this.ToolsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ToolsGroup.Name = "ToolsGroup";
            this.ToolsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ToolsGroup.Size = new System.Drawing.Size(140, 436);
            this.ToolsGroup.TabIndex = 6;
            this.ToolsGroup.TabStop = false;
            this.ToolsGroup.Text = "Tools";
            this.ToolsGroup.Enter += new System.EventHandler(this.ToolsGroup_Enter);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(19, 387);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 29);
            this.button8.TabIndex = 7;
            this.button8.Text = "Contact Us";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // FaqButton
            // 
            this.FaqButton.Location = new System.Drawing.Point(7, 158);
            this.FaqButton.Margin = new System.Windows.Forms.Padding(2);
            this.FaqButton.Name = "FaqButton";
            this.FaqButton.Size = new System.Drawing.Size(122, 45);
            this.FaqButton.TabIndex = 2;
            this.FaqButton.Text = "FAQ";
            this.FaqButton.UseVisualStyleBackColor = true;
            // 
            // NewsButton
            // 
            this.NewsButton.Location = new System.Drawing.Point(7, 98);
            this.NewsButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(122, 45);
            this.NewsButton.TabIndex = 1;
            this.NewsButton.Text = "News Page";
            this.NewsButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(7, 38);
            this.ProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(122, 45);
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.Text = "My Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LoginButton.Location = new System.Drawing.Point(641, 11);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(123, 29);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login/Register";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(8, 11);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Multiline = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(553, 30);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.Text = "";
            this.SearchBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SearchButton.Location = new System.Drawing.Point(565, 11);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(72, 29);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(5, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(601, 404);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 547);
            this.Controls.Add(this.ToolsGroup);
            this.Controls.Add(this.NewGroup);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.LoginButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.Text = "Homepage/Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NewGroup.ResumeLayout(false);
            this.ToolsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox NewGroup;
        private System.Windows.Forms.GroupBox ToolsGroup;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button FaqButton;
        private System.Windows.Forms.Button NewsButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.RichTextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

