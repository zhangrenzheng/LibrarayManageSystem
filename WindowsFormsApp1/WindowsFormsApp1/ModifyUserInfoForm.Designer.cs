namespace WindowsFormsApp1
{
    partial class ModifyUserInfoForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SexLabel = new System.Windows.Forms.Label();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusDisplayLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AddUserPanel = new System.Windows.Forms.Panel();
            this.DeleteUserPanel = new System.Windows.Forms.Panel();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.DeleteUserAccountTextBox = new System.Windows.Forms.TextBox();
            this.DeleteUserAccountLabel = new System.Windows.Forms.Label();
            this.DeleteUserLabel = new System.Windows.Forms.Label();
            this.AddUserPhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddUserFemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.AddUserMaleRadioButton = new System.Windows.Forms.RadioButton();
            this.AddUserPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddUserPasswdTextBox = new System.Windows.Forms.TextBox();
            this.AddUserNameLabelTextBox = new System.Windows.Forms.TextBox();
            this.AddUserAccountTextbox = new System.Windows.Forms.TextBox();
            this.AddUserSubmitButton = new System.Windows.Forms.Button();
            this.AddUserSexLabel = new System.Windows.Forms.Label();
            this.AddUserPasswdLabel = new System.Windows.Forms.Label();
            this.AddUserNameLabel = new System.Windows.Forms.Label();
            this.AddUserAccountLabel = new System.Windows.Forms.Label();
            this.AddUserPanel.SuspendLayout();
            this.DeleteUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(189, 47);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "姓名：";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(250, 43);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(193, 25);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountLabel.Location = new System.Drawing.Point(189, 88);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(55, 21);
            this.AccountLabel.TabIndex = 2;
            this.AccountLabel.Text = "账号：";
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(250, 88);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(193, 25);
            this.AccountTextBox.TabIndex = 3;
            this.AccountTextBox.TextChanged += new System.EventHandler(this.AccountTextBox_TextChanged);
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaleRadioButton.Location = new System.Drawing.Point(250, 134);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(46, 25);
            this.MaleRadioButton.TabIndex = 4;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "男";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            this.MaleRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SexLabel.Location = new System.Drawing.Point(189, 136);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(55, 21);
            this.SexLabel.TabIndex = 5;
            this.SexLabel.Text = "性别：";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FemaleRadioButton.Location = new System.Drawing.Point(302, 134);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(46, 25);
            this.FemaleRadioButton.TabIndex = 6;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "女";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(189, 176);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(55, 21);
            this.PhoneNumberLabel.TabIndex = 7;
            this.PhoneNumberLabel.Text = "电话：";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(250, 172);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(193, 25);
            this.PhoneNumberTextBox.TabIndex = 8;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StatusLabel.Location = new System.Drawing.Point(189, 217);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(55, 21);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "状态：";
            // 
            // StatusDisplayLabel
            // 
            this.StatusDisplayLabel.AutoSize = true;
            this.StatusDisplayLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StatusDisplayLabel.Location = new System.Drawing.Point(250, 217);
            this.StatusDisplayLabel.Name = "StatusDisplayLabel";
            this.StatusDisplayLabel.Size = new System.Drawing.Size(40, 21);
            this.StatusDisplayLabel.TabIndex = 10;
            this.StatusDisplayLabel.Text = "正常";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SubmitButton.Location = new System.Drawing.Point(250, 267);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(193, 32);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "提交";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AddUserPanel
            // 
            this.AddUserPanel.Controls.Add(this.DeleteUserPanel);
            this.AddUserPanel.Controls.Add(this.AddUserPhoneNumberLabel);
            this.AddUserPanel.Controls.Add(this.AddUserFemaleRadioButton);
            this.AddUserPanel.Controls.Add(this.AddUserMaleRadioButton);
            this.AddUserPanel.Controls.Add(this.AddUserPhoneNumberTextBox);
            this.AddUserPanel.Controls.Add(this.AddUserPasswdTextBox);
            this.AddUserPanel.Controls.Add(this.AddUserNameLabelTextBox);
            this.AddUserPanel.Controls.Add(this.AddUserAccountTextbox);
            this.AddUserPanel.Controls.Add(this.AddUserSubmitButton);
            this.AddUserPanel.Controls.Add(this.AddUserSexLabel);
            this.AddUserPanel.Controls.Add(this.AddUserPasswdLabel);
            this.AddUserPanel.Controls.Add(this.AddUserNameLabel);
            this.AddUserPanel.Controls.Add(this.AddUserAccountLabel);
            this.AddUserPanel.Location = new System.Drawing.Point(31, 12);
            this.AddUserPanel.Name = "AddUserPanel";
            this.AddUserPanel.Size = new System.Drawing.Size(560, 333);
            this.AddUserPanel.TabIndex = 12;
            // 
            // DeleteUserPanel
            // 
            this.DeleteUserPanel.Controls.Add(this.DeleteUserButton);
            this.DeleteUserPanel.Controls.Add(this.DeleteUserAccountTextBox);
            this.DeleteUserPanel.Controls.Add(this.DeleteUserAccountLabel);
            this.DeleteUserPanel.Controls.Add(this.DeleteUserLabel);
            this.DeleteUserPanel.Location = new System.Drawing.Point(36, 16);
            this.DeleteUserPanel.Name = "DeleteUserPanel";
            this.DeleteUserPanel.Size = new System.Drawing.Size(487, 301);
            this.DeleteUserPanel.TabIndex = 12;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteUserButton.Location = new System.Drawing.Point(194, 141);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(182, 35);
            this.DeleteUserButton.TabIndex = 3;
            this.DeleteUserButton.Text = "注销";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // DeleteUserAccountTextBox
            // 
            this.DeleteUserAccountTextBox.Location = new System.Drawing.Point(194, 85);
            this.DeleteUserAccountTextBox.Name = "DeleteUserAccountTextBox";
            this.DeleteUserAccountTextBox.Size = new System.Drawing.Size(182, 25);
            this.DeleteUserAccountTextBox.TabIndex = 2;
            // 
            // DeleteUserAccountLabel
            // 
            this.DeleteUserAccountLabel.AutoSize = true;
            this.DeleteUserAccountLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteUserAccountLabel.Location = new System.Drawing.Point(133, 89);
            this.DeleteUserAccountLabel.Name = "DeleteUserAccountLabel";
            this.DeleteUserAccountLabel.Size = new System.Drawing.Size(55, 21);
            this.DeleteUserAccountLabel.TabIndex = 1;
            this.DeleteUserAccountLabel.Text = "账号：";
            // 
            // DeleteUserLabel
            // 
            this.DeleteUserLabel.AutoSize = true;
            this.DeleteUserLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteUserLabel.Location = new System.Drawing.Point(213, 33);
            this.DeleteUserLabel.Name = "DeleteUserLabel";
            this.DeleteUserLabel.Size = new System.Drawing.Size(92, 28);
            this.DeleteUserLabel.TabIndex = 0;
            this.DeleteUserLabel.Text = "注销用户";
            // 
            // AddUserPhoneNumberLabel
            // 
            this.AddUserPhoneNumberLabel.AutoSize = true;
            this.AddUserPhoneNumberLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserPhoneNumberLabel.Location = new System.Drawing.Point(159, 204);
            this.AddUserPhoneNumberLabel.Name = "AddUserPhoneNumberLabel";
            this.AddUserPhoneNumberLabel.Size = new System.Drawing.Size(55, 21);
            this.AddUserPhoneNumberLabel.TabIndex = 11;
            this.AddUserPhoneNumberLabel.Text = "电话：";
            // 
            // AddUserFemaleRadioButton
            // 
            this.AddUserFemaleRadioButton.AutoSize = true;
            this.AddUserFemaleRadioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserFemaleRadioButton.Location = new System.Drawing.Point(272, 157);
            this.AddUserFemaleRadioButton.Name = "AddUserFemaleRadioButton";
            this.AddUserFemaleRadioButton.Size = new System.Drawing.Size(46, 25);
            this.AddUserFemaleRadioButton.TabIndex = 10;
            this.AddUserFemaleRadioButton.TabStop = true;
            this.AddUserFemaleRadioButton.Text = "女";
            this.AddUserFemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddUserMaleRadioButton
            // 
            this.AddUserMaleRadioButton.AutoSize = true;
            this.AddUserMaleRadioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserMaleRadioButton.Location = new System.Drawing.Point(220, 157);
            this.AddUserMaleRadioButton.Name = "AddUserMaleRadioButton";
            this.AddUserMaleRadioButton.Size = new System.Drawing.Size(46, 25);
            this.AddUserMaleRadioButton.TabIndex = 9;
            this.AddUserMaleRadioButton.TabStop = true;
            this.AddUserMaleRadioButton.Text = "男";
            this.AddUserMaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddUserPhoneNumberTextBox
            // 
            this.AddUserPhoneNumberTextBox.Location = new System.Drawing.Point(220, 200);
            this.AddUserPhoneNumberTextBox.Name = "AddUserPhoneNumberTextBox";
            this.AddUserPhoneNumberTextBox.Size = new System.Drawing.Size(188, 25);
            this.AddUserPhoneNumberTextBox.TabIndex = 8;
            // 
            // AddUserPasswdTextBox
            // 
            this.AddUserPasswdTextBox.Location = new System.Drawing.Point(220, 117);
            this.AddUserPasswdTextBox.Name = "AddUserPasswdTextBox";
            this.AddUserPasswdTextBox.Size = new System.Drawing.Size(188, 25);
            this.AddUserPasswdTextBox.TabIndex = 7;
            // 
            // AddUserNameLabelTextBox
            // 
            this.AddUserNameLabelTextBox.Location = new System.Drawing.Point(220, 82);
            this.AddUserNameLabelTextBox.Name = "AddUserNameLabelTextBox";
            this.AddUserNameLabelTextBox.Size = new System.Drawing.Size(188, 25);
            this.AddUserNameLabelTextBox.TabIndex = 6;
            // 
            // AddUserAccountTextbox
            // 
            this.AddUserAccountTextbox.Location = new System.Drawing.Point(220, 44);
            this.AddUserAccountTextbox.Name = "AddUserAccountTextbox";
            this.AddUserAccountTextbox.Size = new System.Drawing.Size(188, 25);
            this.AddUserAccountTextbox.TabIndex = 5;
            // 
            // AddUserSubmitButton
            // 
            this.AddUserSubmitButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserSubmitButton.Location = new System.Drawing.Point(220, 254);
            this.AddUserSubmitButton.Name = "AddUserSubmitButton";
            this.AddUserSubmitButton.Size = new System.Drawing.Size(188, 32);
            this.AddUserSubmitButton.TabIndex = 4;
            this.AddUserSubmitButton.Text = "提交";
            this.AddUserSubmitButton.UseVisualStyleBackColor = true;
            this.AddUserSubmitButton.Click += new System.EventHandler(this.AddUserSubmitButton_Click);
            // 
            // AddUserSexLabel
            // 
            this.AddUserSexLabel.AutoSize = true;
            this.AddUserSexLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserSexLabel.Location = new System.Drawing.Point(159, 159);
            this.AddUserSexLabel.Name = "AddUserSexLabel";
            this.AddUserSexLabel.Size = new System.Drawing.Size(55, 21);
            this.AddUserSexLabel.TabIndex = 3;
            this.AddUserSexLabel.Text = "性别：";
            // 
            // AddUserPasswdLabel
            // 
            this.AddUserPasswdLabel.AutoSize = true;
            this.AddUserPasswdLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserPasswdLabel.Location = new System.Drawing.Point(159, 121);
            this.AddUserPasswdLabel.Name = "AddUserPasswdLabel";
            this.AddUserPasswdLabel.Size = new System.Drawing.Size(55, 21);
            this.AddUserPasswdLabel.TabIndex = 2;
            this.AddUserPasswdLabel.Text = "密码：";
            // 
            // AddUserNameLabel
            // 
            this.AddUserNameLabel.AutoSize = true;
            this.AddUserNameLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserNameLabel.Location = new System.Drawing.Point(159, 86);
            this.AddUserNameLabel.Name = "AddUserNameLabel";
            this.AddUserNameLabel.Size = new System.Drawing.Size(55, 21);
            this.AddUserNameLabel.TabIndex = 1;
            this.AddUserNameLabel.Text = "姓名：";
            // 
            // AddUserAccountLabel
            // 
            this.AddUserAccountLabel.AutoSize = true;
            this.AddUserAccountLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUserAccountLabel.Location = new System.Drawing.Point(159, 48);
            this.AddUserAccountLabel.Name = "AddUserAccountLabel";
            this.AddUserAccountLabel.Size = new System.Drawing.Size(55, 21);
            this.AddUserAccountLabel.TabIndex = 0;
            this.AddUserAccountLabel.Text = "账号：";
            // 
            // ModifyUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 369);
            this.Controls.Add(this.AddUserPanel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.StatusDisplayLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.AccountTextBox);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "ModifyUserInfoForm";
            this.Text = "ModifyUserInfoForm";
            this.Load += new System.EventHandler(this.ModifyUserInfoForm_Load);
            this.AddUserPanel.ResumeLayout(false);
            this.AddUserPanel.PerformLayout();
            this.DeleteUserPanel.ResumeLayout(false);
            this.DeleteUserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label StatusDisplayLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Panel AddUserPanel;
        private System.Windows.Forms.RadioButton AddUserFemaleRadioButton;
        private System.Windows.Forms.RadioButton AddUserMaleRadioButton;
        private System.Windows.Forms.TextBox AddUserPhoneNumberTextBox;
        private System.Windows.Forms.TextBox AddUserPasswdTextBox;
        private System.Windows.Forms.TextBox AddUserNameLabelTextBox;
        private System.Windows.Forms.TextBox AddUserAccountTextbox;
        private System.Windows.Forms.Button AddUserSubmitButton;
        private System.Windows.Forms.Label AddUserSexLabel;
        private System.Windows.Forms.Label AddUserPasswdLabel;
        private System.Windows.Forms.Label AddUserNameLabel;
        private System.Windows.Forms.Label AddUserAccountLabel;
        private System.Windows.Forms.Label AddUserPhoneNumberLabel;
        private System.Windows.Forms.Panel DeleteUserPanel;
        private System.Windows.Forms.TextBox DeleteUserAccountTextBox;
        private System.Windows.Forms.Label DeleteUserAccountLabel;
        private System.Windows.Forms.Label DeleteUserLabel;
        private System.Windows.Forms.Button DeleteUserButton;
    }
}