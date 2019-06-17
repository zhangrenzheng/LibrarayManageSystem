namespace WindowsFormsApp1
{
    partial class ChangePasswdForm
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
            this.OldPasswdLabel = new System.Windows.Forms.Label();
            this.OldPasswdTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswdLabel = new System.Windows.Forms.Label();
            this.NewPasswdTextBox = new System.Windows.Forms.TextBox();
            this.ReenterNewPasswdLabel = new System.Windows.Forms.Label();
            this.ReenterNewPasswdTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldPasswdLabel
            // 
            this.OldPasswdLabel.AutoSize = true;
            this.OldPasswdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldPasswdLabel.Location = new System.Drawing.Point(102, 64);
            this.OldPasswdLabel.Name = "OldPasswdLabel";
            this.OldPasswdLabel.Size = new System.Drawing.Size(70, 21);
            this.OldPasswdLabel.TabIndex = 0;
            this.OldPasswdLabel.Text = "旧密码：";
            // 
            // OldPasswdTextBox
            // 
            this.OldPasswdTextBox.Location = new System.Drawing.Point(178, 60);
            this.OldPasswdTextBox.Name = "OldPasswdTextBox";
            this.OldPasswdTextBox.Size = new System.Drawing.Size(189, 25);
            this.OldPasswdTextBox.TabIndex = 1;
            // 
            // NewPasswdLabel
            // 
            this.NewPasswdLabel.AutoSize = true;
            this.NewPasswdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPasswdLabel.Location = new System.Drawing.Point(103, 114);
            this.NewPasswdLabel.Name = "NewPasswdLabel";
            this.NewPasswdLabel.Size = new System.Drawing.Size(70, 21);
            this.NewPasswdLabel.TabIndex = 2;
            this.NewPasswdLabel.Text = "新密码：";
            // 
            // NewPasswdTextBox
            // 
            this.NewPasswdTextBox.Location = new System.Drawing.Point(178, 110);
            this.NewPasswdTextBox.Name = "NewPasswdTextBox";
            this.NewPasswdTextBox.Size = new System.Drawing.Size(189, 25);
            this.NewPasswdTextBox.TabIndex = 3;
            // 
            // ReenterNewPasswdLabel
            // 
            this.ReenterNewPasswdLabel.AutoSize = true;
            this.ReenterNewPasswdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReenterNewPasswdLabel.Location = new System.Drawing.Point(45, 164);
            this.ReenterNewPasswdLabel.Name = "ReenterNewPasswdLabel";
            this.ReenterNewPasswdLabel.Size = new System.Drawing.Size(130, 21);
            this.ReenterNewPasswdLabel.TabIndex = 4;
            this.ReenterNewPasswdLabel.Text = "重新输入新密码：";
            // 
            // ReenterNewPasswdTextBox
            // 
            this.ReenterNewPasswdTextBox.Location = new System.Drawing.Point(178, 160);
            this.ReenterNewPasswdTextBox.Name = "ReenterNewPasswdTextBox";
            this.ReenterNewPasswdTextBox.Size = new System.Drawing.Size(189, 25);
            this.ReenterNewPasswdTextBox.TabIndex = 5;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitButton.Location = new System.Drawing.Point(178, 216);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(189, 32);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "提交";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ChangePasswdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 318);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ReenterNewPasswdTextBox);
            this.Controls.Add(this.ReenterNewPasswdLabel);
            this.Controls.Add(this.NewPasswdTextBox);
            this.Controls.Add(this.NewPasswdLabel);
            this.Controls.Add(this.OldPasswdTextBox);
            this.Controls.Add(this.OldPasswdLabel);
            this.Name = "ChangePasswdForm";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPasswdLabel;
        private System.Windows.Forms.TextBox OldPasswdTextBox;
        private System.Windows.Forms.Label NewPasswdLabel;
        private System.Windows.Forms.TextBox NewPasswdTextBox;
        private System.Windows.Forms.Label ReenterNewPasswdLabel;
        private System.Windows.Forms.TextBox ReenterNewPasswdTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}