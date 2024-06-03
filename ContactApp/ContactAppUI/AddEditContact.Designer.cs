namespace ContactAppUI
{
    partial class AddEditContact
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
			AddEditContactSurnameTextBox = new TextBox();
			AddEditContactNameTextBox = new TextBox();
			AddEditContactBirthdayDateTimePicker = new DateTimePicker();
			AddEditContactPhoneTextBox = new TextBox();
			AddEditContactEmailTextBox = new TextBox();
			AddEditContactVkIDTextBox = new TextBox();
			AddEditContactSurnameLabel = new Label();
			AddEditContactNameLabel = new Label();
			AddEditContactBirthdayLabel = new Label();
			AddEditContactPhoneLabel = new Label();
			AddEditContactEmailLabel = new Label();
			AddEditContactVkIDLabel = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			AddEditCancelButton = new Button();
			AddEditContactOKButton = new Button();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// AddEditContactSurnameTextBox
			// 
			AddEditContactSurnameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddEditContactSurnameTextBox.Location = new Point(121, 6);
			AddEditContactSurnameTextBox.Margin = new Padding(4);
			AddEditContactSurnameTextBox.Name = "AddEditContactSurnameTextBox";
			AddEditContactSurnameTextBox.Size = new Size(399, 27);
			AddEditContactSurnameTextBox.TabIndex = 0;
			AddEditContactSurnameTextBox.TextChanged += AddEditContactSurnameTextBox_TextChanged;
			// 
			// AddEditContactNameTextBox
			// 
			AddEditContactNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddEditContactNameTextBox.Location = new Point(121, 45);
			AddEditContactNameTextBox.Margin = new Padding(4);
			AddEditContactNameTextBox.Name = "AddEditContactNameTextBox";
			AddEditContactNameTextBox.Size = new Size(399, 27);
			AddEditContactNameTextBox.TabIndex = 1;
			AddEditContactNameTextBox.TextChanged += AddEditContactNameTextBox_TextChanged;
			// 
			// AddEditContactBirthdayDateTimePicker
			// 
			AddEditContactBirthdayDateTimePicker.Anchor = AnchorStyles.Left;
			AddEditContactBirthdayDateTimePicker.Location = new Point(121, 84);
			AddEditContactBirthdayDateTimePicker.Margin = new Padding(4);
			AddEditContactBirthdayDateTimePicker.Name = "AddEditContactBirthdayDateTimePicker";
			AddEditContactBirthdayDateTimePicker.Size = new Size(176, 27);
			AddEditContactBirthdayDateTimePicker.TabIndex = 2;
			// 
			// AddEditContactPhoneTextBox
			// 
			AddEditContactPhoneTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddEditContactPhoneTextBox.Location = new Point(121, 123);
			AddEditContactPhoneTextBox.Margin = new Padding(4);
			AddEditContactPhoneTextBox.Name = "AddEditContactPhoneTextBox";
			AddEditContactPhoneTextBox.Size = new Size(399, 27);
			AddEditContactPhoneTextBox.TabIndex = 3;
			AddEditContactPhoneTextBox.TextChanged += AddEditContactPhoneTextBox_TextChanged;
			// 
			// AddEditContactEmailTextBox
			// 
			AddEditContactEmailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddEditContactEmailTextBox.Location = new Point(121, 162);
			AddEditContactEmailTextBox.Margin = new Padding(4);
			AddEditContactEmailTextBox.Name = "AddEditContactEmailTextBox";
			AddEditContactEmailTextBox.Size = new Size(399, 27);
			AddEditContactEmailTextBox.TabIndex = 4;
			AddEditContactEmailTextBox.TextChanged += AddEditContactEmailTextBox_TextChanged;
			// 
			// AddEditContactVkIDTextBox
			// 
			AddEditContactVkIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddEditContactVkIDTextBox.Location = new Point(121, 203);
			AddEditContactVkIDTextBox.Margin = new Padding(4);
			AddEditContactVkIDTextBox.Name = "AddEditContactVkIDTextBox";
			AddEditContactVkIDTextBox.Size = new Size(399, 27);
			AddEditContactVkIDTextBox.TabIndex = 5;
			AddEditContactVkIDTextBox.TextChanged += AddEditContactVkIDTextBox_TextChanged;
			// 
			// AddEditContactSurnameLabel
			// 
			AddEditContactSurnameLabel.Anchor = AnchorStyles.Right;
			AddEditContactSurnameLabel.AutoSize = true;
			AddEditContactSurnameLabel.Font = new Font("Microsoft Sans Serif", 10F);
			AddEditContactSurnameLabel.Location = new Point(32, 9);
			AddEditContactSurnameLabel.Margin = new Padding(4, 0, 4, 0);
			AddEditContactSurnameLabel.Name = "AddEditContactSurnameLabel";
			AddEditContactSurnameLabel.Size = new Size(81, 20);
			AddEditContactSurnameLabel.TabIndex = 6;
			AddEditContactSurnameLabel.Text = "Surname:";
			// 
			// AddEditContactNameLabel
			// 
			AddEditContactNameLabel.Anchor = AnchorStyles.Right;
			AddEditContactNameLabel.AutoSize = true;
			AddEditContactNameLabel.Font = new Font("Microsoft Sans Serif", 10F);
			AddEditContactNameLabel.Location = new Point(55, 48);
			AddEditContactNameLabel.Margin = new Padding(4, 0, 4, 0);
			AddEditContactNameLabel.Name = "AddEditContactNameLabel";
			AddEditContactNameLabel.Size = new Size(58, 20);
			AddEditContactNameLabel.TabIndex = 7;
			AddEditContactNameLabel.Text = "Name:";
			// 
			// AddEditContactBirthdayLabel
			// 
			AddEditContactBirthdayLabel.Anchor = AnchorStyles.Right;
			AddEditContactBirthdayLabel.AutoSize = true;
			AddEditContactBirthdayLabel.Font = new Font("Microsoft Sans Serif", 10F);
			AddEditContactBirthdayLabel.Location = new Point(37, 87);
			AddEditContactBirthdayLabel.Margin = new Padding(4, 0, 4, 0);
			AddEditContactBirthdayLabel.Name = "AddEditContactBirthdayLabel";
			AddEditContactBirthdayLabel.Size = new Size(76, 20);
			AddEditContactBirthdayLabel.TabIndex = 8;
			AddEditContactBirthdayLabel.Text = "Birthday:";
			// 
			// AddEditContactPhoneLabel
			// 
			AddEditContactPhoneLabel.Anchor = AnchorStyles.Right;
			AddEditContactPhoneLabel.AutoSize = true;
			AddEditContactPhoneLabel.Font = new Font("Microsoft Sans Serif", 10F);
			AddEditContactPhoneLabel.Location = new Point(52, 126);
			AddEditContactPhoneLabel.Margin = new Padding(4, 0, 4, 0);
			AddEditContactPhoneLabel.Name = "AddEditContactPhoneLabel";
			AddEditContactPhoneLabel.Size = new Size(61, 20);
			AddEditContactPhoneLabel.TabIndex = 9;
			AddEditContactPhoneLabel.Text = "Phone:";
			// 
			// AddEditContactEmailLabel
			// 
			AddEditContactEmailLabel.Anchor = AnchorStyles.Right;
			AddEditContactEmailLabel.AutoSize = true;
			AddEditContactEmailLabel.Font = new Font("Microsoft Sans Serif", 10F);
			AddEditContactEmailLabel.Location = new Point(53, 165);
			AddEditContactEmailLabel.Margin = new Padding(4, 0, 4, 0);
			AddEditContactEmailLabel.Name = "AddEditContactEmailLabel";
			AddEditContactEmailLabel.Size = new Size(60, 20);
			AddEditContactEmailLabel.TabIndex = 10;
			AddEditContactEmailLabel.Text = "e-mail:";
			// 
			// AddEditContactVkIDLabel
			// 
			AddEditContactVkIDLabel.Anchor = AnchorStyles.Right;
			AddEditContactVkIDLabel.AutoSize = true;
			AddEditContactVkIDLabel.Font = new Font("Microsoft Sans Serif", 10F);
			AddEditContactVkIDLabel.Location = new Point(47, 206);
			AddEditContactVkIDLabel.Margin = new Padding(4, 0, 4, 0);
			AddEditContactVkIDLabel.Name = "AddEditContactVkIDLabel";
			AddEditContactVkIDLabel.Size = new Size(66, 20);
			AddEditContactVkIDLabel.TabIndex = 11;
			AddEditContactVkIDLabel.Text = "vk.com:";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.None;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.46377F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.53623F));
			tableLayoutPanel1.Controls.Add(AddEditContactSurnameLabel, 0, 0);
			tableLayoutPanel1.Controls.Add(AddEditContactBirthdayDateTimePicker, 1, 2);
			tableLayoutPanel1.Controls.Add(AddEditContactVkIDTextBox, 1, 5);
			tableLayoutPanel1.Controls.Add(AddEditContactVkIDLabel, 0, 5);
			tableLayoutPanel1.Controls.Add(AddEditContactEmailTextBox, 1, 4);
			tableLayoutPanel1.Controls.Add(AddEditContactSurnameTextBox, 1, 0);
			tableLayoutPanel1.Controls.Add(AddEditContactPhoneTextBox, 1, 3);
			tableLayoutPanel1.Controls.Add(AddEditContactNameLabel, 0, 1);
			tableLayoutPanel1.Controls.Add(AddEditContactNameTextBox, 1, 1);
			tableLayoutPanel1.Controls.Add(AddEditContactBirthdayLabel, 0, 2);
			tableLayoutPanel1.Controls.Add(AddEditContactPhoneLabel, 0, 3);
			tableLayoutPanel1.Controls.Add(AddEditContactEmailLabel, 0, 4);
			tableLayoutPanel1.Location = new Point(11, 15);
			tableLayoutPanel1.Margin = new Padding(4);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.Size = new Size(524, 238);
			tableLayoutPanel1.TabIndex = 12;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(AddEditCancelButton, 1, 0);
			tableLayoutPanel2.Controls.Add(AddEditContactOKButton, 0, 0);
			tableLayoutPanel2.Location = new Point(315, 260);
			tableLayoutPanel2.Margin = new Padding(4);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(221, 39);
			tableLayoutPanel2.TabIndex = 13;
			// 
			// AddEditCancelButton
			// 
			AddEditCancelButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddEditCancelButton.Location = new Point(114, 4);
			AddEditCancelButton.Margin = new Padding(4);
			AddEditCancelButton.Name = "AddEditCancelButton";
			AddEditCancelButton.Size = new Size(103, 31);
			AddEditCancelButton.TabIndex = 15;
			AddEditCancelButton.Text = "Cancel";
			AddEditCancelButton.UseVisualStyleBackColor = true;
			AddEditCancelButton.Click += AddEditCancelButton_Click;
			// 
			// AddEditContactOKButton
			// 
			AddEditContactOKButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			AddEditContactOKButton.Location = new Point(4, 4);
			AddEditContactOKButton.Margin = new Padding(4);
			AddEditContactOKButton.Name = "AddEditContactOKButton";
			AddEditContactOKButton.Size = new Size(102, 31);
			AddEditContactOKButton.TabIndex = 14;
			AddEditContactOKButton.Text = "OK";
			AddEditContactOKButton.UseVisualStyleBackColor = true;
			AddEditContactOKButton.Click += AddEditContactOKButton_Click;
			// 
			// AddEditContact
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			ClientSize = new Size(548, 311);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(4);
			Name = "AddEditContact";
			Text = "Add/Edit Contact";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TextBox AddEditContactSurnameTextBox;
        private System.Windows.Forms.TextBox AddEditContactNameTextBox;
        private System.Windows.Forms.DateTimePicker AddEditContactBirthdayDateTimePicker;
        private System.Windows.Forms.TextBox AddEditContactPhoneTextBox;
        private System.Windows.Forms.TextBox AddEditContactEmailTextBox;
        private System.Windows.Forms.TextBox AddEditContactVkIDTextBox;
        private System.Windows.Forms.Label AddEditContactSurnameLabel;
        private System.Windows.Forms.Label AddEditContactNameLabel;
        private System.Windows.Forms.Label AddEditContactBirthdayLabel;
        private System.Windows.Forms.Label AddEditContactPhoneLabel;
        private System.Windows.Forms.Label AddEditContactEmailLabel;
        private System.Windows.Forms.Label AddEditContactVkIDLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AddEditCancelButton;
        private System.Windows.Forms.Button AddEditContactOKButton;
    }
}