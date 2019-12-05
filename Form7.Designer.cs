namespace DBS_GUI
{
    partial class SearchResultForm
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
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.ResultList = new System.Windows.Forms.ListBox();
            this.ResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.ResultList);
            this.ResultGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ResultGroup.Location = new System.Drawing.Point(11, 11);
            this.ResultGroup.Margin = new System.Windows.Forms.Padding(2);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Padding = new System.Windows.Forms.Padding(2);
            this.ResultGroup.Size = new System.Drawing.Size(730, 456);
            this.ResultGroup.TabIndex = 14;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "Results";
            // 
            // ResultList
            // 
            this.ResultList.FormattingEnabled = true;
            this.ResultList.ItemHeight = 20;
            this.ResultList.Location = new System.Drawing.Point(5, 24);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(720, 424);
            this.ResultList.TabIndex = 0;
            this.ResultList.SelectedIndexChanged += new System.EventHandler(this.ResultList_SelectedIndexChanged);
            this.ResultList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ResultList_MouseDoubleClick_1);
            this.ResultList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultList_MouseDown);
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 477);
            this.Controls.Add(this.ResultGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchResultForm";
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResultGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.ListBox ResultList;
    }
}