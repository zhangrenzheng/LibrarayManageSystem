namespace WindowsFormsApp1
{
    partial class DeleteBookForm
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
            this.DeleteBookIdLabel = new System.Windows.Forms.Label();
            this.DeleteBookIdTextBox = new System.Windows.Forms.TextBox();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteBookIdLabel
            // 
            this.DeleteBookIdLabel.AutoSize = true;
            this.DeleteBookIdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBookIdLabel.Location = new System.Drawing.Point(131, 68);
            this.DeleteBookIdLabel.Name = "DeleteBookIdLabel";
            this.DeleteBookIdLabel.Size = new System.Drawing.Size(85, 21);
            this.DeleteBookIdLabel.TabIndex = 0;
            this.DeleteBookIdLabel.Text = "图书编号：";
            // 
            // DeleteBookIdTextBox
            // 
            this.DeleteBookIdTextBox.Location = new System.Drawing.Point(222, 64);
            this.DeleteBookIdTextBox.Name = "DeleteBookIdTextBox";
            this.DeleteBookIdTextBox.Size = new System.Drawing.Size(189, 25);
            this.DeleteBookIdTextBox.TabIndex = 1;
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBookButton.Location = new System.Drawing.Point(222, 125);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(189, 31);
            this.DeleteBookButton.TabIndex = 2;
            this.DeleteBookButton.Text = "注销";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // DeleteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 301);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.DeleteBookIdTextBox);
            this.Controls.Add(this.DeleteBookIdLabel);
            this.Name = "DeleteBookForm";
            this.Text = "删除图书";
            this.Load += new System.EventHandler(this.DeleteBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteBookIdLabel;
        private System.Windows.Forms.TextBox DeleteBookIdTextBox;
        private System.Windows.Forms.Button DeleteBookButton;
    }
}