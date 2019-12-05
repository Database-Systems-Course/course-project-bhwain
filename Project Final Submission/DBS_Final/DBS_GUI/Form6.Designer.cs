namespace DBS_GUI
{
    partial class InfoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label3.Location = new System.Drawing.Point(122, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.label2.Location = new System.Drawing.Point(120, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name:";
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(210, 84);
            this.LName.Margin = new System.Windows.Forms.Padding(2);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(194, 20);
            this.LName.TabIndex = 9;
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(210, 60);
            this.FNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(194, 20);
            this.FNameBox.TabIndex = 8;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordBox.Location = new System.Drawing.Point(109, 216);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(295, 23);
            this.PasswordBox.TabIndex = 17;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.EmailBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailBox.Location = new System.Drawing.Point(109, 191);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(295, 23);
            this.EmailBox.TabIndex = 16;
            this.EmailBox.Text = "Email";
            // 
            // ConfirmPasswordBox
            // 
            this.ConfirmPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ConfirmPasswordBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.ConfirmPasswordBox.Location = new System.Drawing.Point(109, 241);
            this.ConfirmPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            this.ConfirmPasswordBox.Size = new System.Drawing.Size(295, 23);
            this.ConfirmPasswordBox.TabIndex = 18;
            this.ConfirmPasswordBox.Text = "Confirm Password";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(332, 268);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 29);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 311);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ConfirmPasswordBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InfoForm";
            this.Text = "Customer_Edit";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox ConfirmPasswordBox;
        private System.Windows.Forms.Button SaveButton;
    }
}