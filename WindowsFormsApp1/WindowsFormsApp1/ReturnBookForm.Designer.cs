namespace WindowsFormsApp1
{
    partial class ReturnBookForm
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
            this.ReturnBookIdLabel = new System.Windows.Forms.Label();
            this.ReturnBookIdTextBox = new System.Windows.Forms.TextBox();
            this.ReturnBookSearchButton = new System.Windows.Forms.Button();
            this.OverDueLabel = new System.Windows.Forms.Label();
            this.ReturnBookUserIdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BookIdLabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.BorrowingDateLabel = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.ReturnBookSubmitButton = new System.Windows.Forms.Button();
            this.ReturnBookDataGridView = new System.Windows.Forms.DataGridView();
            this.BorrowNumberTextBox = new System.Windows.Forms.TextBox();
            this.ReturnBookUserIdTextBox = new System.Windows.Forms.TextBox();
            this.OverDueTextBox = new System.Windows.Forms.TextBox();
            this.BookIdTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BorrowingDateTextBox = new System.Windows.Forms.TextBox();
            this.ReturnDateTextBox = new System.Windows.Forms.TextBox();
            this.ColumnBorrowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBorrowingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOverDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnBookIdLabel
            // 
            this.ReturnBookIdLabel.AutoSize = true;
            this.ReturnBookIdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnBookIdLabel.Location = new System.Drawing.Point(62, 35);
            this.ReturnBookIdLabel.Name = "ReturnBookIdLabel";
            this.ReturnBookIdLabel.Size = new System.Drawing.Size(55, 21);
            this.ReturnBookIdLabel.TabIndex = 0;
            this.ReturnBookIdLabel.Text = "账号：";
            // 
            // ReturnBookIdTextBox
            // 
            this.ReturnBookIdTextBox.Location = new System.Drawing.Point(123, 31);
            this.ReturnBookIdTextBox.Name = "ReturnBookIdTextBox";
            this.ReturnBookIdTextBox.Size = new System.Drawing.Size(231, 25);
            this.ReturnBookIdTextBox.TabIndex = 1;
            // 
            // ReturnBookSearchButton
            // 
            this.ReturnBookSearchButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnBookSearchButton.Location = new System.Drawing.Point(377, 21);
            this.ReturnBookSearchButton.Name = "ReturnBookSearchButton";
            this.ReturnBookSearchButton.Size = new System.Drawing.Size(75, 35);
            this.ReturnBookSearchButton.TabIndex = 2;
            this.ReturnBookSearchButton.Text = "查询";
            this.ReturnBookSearchButton.UseVisualStyleBackColor = true;
            this.ReturnBookSearchButton.Click += new System.EventHandler(this.ReturnBookSearchButton_Click);
            // 
            // OverDueLabel
            // 
            this.OverDueLabel.AutoSize = true;
            this.OverDueLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OverDueLabel.Location = new System.Drawing.Point(32, 181);
            this.OverDueLabel.Name = "OverDueLabel";
            this.OverDueLabel.Size = new System.Drawing.Size(85, 21);
            this.OverDueLabel.TabIndex = 3;
            this.OverDueLabel.Text = "是否逾期：";
            // 
            // ReturnBookUserIdLabel
            // 
            this.ReturnBookUserIdLabel.AutoSize = true;
            this.ReturnBookUserIdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnBookUserIdLabel.Location = new System.Drawing.Point(62, 135);
            this.ReturnBookUserIdLabel.Name = "ReturnBookUserIdLabel";
            this.ReturnBookUserIdLabel.Size = new System.Drawing.Size(55, 21);
            this.ReturnBookUserIdLabel.TabIndex = 4;
            this.ReturnBookUserIdLabel.Text = "账号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "借书单号：";
            // 
            // BookIdLabel
            // 
            this.BookIdLabel.AutoSize = true;
            this.BookIdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIdLabel.Location = new System.Drawing.Point(338, 90);
            this.BookIdLabel.Name = "BookIdLabel";
            this.BookIdLabel.Size = new System.Drawing.Size(85, 21);
            this.BookIdLabel.TabIndex = 6;
            this.BookIdLabel.Text = "图书编号：";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameLabel.Location = new System.Drawing.Point(368, 135);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(55, 21);
            this.BookNameLabel.TabIndex = 7;
            this.BookNameLabel.Text = "书名：";
            // 
            // BorrowingDateLabel
            // 
            this.BorrowingDateLabel.AutoSize = true;
            this.BorrowingDateLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowingDateLabel.Location = new System.Drawing.Point(338, 188);
            this.BorrowingDateLabel.Name = "BorrowingDateLabel";
            this.BorrowingDateLabel.Size = new System.Drawing.Size(85, 21);
            this.BorrowingDateLabel.TabIndex = 9;
            this.BorrowingDateLabel.Text = "借出日期：";
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnDateLabel.Location = new System.Drawing.Point(649, 90);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(85, 21);
            this.ReturnDateLabel.TabIndex = 10;
            this.ReturnDateLabel.Text = "归还日期：";
            // 
            // ReturnBookSubmitButton
            // 
            this.ReturnBookSubmitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnBookSubmitButton.Location = new System.Drawing.Point(653, 128);
            this.ReturnBookSubmitButton.Name = "ReturnBookSubmitButton";
            this.ReturnBookSubmitButton.Size = new System.Drawing.Size(252, 35);
            this.ReturnBookSubmitButton.TabIndex = 11;
            this.ReturnBookSubmitButton.Text = "点击图书，提交归还";
            this.ReturnBookSubmitButton.UseVisualStyleBackColor = true;
            this.ReturnBookSubmitButton.Click += new System.EventHandler(this.ReturnBookSubmitButton_Click);
            // 
            // ReturnBookDataGridView
            // 
            this.ReturnBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnBookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBorrowNumber,
            this.ColumnUserId,
            this.ColumnBookId,
            this.ColumnBookName,
            this.ColumnBorrowingDate,
            this.ColumnReturnDate,
            this.ColumnOverDue});
            this.ReturnBookDataGridView.Location = new System.Drawing.Point(0, 229);
            this.ReturnBookDataGridView.Name = "ReturnBookDataGridView";
            this.ReturnBookDataGridView.RowTemplate.Height = 27;
            this.ReturnBookDataGridView.Size = new System.Drawing.Size(924, 340);
            this.ReturnBookDataGridView.TabIndex = 12;
            this.ReturnBookDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ReturnBookDataGridView_CellMouseUp);
            // 
            // BorrowNumberTextBox
            // 
            this.BorrowNumberTextBox.Location = new System.Drawing.Point(123, 86);
            this.BorrowNumberTextBox.Name = "BorrowNumberTextBox";
            this.BorrowNumberTextBox.Size = new System.Drawing.Size(165, 25);
            this.BorrowNumberTextBox.TabIndex = 13;
            // 
            // ReturnBookUserIdTextBox
            // 
            this.ReturnBookUserIdTextBox.Location = new System.Drawing.Point(123, 131);
            this.ReturnBookUserIdTextBox.Name = "ReturnBookUserIdTextBox";
            this.ReturnBookUserIdTextBox.Size = new System.Drawing.Size(165, 25);
            this.ReturnBookUserIdTextBox.TabIndex = 14;
            // 
            // OverDueTextBox
            // 
            this.OverDueTextBox.Location = new System.Drawing.Point(123, 181);
            this.OverDueTextBox.Name = "OverDueTextBox";
            this.OverDueTextBox.Size = new System.Drawing.Size(165, 25);
            this.OverDueTextBox.TabIndex = 15;
            // 
            // BookIdTextBox
            // 
            this.BookIdTextBox.Location = new System.Drawing.Point(429, 86);
            this.BookIdTextBox.Name = "BookIdTextBox";
            this.BookIdTextBox.Size = new System.Drawing.Size(165, 25);
            this.BookIdTextBox.TabIndex = 16;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(429, 131);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(165, 25);
            this.BookNameTextBox.TabIndex = 17;
            // 
            // BorrowingDateTextBox
            // 
            this.BorrowingDateTextBox.Location = new System.Drawing.Point(429, 184);
            this.BorrowingDateTextBox.Name = "BorrowingDateTextBox";
            this.BorrowingDateTextBox.Size = new System.Drawing.Size(165, 25);
            this.BorrowingDateTextBox.TabIndex = 19;
            // 
            // ReturnDateTextBox
            // 
            this.ReturnDateTextBox.Location = new System.Drawing.Point(740, 86);
            this.ReturnDateTextBox.Name = "ReturnDateTextBox";
            this.ReturnDateTextBox.Size = new System.Drawing.Size(165, 25);
            this.ReturnDateTextBox.TabIndex = 20;
            // 
            // ColumnBorrowNumber
            // 
            this.ColumnBorrowNumber.DataPropertyName = "borrowNumber";
            this.ColumnBorrowNumber.HeaderText = "借书单号";
            this.ColumnBorrowNumber.Name = "ColumnBorrowNumber";
            // 
            // ColumnUserId
            // 
            this.ColumnUserId.DataPropertyName = "userId";
            this.ColumnUserId.HeaderText = "用户账号";
            this.ColumnUserId.Name = "ColumnUserId";
            // 
            // ColumnBookId
            // 
            this.ColumnBookId.DataPropertyName = "bookId";
            this.ColumnBookId.HeaderText = "图书编号";
            this.ColumnBookId.Name = "ColumnBookId";
            // 
            // ColumnBookName
            // 
            this.ColumnBookName.DataPropertyName = "bookName";
            this.ColumnBookName.HeaderText = "书名";
            this.ColumnBookName.Name = "ColumnBookName";
            // 
            // ColumnBorrowingDate
            // 
            this.ColumnBorrowingDate.DataPropertyName = "borrowingDate";
            this.ColumnBorrowingDate.HeaderText = "借书日期";
            this.ColumnBorrowingDate.Name = "ColumnBorrowingDate";
            // 
            // ColumnReturnDate
            // 
            this.ColumnReturnDate.DataPropertyName = "returnDate";
            this.ColumnReturnDate.HeaderText = "还书日期";
            this.ColumnReturnDate.Name = "ColumnReturnDate";
            // 
            // ColumnOverDue
            // 
            this.ColumnOverDue.DataPropertyName = "overDue";
            this.ColumnOverDue.HeaderText = "是否逾期";
            this.ColumnOverDue.Name = "ColumnOverDue";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 569);
            this.Controls.Add(this.ReturnDateTextBox);
            this.Controls.Add(this.BorrowingDateTextBox);
            this.Controls.Add(this.BookNameTextBox);
            this.Controls.Add(this.BookIdTextBox);
            this.Controls.Add(this.OverDueTextBox);
            this.Controls.Add(this.ReturnBookUserIdTextBox);
            this.Controls.Add(this.BorrowNumberTextBox);
            this.Controls.Add(this.ReturnBookDataGridView);
            this.Controls.Add(this.ReturnBookSubmitButton);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.BorrowingDateLabel);
            this.Controls.Add(this.BookNameLabel);
            this.Controls.Add(this.BookIdLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReturnBookUserIdLabel);
            this.Controls.Add(this.OverDueLabel);
            this.Controls.Add(this.ReturnBookSearchButton);
            this.Controls.Add(this.ReturnBookIdTextBox);
            this.Controls.Add(this.ReturnBookIdLabel);
            this.Name = "ReturnBookForm";
            this.Text = "还书管理";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnBookIdLabel;
        private System.Windows.Forms.TextBox ReturnBookIdTextBox;
        private System.Windows.Forms.Button ReturnBookSearchButton;
        private System.Windows.Forms.Label OverDueLabel;
        private System.Windows.Forms.Label ReturnBookUserIdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BookIdLabel;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label BorrowingDateLabel;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.Button ReturnBookSubmitButton;
        private System.Windows.Forms.DataGridView ReturnBookDataGridView;
        private System.Windows.Forms.TextBox BorrowNumberTextBox;
        private System.Windows.Forms.TextBox ReturnBookUserIdTextBox;
        private System.Windows.Forms.TextBox OverDueTextBox;
        private System.Windows.Forms.TextBox BookIdTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox BorrowingDateTextBox;
        private System.Windows.Forms.TextBox ReturnDateTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBorrowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBorrowingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOverDue;
    }
}