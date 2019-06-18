namespace WindowsFormsApp1
{
    partial class BorrowBookForm
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
            this.BorrowBookInputBookNameLabel = new System.Windows.Forms.Label();
            this.SearchBookNameTextBox = new System.Windows.Forms.TextBox();
            this.BorrowBookSearchButton = new System.Windows.Forms.Button();
            this.BorrowBookIdLabel = new System.Windows.Forms.Label();
            this.BorrowBookNameLabel = new System.Windows.Forms.Label();
            this.BorrowBookPriceLabel = new System.Windows.Forms.Label();
            this.BorrowBookNameTextBox = new System.Windows.Forms.TextBox();
            this.BorrowBookIdTextBox = new System.Windows.Forms.TextBox();
            this.BorrowBookPriceTextBox = new System.Windows.Forms.TextBox();
            this.BorrowBookUserTextBox = new System.Windows.Forms.TextBox();
            this.BorrowBookUserLabel = new System.Windows.Forms.Label();
            this.BorrowBookTimeLabel = new System.Windows.Forms.Label();
            this.BorrowBookDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowBookTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowBookInputBookNameLabel
            // 
            this.BorrowBookInputBookNameLabel.AutoSize = true;
            this.BorrowBookInputBookNameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookInputBookNameLabel.Location = new System.Drawing.Point(118, 36);
            this.BorrowBookInputBookNameLabel.Name = "BorrowBookInputBookNameLabel";
            this.BorrowBookInputBookNameLabel.Size = new System.Drawing.Size(85, 21);
            this.BorrowBookInputBookNameLabel.TabIndex = 0;
            this.BorrowBookInputBookNameLabel.Text = "输入书名：";
            // 
            // SearchBookNameTextBox
            // 
            this.SearchBookNameTextBox.Location = new System.Drawing.Point(209, 32);
            this.SearchBookNameTextBox.Name = "SearchBookNameTextBox";
            this.SearchBookNameTextBox.Size = new System.Drawing.Size(236, 25);
            this.SearchBookNameTextBox.TabIndex = 1;
            // 
            // BorrowBookSearchButton
            // 
            this.BorrowBookSearchButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookSearchButton.Location = new System.Drawing.Point(465, 26);
            this.BorrowBookSearchButton.Name = "BorrowBookSearchButton";
            this.BorrowBookSearchButton.Size = new System.Drawing.Size(75, 33);
            this.BorrowBookSearchButton.TabIndex = 2;
            this.BorrowBookSearchButton.Text = "查询";
            this.BorrowBookSearchButton.UseVisualStyleBackColor = true;
            this.BorrowBookSearchButton.Click += new System.EventHandler(this.BorrowBookSearchButton_Click);
            // 
            // BorrowBookIdLabel
            // 
            this.BorrowBookIdLabel.AutoSize = true;
            this.BorrowBookIdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookIdLabel.Location = new System.Drawing.Point(118, 78);
            this.BorrowBookIdLabel.Name = "BorrowBookIdLabel";
            this.BorrowBookIdLabel.Size = new System.Drawing.Size(85, 21);
            this.BorrowBookIdLabel.TabIndex = 3;
            this.BorrowBookIdLabel.Text = "图书编号：";
            // 
            // BorrowBookNameLabel
            // 
            this.BorrowBookNameLabel.AutoSize = true;
            this.BorrowBookNameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookNameLabel.Location = new System.Drawing.Point(148, 131);
            this.BorrowBookNameLabel.Name = "BorrowBookNameLabel";
            this.BorrowBookNameLabel.Size = new System.Drawing.Size(55, 21);
            this.BorrowBookNameLabel.TabIndex = 4;
            this.BorrowBookNameLabel.Text = "书名：";
            // 
            // BorrowBookPriceLabel
            // 
            this.BorrowBookPriceLabel.AutoSize = true;
            this.BorrowBookPriceLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookPriceLabel.Location = new System.Drawing.Point(148, 184);
            this.BorrowBookPriceLabel.Name = "BorrowBookPriceLabel";
            this.BorrowBookPriceLabel.Size = new System.Drawing.Size(55, 21);
            this.BorrowBookPriceLabel.TabIndex = 5;
            this.BorrowBookPriceLabel.Text = "价格：";
            // 
            // BorrowBookNameTextBox
            // 
            this.BorrowBookNameTextBox.Location = new System.Drawing.Point(209, 127);
            this.BorrowBookNameTextBox.Name = "BorrowBookNameTextBox";
            this.BorrowBookNameTextBox.ReadOnly = true;
            this.BorrowBookNameTextBox.Size = new System.Drawing.Size(236, 25);
            this.BorrowBookNameTextBox.TabIndex = 6;
            // 
            // BorrowBookIdTextBox
            // 
            this.BorrowBookIdTextBox.Location = new System.Drawing.Point(209, 71);
            this.BorrowBookIdTextBox.Name = "BorrowBookIdTextBox";
            this.BorrowBookIdTextBox.ReadOnly = true;
            this.BorrowBookIdTextBox.Size = new System.Drawing.Size(236, 25);
            this.BorrowBookIdTextBox.TabIndex = 7;
            // 
            // BorrowBookPriceTextBox
            // 
            this.BorrowBookPriceTextBox.Location = new System.Drawing.Point(209, 180);
            this.BorrowBookPriceTextBox.Name = "BorrowBookPriceTextBox";
            this.BorrowBookPriceTextBox.ReadOnly = true;
            this.BorrowBookPriceTextBox.Size = new System.Drawing.Size(236, 25);
            this.BorrowBookPriceTextBox.TabIndex = 8;
            // 
            // BorrowBookUserTextBox
            // 
            this.BorrowBookUserTextBox.Location = new System.Drawing.Point(603, 71);
            this.BorrowBookUserTextBox.Name = "BorrowBookUserTextBox";
            this.BorrowBookUserTextBox.ReadOnly = true;
            this.BorrowBookUserTextBox.Size = new System.Drawing.Size(236, 25);
            this.BorrowBookUserTextBox.TabIndex = 9;
            // 
            // BorrowBookUserLabel
            // 
            this.BorrowBookUserLabel.AutoSize = true;
            this.BorrowBookUserLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookUserLabel.Location = new System.Drawing.Point(512, 75);
            this.BorrowBookUserLabel.Name = "BorrowBookUserLabel";
            this.BorrowBookUserLabel.Size = new System.Drawing.Size(85, 21);
            this.BorrowBookUserLabel.TabIndex = 10;
            this.BorrowBookUserLabel.Text = "借书用户：";
            // 
            // BorrowBookTimeLabel
            // 
            this.BorrowBookTimeLabel.AutoSize = true;
            this.BorrowBookTimeLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookTimeLabel.Location = new System.Drawing.Point(512, 131);
            this.BorrowBookTimeLabel.Name = "BorrowBookTimeLabel";
            this.BorrowBookTimeLabel.Size = new System.Drawing.Size(85, 21);
            this.BorrowBookTimeLabel.TabIndex = 11;
            this.BorrowBookTimeLabel.Text = "借阅时长：";
            // 
            // BorrowBookDataGridView
            // 
            this.BorrowBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BorrowBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BorrowBookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBookId,
            this.ColumnBookName,
            this.ColumnAuthor,
            this.ColumnScore,
            this.ColumnPress,
            this.ColumnPrice,
            this.ColumnAmount});
            this.BorrowBookDataGridView.Location = new System.Drawing.Point(54, 224);
            this.BorrowBookDataGridView.Name = "BorrowBookDataGridView";
            this.BorrowBookDataGridView.RowTemplate.Height = 27;
            this.BorrowBookDataGridView.Size = new System.Drawing.Size(876, 321);
            this.BorrowBookDataGridView.TabIndex = 12;
            this.BorrowBookDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BorrowBookDataGridView_CellMouseUp);
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
            // ColumnAuthor
            // 
            this.ColumnAuthor.DataPropertyName = "author";
            this.ColumnAuthor.HeaderText = "作者";
            this.ColumnAuthor.Name = "ColumnAuthor";
            // 
            // ColumnScore
            // 
            this.ColumnScore.DataPropertyName = "score";
            this.ColumnScore.HeaderText = "评分";
            this.ColumnScore.Name = "ColumnScore";
            // 
            // ColumnPress
            // 
            this.ColumnPress.DataPropertyName = "press";
            this.ColumnPress.HeaderText = "出版社";
            this.ColumnPress.Name = "ColumnPress";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "price";
            this.ColumnPrice.HeaderText = "价格";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.DataPropertyName = "amount";
            this.ColumnAmount.HeaderText = "库存";
            this.ColumnAmount.Name = "ColumnAmount";
            // 
            // BorrowBookTimeComboBox
            // 
            this.BorrowBookTimeComboBox.FormattingEnabled = true;
            this.BorrowBookTimeComboBox.Items.AddRange(new object[] {
            "30天",
            "60天",
            "90天"});
            this.BorrowBookTimeComboBox.Location = new System.Drawing.Point(605, 127);
            this.BorrowBookTimeComboBox.Name = "BorrowBookTimeComboBox";
            this.BorrowBookTimeComboBox.Size = new System.Drawing.Size(234, 23);
            this.BorrowBookTimeComboBox.TabIndex = 13;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitButton.Location = new System.Drawing.Point(516, 172);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(323, 31);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "选择书籍，单击提交";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 569);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BorrowBookTimeComboBox);
            this.Controls.Add(this.BorrowBookDataGridView);
            this.Controls.Add(this.BorrowBookTimeLabel);
            this.Controls.Add(this.BorrowBookUserLabel);
            this.Controls.Add(this.BorrowBookUserTextBox);
            this.Controls.Add(this.BorrowBookPriceTextBox);
            this.Controls.Add(this.BorrowBookIdTextBox);
            this.Controls.Add(this.BorrowBookNameTextBox);
            this.Controls.Add(this.BorrowBookPriceLabel);
            this.Controls.Add(this.BorrowBookNameLabel);
            this.Controls.Add(this.BorrowBookIdLabel);
            this.Controls.Add(this.BorrowBookSearchButton);
            this.Controls.Add(this.SearchBookNameTextBox);
            this.Controls.Add(this.BorrowBookInputBookNameLabel);
            this.Name = "BorrowBookForm";
            this.Text = "借书管理";
            this.Load += new System.EventHandler(this.BorrowBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BorrowBookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BorrowBookInputBookNameLabel;
        private System.Windows.Forms.TextBox SearchBookNameTextBox;
        private System.Windows.Forms.Button BorrowBookSearchButton;
        private System.Windows.Forms.Label BorrowBookIdLabel;
        private System.Windows.Forms.Label BorrowBookNameLabel;
        private System.Windows.Forms.Label BorrowBookPriceLabel;
        private System.Windows.Forms.TextBox BorrowBookNameTextBox;
        private System.Windows.Forms.TextBox BorrowBookIdTextBox;
        private System.Windows.Forms.TextBox BorrowBookPriceTextBox;
        private System.Windows.Forms.TextBox BorrowBookUserTextBox;
        private System.Windows.Forms.Label BorrowBookUserLabel;
        private System.Windows.Forms.Label BorrowBookTimeLabel;
        private System.Windows.Forms.DataGridView BorrowBookDataGridView;
        private System.Windows.Forms.ComboBox BorrowBookTimeComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
    }
}