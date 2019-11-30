namespace CSSBlockageWinForms
{
    partial class CSSBlockageLogin
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
            this.BlockageLoginFormLabel = new System.Windows.Forms.Label();
            this.EngineerUsernameLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlockageLoginFormLabel
            // 
            this.BlockageLoginFormLabel.AutoSize = true;
            this.BlockageLoginFormLabel.ForeColor = System.Drawing.Color.Black;
            this.BlockageLoginFormLabel.Location = new System.Drawing.Point(109, 9);
            this.BlockageLoginFormLabel.Name = "BlockageLoginFormLabel";
            this.BlockageLoginFormLabel.Size = new System.Drawing.Size(244, 37);
            this.BlockageLoginFormLabel.TabIndex = 1;
            this.BlockageLoginFormLabel.Text = "CSS Blockage Form";
            // 
            // EngineerUsernameLabel
            // 
            this.EngineerUsernameLabel.AutoSize = true;
            this.EngineerUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngineerUsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.EngineerUsernameLabel.Location = new System.Drawing.Point(32, 139);
            this.EngineerUsernameLabel.Name = "EngineerUsernameLabel";
            this.EngineerUsernameLabel.Size = new System.Drawing.Size(156, 30);
            this.EngineerUsernameLabel.TabIndex = 3;
            this.EngineerUsernameLabel.Text = "Microsoft Alias:";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(194, 139);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(236, 35);
            this.userName.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(84, 216);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 30);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(194, 211);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(236, 35);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(341, 297);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(89, 40);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // CSSBlockageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 416);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.EngineerUsernameLabel);
            this.Controls.Add(this.BlockageLoginFormLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CSSBlockageLogin";
            this.Text = "CSSBlockageLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BlockageLoginFormLabel;
        private System.Windows.Forms.Label EngineerUsernameLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
    }
}