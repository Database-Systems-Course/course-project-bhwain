namespace DBS_GUI
{
    partial class LoginForm
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
            this.LoginGroup = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SigninButton = new System.Windows.Forms.Button();
            this.LogPasswordBox = new System.Windows.Forms.TextBox();
            this.LogEmailBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegisterGroup = new System.Windows.Forms.GroupBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterDetailGroup = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.RegPasswordBox = new System.Windows.Forms.TextBox();
            this.RegEmailBox = new System.Windows.Forms.TextBox();
            this.LoginGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.RegisterGroup.SuspendLayout();
            this.RegisterDetailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGroup
            // 
            this.LoginGroup.Controls.Add(this.SigninButton);
            this.LoginGroup.Controls.Add(this.LogPasswordBox);
            this.LoginGroup.Controls.Add(this.LogEmailBox);
            this.LoginGroup.Controls.Add(this.groupBox1);
            this.LoginGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LoginGroup.Location = new System.Drawing.Point(11, 11);
            this.LoginGroup.Margin = new System.Windows.Forms.Padding(2);
            this.LoginGroup.Name = "LoginGroup";
            this.LoginGroup.Padding = new System.Windows.Forms.Padding(2);
            this.LoginGroup.Size = new System.Drawing.Size(231, 267);
            this.LoginGroup.TabIndex = 0;
            this.LoginGroup.TabStop = false;
            this.LoginGroup.Text = "Login";
            this.LoginGroup.Enter += new System.EventHandler(this.LoginGroup_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 71);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Developer";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Customer";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // SigninButton
            // 
            this.SigninButton.Location = new System.Drawing.Point(135, 103);
            this.SigninButton.Margin = new System.Windows.Forms.Padding(2);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(84, 32);
            this.SigninButton.TabIndex = 2;
            this.SigninButton.Text = "Sign In";
            this.SigninButton.UseVisualStyleBackColor = true;
            this.SigninButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogPasswordBox
            // 
            this.LogPasswordBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LogPasswordBox.Location = new System.Drawing.Point(13, 73);
            this.LogPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogPasswordBox.Name = "LogPasswordBox";
            this.LogPasswordBox.Size = new System.Drawing.Size(206, 26);
            this.LogPasswordBox.TabIndex = 1;
            this.LogPasswordBox.Text = "Password";
            this.LogPasswordBox.TextChanged += new System.EventHandler(this.LogPasswordBox_TextChanged);
            // 
            // LogEmailBox
            // 
            this.LogEmailBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LogEmailBox.Location = new System.Drawing.Point(13, 46);
            this.LogEmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.LogEmailBox.Name = "LogEmailBox";
            this.LogEmailBox.Size = new System.Drawing.Size(206, 26);
            this.LogEmailBox.TabIndex = 0;
            this.LogEmailBox.Text = "Email";
            this.LogEmailBox.TextChanged += new System.EventHandler(this.LogEmailBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(5, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login As:";
            // 
            // RegisterGroup
            // 
            this.RegisterGroup.Controls.Add(this.RegisterButton);
            this.RegisterGroup.Controls.Add(this.RegisterDetailGroup);
            this.RegisterGroup.Controls.Add(this.RegPasswordBox);
            this.RegisterGroup.Controls.Add(this.RegEmailBox);
            this.RegisterGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RegisterGroup.Location = new System.Drawing.Point(260, 11);
            this.RegisterGroup.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterGroup.Name = "RegisterGroup";
            this.RegisterGroup.Padding = new System.Windows.Forms.Padding(2);
            this.RegisterGroup.Size = new System.Drawing.Size(236, 267);
            this.RegisterGroup.TabIndex = 1;
            this.RegisterGroup.TabStop = false;
            this.RegisterGroup.Text = "Register";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(130, 190);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(92, 32);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterDetailGroup
            // 
            this.RegisterDetailGroup.Controls.Add(this.radioButton4);
            this.RegisterDetailGroup.Controls.Add(this.radioButton3);
            this.RegisterDetailGroup.Location = new System.Drawing.Point(16, 103);
            this.RegisterDetailGroup.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterDetailGroup.Name = "RegisterDetailGroup";
            this.RegisterDetailGroup.Padding = new System.Windows.Forms.Padding(2);
            this.RegisterDetailGroup.Size = new System.Drawing.Size(206, 83);
            this.RegisterDetailGroup.TabIndex = 7;
            this.RegisterDetailGroup.TabStop = false;
            this.RegisterDetailGroup.Text = "Registering As:";
            this.RegisterDetailGroup.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(93, 54);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(108, 24);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Developer";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(93, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Customer";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RegPasswordBox
            // 
            this.RegPasswordBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RegPasswordBox.Location = new System.Drawing.Point(16, 73);
            this.RegPasswordBox.Margin = new System.Windows.Forms.Padding(2);
            this.RegPasswordBox.Name = "RegPasswordBox";
            this.RegPasswordBox.Size = new System.Drawing.Size(206, 26);
            this.RegPasswordBox.TabIndex = 4;
            this.RegPasswordBox.Text = "Password";
            // 
            // RegEmailBox
            // 
            this.RegEmailBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RegEmailBox.Location = new System.Drawing.Point(16, 46);
            this.RegEmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.RegEmailBox.Name = "RegEmailBox";
            this.RegEmailBox.Size = new System.Drawing.Size(206, 26);
            this.RegEmailBox.TabIndex = 3;
            this.RegEmailBox.Text = "Email";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 287);
            this.Controls.Add(this.RegisterGroup);
            this.Controls.Add(this.LoginGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "Login/Register";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.LoginGroup.ResumeLayout(false);
            this.LoginGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.RegisterGroup.ResumeLayout(false);
            this.RegisterGroup.PerformLayout();
            this.RegisterDetailGroup.ResumeLayout(false);
            this.RegisterDetailGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroup;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.TextBox LogPasswordBox;
        private System.Windows.Forms.TextBox LogEmailBox;
        private System.Windows.Forms.GroupBox RegisterGroup;
        private System.Windows.Forms.GroupBox RegisterDetailGroup;
        private System.Windows.Forms.TextBox RegPasswordBox;
        private System.Windows.Forms.TextBox RegEmailBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}