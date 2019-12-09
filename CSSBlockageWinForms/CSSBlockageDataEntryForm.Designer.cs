namespace CSSBlockageWinForms
{
    partial class CSSBlockageDataEntryForm
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
            this.CSSBlockageEntryFormLabel = new System.Windows.Forms.Label();
            this.CSSBlockageServiceRequestLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BlockTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.ServiceRequestValue = new System.Windows.Forms.TextBox();
            this.BlockageTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BlockageSubTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PreviousBlockageList = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.IsItACritSit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CSSBlockageEntryFormLabel
            // 
            this.CSSBlockageEntryFormLabel.AutoSize = true;
            this.CSSBlockageEntryFormLabel.ForeColor = System.Drawing.Color.Black;
            this.CSSBlockageEntryFormLabel.Location = new System.Drawing.Point(12, 9);
            this.CSSBlockageEntryFormLabel.Name = "CSSBlockageEntryFormLabel";
            this.CSSBlockageEntryFormLabel.Size = new System.Drawing.Size(490, 72);
            this.CSSBlockageEntryFormLabel.TabIndex = 0;
            this.CSSBlockageEntryFormLabel.Text = "CSS Blockage Form";
            // 
            // CSSBlockageServiceRequestLabel
            // 
            this.CSSBlockageServiceRequestLabel.AutoSize = true;
            this.CSSBlockageServiceRequestLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSSBlockageServiceRequestLabel.ForeColor = System.Drawing.Color.Black;
            this.CSSBlockageServiceRequestLabel.Location = new System.Drawing.Point(79, 93);
            this.CSSBlockageServiceRequestLabel.Name = "CSSBlockageServiceRequestLabel";
            this.CSSBlockageServiceRequestLabel.Size = new System.Drawing.Size(293, 51);
            this.CSSBlockageServiceRequestLabel.TabIndex = 1;
            this.CSSBlockageServiceRequestLabel.Text = "Service Request:";
            this.CSSBlockageServiceRequestLabel.Click += new System.EventHandler(this.CSSBlockageServiceRequestLabel_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(134, 157);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(185, 51);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "SR Status:";
            this.StatusLabel.Click += new System.EventHandler(this.StatusLabel_Click);
            // 
            // BlockTypeLabel
            // 
            this.BlockTypeLabel.AutoSize = true;
            this.BlockTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.BlockTypeLabel.Location = new System.Drawing.Point(168, 219);
            this.BlockTypeLabel.Name = "BlockTypeLabel";
            this.BlockTypeLabel.Size = new System.Drawing.Size(208, 51);
            this.BlockTypeLabel.TabIndex = 3;
            this.BlockTypeLabel.Text = "Block Type:";
            this.BlockTypeLabel.Click += new System.EventHandler(this.BlockTypeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blockage SubType:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(382, 154);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(474, 59);
            this.StatusComboBox.TabIndex = 5;
            this.StatusComboBox.Text = "Please Select One";
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // ServiceRequestValue
            // 
            this.ServiceRequestValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceRequestValue.Location = new System.Drawing.Point(382, 90);
            this.ServiceRequestValue.Name = "ServiceRequestValue";
            this.ServiceRequestValue.Size = new System.Drawing.Size(474, 58);
            this.ServiceRequestValue.TabIndex = 6;
            this.ServiceRequestValue.TextChanged += new System.EventHandler(this.ServiceRequestValue_TextChanged);
            // 
            // BlockageTypeComboBox
            // 
            this.BlockageTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockageTypeComboBox.FormattingEnabled = true;
            this.BlockageTypeComboBox.Location = new System.Drawing.Point(382, 219);
            this.BlockageTypeComboBox.Name = "BlockageTypeComboBox";
            this.BlockageTypeComboBox.Size = new System.Drawing.Size(474, 59);
            this.BlockageTypeComboBox.TabIndex = 7;
            this.BlockageTypeComboBox.Text = "Please Select One ";
            this.BlockageTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.BlockageTypeComboBox_SelectedIndexChanged);
            // 
            // BlockageSubTypeComboBox
            // 
            this.BlockageSubTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockageSubTypeComboBox.FormattingEnabled = true;
            this.BlockageSubTypeComboBox.Location = new System.Drawing.Point(382, 289);
            this.BlockageSubTypeComboBox.Name = "BlockageSubTypeComboBox";
            this.BlockageSubTypeComboBox.Size = new System.Drawing.Size(474, 59);
            this.BlockageSubTypeComboBox.TabIndex = 8;
            this.BlockageSubTypeComboBox.Text = "Please Select One";
            this.BlockageSubTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.BlockageSubTypeComboBox_SelectedIndexChanged);
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.ForeColor = System.Drawing.Color.Black;
            this.CommentLabel.Location = new System.Drawing.Point(18, 355);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(278, 72);
            this.CommentLabel.TabIndex = 9;
            this.CommentLabel.Text = "Comment:";
            // 
            // CommentBox
            // 
            this.CommentBox.Location = new System.Drawing.Point(19, 430);
            this.CommentBox.Multiline = true;
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(488, 164);
            this.CommentBox.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 678);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(488, 115);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // PreviousBlockageList
            // 
            this.PreviousBlockageList.AutoSize = true;
            this.PreviousBlockageList.ForeColor = System.Drawing.Color.Black;
            this.PreviousBlockageList.Location = new System.Drawing.Point(12, 600);
            this.PreviousBlockageList.Name = "PreviousBlockageList";
            this.PreviousBlockageList.Size = new System.Drawing.Size(340, 72);
            this.PreviousBlockageList.TabIndex = 12;
            this.PreviousBlockageList.Text = "Open Blocks:";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.Location = new System.Drawing.Point(529, 705);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(134, 88);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Black;
            this.SubmitButton.Location = new System.Drawing.Point(734, 705);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(181, 88);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // IsItACritSit
            // 
            this.IsItACritSit.AutoSize = true;
            this.IsItACritSit.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsItACritSit.ForeColor = System.Drawing.Color.Black;
            this.IsItACritSit.Location = new System.Drawing.Point(575, 430);
            this.IsItACritSit.Name = "IsItACritSit";
            this.IsItACritSit.Size = new System.Drawing.Size(272, 54);
            this.IsItACritSit.TabIndex = 15;
            this.IsItACritSit.Text = "Is it a CRISIT?";
            this.IsItACritSit.UseVisualStyleBackColor = true;
            this.IsItACritSit.CheckedChanged += new System.EventHandler(this.IsItACritSit_CheckedChanged);
            // 
            // CSSBlockageDataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(927, 882);
            this.Controls.Add(this.IsItACritSit);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PreviousBlockageList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.CommentLabel);
            this.Controls.Add(this.BlockageSubTypeComboBox);
            this.Controls.Add(this.BlockageTypeComboBox);
            this.Controls.Add(this.ServiceRequestValue);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlockTypeLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CSSBlockageServiceRequestLabel);
            this.Controls.Add(this.CSSBlockageEntryFormLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "CSSBlockageDataEntryForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CSSBlockageDataEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CSSBlockageEntryFormLabel;
        private System.Windows.Forms.Label CSSBlockageServiceRequestLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label BlockTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox ServiceRequestValue;
        private System.Windows.Forms.ComboBox BlockageTypeComboBox;
        private System.Windows.Forms.ComboBox BlockageSubTypeComboBox;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label PreviousBlockageList;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.CheckBox IsItACritSit;
    }
}

