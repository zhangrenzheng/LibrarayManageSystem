namespace WindowsFormsApp1
{
    partial class SearchBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBookNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.RefreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HomePageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrePageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NextPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LastPageToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SearchBookDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入书名查询：";
            // 
            // SearchBookNameTextBox
            // 
            this.SearchBookNameTextBox.Location = new System.Drawing.Point(174, 39);
            this.SearchBookNameTextBox.Name = "SearchBookNameTextBox";
            this.SearchBookNameTextBox.Size = new System.Drawing.Size(279, 25);
            this.SearchBookNameTextBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchButton.Location = new System.Drawing.Point(459, 37);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 32);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "查找";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.RefreshToolStripButton,
            this.HomePageToolStripButton,
            this.PrePageToolStripButton,
            this.NextPageToolStripButton,
            this.LastPageToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 535);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(956, 28);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 25);
            this.toolStripLabel1.Text = "        ";
            // 
            // RefreshToolStripButton
            // 
            this.RefreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshToolStripButton.Image")));
            this.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolStripButton.Name = "RefreshToolStripButton";
            this.RefreshToolStripButton.Size = new System.Drawing.Size(44, 25);
            this.RefreshToolStripButton.Text = "刷新";
            this.RefreshToolStripButton.Click += new System.EventHandler(this.RefreshToolStripButton_Click);
            // 
            // HomePageToolStripButton
            // 
            this.HomePageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HomePageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HomePageToolStripButton.Image")));
            this.HomePageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomePageToolStripButton.Name = "HomePageToolStripButton";
            this.HomePageToolStripButton.Size = new System.Drawing.Size(44, 25);
            this.HomePageToolStripButton.Text = "首页";
            this.HomePageToolStripButton.Click += new System.EventHandler(this.HomePageToolStripButton_Click);
            // 
            // PrePageToolStripButton
            // 
            this.PrePageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PrePageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrePageToolStripButton.Image")));
            this.PrePageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrePageToolStripButton.Name = "PrePageToolStripButton";
            this.PrePageToolStripButton.Size = new System.Drawing.Size(59, 25);
            this.PrePageToolStripButton.Text = "上一页";
            this.PrePageToolStripButton.Click += new System.EventHandler(this.PrePageToolStripButton_Click);
            // 
            // NextPageToolStripButton
            // 
            this.NextPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NextPageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NextPageToolStripButton.Image")));
            this.NextPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextPageToolStripButton.Name = "NextPageToolStripButton";
            this.NextPageToolStripButton.Size = new System.Drawing.Size(59, 25);
            this.NextPageToolStripButton.Text = "下一页";
            this.NextPageToolStripButton.Click += new System.EventHandler(this.NextPageToolStripButton_Click);
            // 
            // LastPageToolStripButton
            // 
            this.LastPageToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LastPageToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LastPageToolStripButton.Image")));
            this.LastPageToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastPageToolStripButton.Name = "LastPageToolStripButton";
            this.LastPageToolStripButton.Size = new System.Drawing.Size(44, 25);
            this.LastPageToolStripButton.Text = "末页";
            this.LastPageToolStripButton.Click += new System.EventHandler(this.LastPageToolStripButton_Click);
            // 
            // SearchBookDataGridView
            // 
            this.SearchBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBookId,
            this.ColumnBookName,
            this.ColumnAuthor,
            this.ColumnScore,
            this.ColumnPress,
            this.ColumnPrice,
            this.ColumnAmount});
            this.SearchBookDataGridView.Location = new System.Drawing.Point(68, 75);
            this.SearchBookDataGridView.Name = "SearchBookDataGridView";
            this.SearchBookDataGridView.RowTemplate.Height = 27;
            this.SearchBookDataGridView.Size = new System.Drawing.Size(838, 441);
            this.SearchBookDataGridView.TabIndex = 7;
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
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 563);
            this.Controls.Add(this.SearchBookDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBookNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchBookForm";
            this.Text = "图书查询";
            this.Load += new System.EventHandler(this.SearchBookForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBookNameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RefreshToolStripButton;
        private System.Windows.Forms.ToolStripButton HomePageToolStripButton;
        private System.Windows.Forms.ToolStripButton PrePageToolStripButton;
        private System.Windows.Forms.ToolStripButton NextPageToolStripButton;
        private System.Windows.Forms.ToolStripButton LastPageToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView SearchBookDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
    }
}