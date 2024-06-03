namespace ContactAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			addContactToolStripMenuItem = new ToolStripMenuItem();
			editContactToolStripMenuItem = new ToolStripMenuItem();
			deToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			SurnameTextBox = new TextBox();
			NameTextBox = new TextBox();
			PhoneTextBox = new TextBox();
			EmailTextBox = new TextBox();
			VkIDTextBox = new TextBox();
			SurnameLabel = new Label();
			NameLabel = new Label();
			EmailLabel = new Label();
			BirthdayLabel = new Label();
			PhoneLabel = new Label();
			VkIDLabel = new Label();
			BirthdayDateTimePicker = new DateTimePicker();
			tableLayoutPanel1 = new TableLayoutPanel();
			Findlabel = new Label();
			FindTextBox = new TextBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			splitContainer1 = new SplitContainer();
			tableLayoutPanel3 = new TableLayoutPanel();
			AllContactsListBox = new ListBox();
			RemoveTableLayoutPanel = new TableLayoutPanel();
			RemoveButton = new Button();
			EditTableLayoutPanel = new TableLayoutPanel();
			EditButton = new Button();
			AddTableLayoutPanel = new TableLayoutPanel();
			AddButton = new Button();
			splitContainer2 = new SplitContainer();
			pictureBox1 = new PictureBox();
			NamesBirthdayPeopleLabel = new Label();
			BirtdayLabel = new Label();
			menuStrip1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			RemoveTableLayoutPanel.SuspendLayout();
			EditTableLayoutPanel.SuspendLayout();
			AddTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(8, 3, 0, 3);
			menuStrip1.Size = new Size(1072, 30);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "FileEditHelp";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			fileToolStripMenuItem.Click += FileToolStripMenuItem_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addContactToolStripMenuItem, editContactToolStripMenuItem, deToolStripMenuItem });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(49, 24);
			editToolStripMenuItem.Text = "Edit";
			// 
			// addContactToolStripMenuItem
			// 
			addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
			addContactToolStripMenuItem.Size = new Size(201, 26);
			addContactToolStripMenuItem.Text = "Add Contact";
			addContactToolStripMenuItem.Click += AddContactToolStripMenuItem_Click;
			// 
			// editContactToolStripMenuItem
			// 
			editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
			editContactToolStripMenuItem.Size = new Size(201, 26);
			editContactToolStripMenuItem.Text = "Edit Contact";
			editContactToolStripMenuItem.Click += EditContactToolStripMenuItem_Click;
			// 
			// deToolStripMenuItem
			// 
			deToolStripMenuItem.Name = "deToolStripMenuItem";
			deToolStripMenuItem.Size = new Size(201, 26);
			deToolStripMenuItem.Text = "Remove Contact";
			deToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(55, 24);
			helpToolStripMenuItem.Text = "Help";
			helpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;
			// 
			// SurnameTextBox
			// 
			SurnameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			SurnameTextBox.Location = new Point(103, 10);
			SurnameTextBox.Margin = new Padding(4, 5, 4, 5);
			SurnameTextBox.Name = "SurnameTextBox";
			SurnameTextBox.ReadOnly = true;
			SurnameTextBox.Size = new Size(543, 27);
			SurnameTextBox.TabIndex = 1;
			// 
			// NameTextBox
			// 
			NameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			NameTextBox.Location = new Point(103, 57);
			NameTextBox.Margin = new Padding(4, 5, 4, 5);
			NameTextBox.Name = "NameTextBox";
			NameTextBox.ReadOnly = true;
			NameTextBox.Size = new Size(543, 27);
			NameTextBox.TabIndex = 2;
			// 
			// PhoneTextBox
			// 
			PhoneTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			PhoneTextBox.Location = new Point(103, 151);
			PhoneTextBox.Margin = new Padding(4, 5, 4, 5);
			PhoneTextBox.Name = "PhoneTextBox";
			PhoneTextBox.ReadOnly = true;
			PhoneTextBox.Size = new Size(543, 27);
			PhoneTextBox.TabIndex = 3;
			// 
			// EmailTextBox
			// 
			EmailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			EmailTextBox.Location = new Point(103, 198);
			EmailTextBox.Margin = new Padding(4, 5, 4, 5);
			EmailTextBox.Name = "EmailTextBox";
			EmailTextBox.ReadOnly = true;
			EmailTextBox.Size = new Size(543, 27);
			EmailTextBox.TabIndex = 5;
			// 
			// VkIDTextBox
			// 
			VkIDTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			VkIDTextBox.Location = new Point(103, 246);
			VkIDTextBox.Margin = new Padding(4, 5, 4, 5);
			VkIDTextBox.Name = "VkIDTextBox";
			VkIDTextBox.ReadOnly = true;
			VkIDTextBox.Size = new Size(543, 27);
			VkIDTextBox.TabIndex = 6;
			// 
			// SurnameLabel
			// 
			SurnameLabel.Anchor = AnchorStyles.Right;
			SurnameLabel.AutoSize = true;
			SurnameLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
			SurnameLabel.Location = new Point(26, 15);
			SurnameLabel.Margin = new Padding(4, 0, 4, 0);
			SurnameLabel.Name = "SurnameLabel";
			SurnameLabel.Size = new Size(69, 17);
			SurnameLabel.TabIndex = 7;
			SurnameLabel.Text = "Surname:";
			// 
			// NameLabel
			// 
			NameLabel.Anchor = AnchorStyles.Right;
			NameLabel.AutoSize = true;
			NameLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
			NameLabel.Location = new Point(46, 62);
			NameLabel.Margin = new Padding(4, 0, 4, 0);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(49, 17);
			NameLabel.TabIndex = 8;
			NameLabel.Text = "Name:";
			// 
			// EmailLabel
			// 
			EmailLabel.Anchor = AnchorStyles.Right;
			EmailLabel.AutoSize = true;
			EmailLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
			EmailLabel.Location = new Point(45, 203);
			EmailLabel.Margin = new Padding(4, 0, 4, 0);
			EmailLabel.Name = "EmailLabel";
			EmailLabel.Size = new Size(50, 17);
			EmailLabel.TabIndex = 9;
			EmailLabel.Text = "e-mail:";
			// 
			// BirthdayLabel
			// 
			BirthdayLabel.Anchor = AnchorStyles.Right;
			BirthdayLabel.AutoSize = true;
			BirthdayLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
			BirthdayLabel.Location = new Point(31, 109);
			BirthdayLabel.Margin = new Padding(4, 0, 4, 0);
			BirthdayLabel.Name = "BirthdayLabel";
			BirthdayLabel.Size = new Size(64, 17);
			BirthdayLabel.TabIndex = 10;
			BirthdayLabel.Text = "Birthday:";
			// 
			// PhoneLabel
			// 
			PhoneLabel.Anchor = AnchorStyles.Right;
			PhoneLabel.AutoSize = true;
			PhoneLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
			PhoneLabel.Location = new Point(42, 156);
			PhoneLabel.Margin = new Padding(4, 0, 4, 0);
			PhoneLabel.Name = "PhoneLabel";
			PhoneLabel.Size = new Size(53, 17);
			PhoneLabel.TabIndex = 11;
			PhoneLabel.Text = "Phone:";
			// 
			// VkIDLabel
			// 
			VkIDLabel.Anchor = AnchorStyles.Right;
			VkIDLabel.AutoSize = true;
			VkIDLabel.Font = new Font("Microsoft Sans Serif", 8.25F);
			VkIDLabel.Location = new Point(39, 251);
			VkIDLabel.Margin = new Padding(4, 0, 4, 0);
			VkIDLabel.Name = "VkIDLabel";
			VkIDLabel.Size = new Size(56, 17);
			VkIDLabel.TabIndex = 12;
			VkIDLabel.Text = "vk.com:";
			// 
			// BirthdayDateTimePicker
			// 
			BirthdayDateTimePicker.Anchor = AnchorStyles.Left;
			BirthdayDateTimePicker.Location = new Point(103, 104);
			BirthdayDateTimePicker.Margin = new Padding(4, 5, 4, 5);
			BirthdayDateTimePicker.MaxDate = new DateTime(2021, 12, 22, 0, 0, 0, 0);
			BirthdayDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
			BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
			BirthdayDateTimePicker.Size = new Size(195, 27);
			BirthdayDateTimePicker.TabIndex = 15;
			BirthdayDateTimePicker.Value = new DateTime(2020, 7, 6, 0, 0, 0, 0);
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.38461F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.61539F));
			tableLayoutPanel1.Controls.Add(NameLabel, 0, 1);
			tableLayoutPanel1.Controls.Add(NameTextBox, 1, 1);
			tableLayoutPanel1.Controls.Add(BirthdayLabel, 0, 2);
			tableLayoutPanel1.Controls.Add(BirthdayDateTimePicker, 1, 2);
			tableLayoutPanel1.Controls.Add(PhoneLabel, 0, 3);
			tableLayoutPanel1.Controls.Add(PhoneTextBox, 1, 3);
			tableLayoutPanel1.Controls.Add(VkIDTextBox, 1, 5);
			tableLayoutPanel1.Controls.Add(VkIDLabel, 0, 5);
			tableLayoutPanel1.Controls.Add(EmailTextBox, 1, 4);
			tableLayoutPanel1.Controls.Add(SurnameTextBox, 1, 0);
			tableLayoutPanel1.Controls.Add(EmailLabel, 0, 4);
			tableLayoutPanel1.Controls.Add(SurnameLabel, 0, 0);
			tableLayoutPanel1.Location = new Point(4, 5);
			tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
			tableLayoutPanel1.Size = new Size(650, 285);
			tableLayoutPanel1.TabIndex = 21;
			// 
			// Findlabel
			// 
			Findlabel.Anchor = AnchorStyles.Left;
			Findlabel.AutoSize = true;
			Findlabel.Font = new Font("Microsoft Sans Serif", 8.25F);
			Findlabel.Location = new Point(4, 14);
			Findlabel.Margin = new Padding(4, 0, 4, 0);
			Findlabel.Name = "Findlabel";
			Findlabel.Size = new Size(39, 17);
			Findlabel.TabIndex = 16;
			Findlabel.Text = "Find:";
			// 
			// FindTextBox
			// 
			FindTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			FindTextBox.Location = new Point(53, 9);
			FindTextBox.Margin = new Padding(4, 5, 4, 5);
			FindTextBox.Name = "FindTextBox";
			FindTextBox.Size = new Size(313, 27);
			FindTextBox.TabIndex = 13;
			FindTextBox.TextChanged += FindTextBox_TextChanged;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.30935F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.69065F));
			tableLayoutPanel2.Controls.Add(Findlabel, 0, 0);
			tableLayoutPanel2.Controls.Add(FindTextBox, 1, 0);
			tableLayoutPanel2.Location = new Point(4, 5);
			tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(370, 45);
			tableLayoutPanel2.TabIndex = 22;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 30);
			splitContainer1.Margin = new Padding(4, 5, 4, 5);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(tableLayoutPanel3);
			splitContainer1.Panel1.Controls.Add(RemoveTableLayoutPanel);
			splitContainer1.Panel1.Controls.Add(EditTableLayoutPanel);
			splitContainer1.Panel1.Controls.Add(AddTableLayoutPanel);
			splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
			splitContainer1.Size = new Size(1072, 644);
			splitContainer1.SplitterDistance = 378;
			splitContainer1.SplitterWidth = 5;
			splitContainer1.TabIndex = 25;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(AllContactsListBox, 0, 0);
			tableLayoutPanel3.Location = new Point(4, 51);
			tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(370, 527);
			tableLayoutPanel3.TabIndex = 25;
			// 
			// AllContactsListBox
			// 
			AllContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			AllContactsListBox.FormattingEnabled = true;
			AllContactsListBox.Location = new Point(4, 5);
			AllContactsListBox.Margin = new Padding(4, 5, 4, 5);
			AllContactsListBox.Name = "AllContactsListBox";
			AllContactsListBox.ScrollAlwaysVisible = true;
			AllContactsListBox.Size = new Size(362, 504);
			AllContactsListBox.TabIndex = 17;
			AllContactsListBox.SelectedIndexChanged += AllContactsListBox_SelectedIndexChanged;
			// 
			// RemoveTableLayoutPanel
			// 
			RemoveTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			RemoveTableLayoutPanel.ColumnCount = 1;
			RemoveTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			RemoveTableLayoutPanel.Controls.Add(RemoveButton, 0, 0);
			RemoveTableLayoutPanel.Location = new Point(92, 587);
			RemoveTableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
			RemoveTableLayoutPanel.Name = "RemoveTableLayoutPanel";
			RemoveTableLayoutPanel.RowCount = 1;
			RemoveTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			RemoveTableLayoutPanel.Size = new Size(40, 46);
			RemoveTableLayoutPanel.TabIndex = 26;
			// 
			// RemoveButton
			// 
			RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			RemoveButton.BackgroundImage = (Image)resources.GetObject("RemoveButton.BackgroundImage");
			RemoveButton.BackgroundImageLayout = ImageLayout.Stretch;
			RemoveButton.FlatAppearance.BorderColor = SystemColors.Control;
			RemoveButton.FlatStyle = FlatStyle.Flat;
			RemoveButton.ForeColor = SystemColors.Control;
			RemoveButton.Location = new Point(4, 5);
			RemoveButton.Margin = new Padding(4, 5, 4, 5);
			RemoveButton.Name = "RemoveButton";
			RemoveButton.Size = new Size(32, 36);
			RemoveButton.TabIndex = 20;
			RemoveButton.UseVisualStyleBackColor = true;
			RemoveButton.Click += RemoveButton_Click;
			// 
			// EditTableLayoutPanel
			// 
			EditTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			EditTableLayoutPanel.ColumnCount = 1;
			EditTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			EditTableLayoutPanel.Controls.Add(EditButton, 0, 0);
			EditTableLayoutPanel.Location = new Point(48, 587);
			EditTableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
			EditTableLayoutPanel.Name = "EditTableLayoutPanel";
			EditTableLayoutPanel.RowCount = 1;
			EditTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			EditTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
			EditTableLayoutPanel.Size = new Size(40, 46);
			EditTableLayoutPanel.TabIndex = 26;
			// 
			// EditButton
			// 
			EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			EditButton.BackColor = SystemColors.Control;
			EditButton.BackgroundImage = (Image)resources.GetObject("EditButton.BackgroundImage");
			EditButton.BackgroundImageLayout = ImageLayout.Center;
			EditButton.FlatAppearance.BorderColor = SystemColors.Control;
			EditButton.FlatStyle = FlatStyle.Flat;
			EditButton.Location = new Point(4, 5);
			EditButton.Margin = new Padding(4, 5, 4, 5);
			EditButton.Name = "EditButton";
			EditButton.Size = new Size(32, 36);
			EditButton.TabIndex = 19;
			EditButton.UseVisualStyleBackColor = false;
			EditButton.Click += EditButton_Click;
			// 
			// AddTableLayoutPanel
			// 
			AddTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			AddTableLayoutPanel.ColumnCount = 1;
			AddTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			AddTableLayoutPanel.Controls.Add(AddButton, 0, 0);
			AddTableLayoutPanel.Location = new Point(4, 587);
			AddTableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
			AddTableLayoutPanel.Name = "AddTableLayoutPanel";
			AddTableLayoutPanel.RowCount = 1;
			AddTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			AddTableLayoutPanel.Size = new Size(40, 46);
			AddTableLayoutPanel.TabIndex = 25;
			// 
			// AddButton
			// 
			AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			AddButton.BackgroundImage = (Image)resources.GetObject("AddButton.BackgroundImage");
			AddButton.BackgroundImageLayout = ImageLayout.Center;
			AddButton.FlatAppearance.BorderColor = SystemColors.Control;
			AddButton.FlatStyle = FlatStyle.Flat;
			AddButton.Location = new Point(4, 5);
			AddButton.Margin = new Padding(4, 5, 4, 5);
			AddButton.Name = "AddButton";
			AddButton.Size = new Size(32, 36);
			AddButton.TabIndex = 18;
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += AddButton_Click;
			// 
			// splitContainer2
			// 
			splitContainer2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			splitContainer2.BackColor = SystemColors.ActiveCaption;
			splitContainer2.Location = new Point(4, 501);
			splitContainer2.Margin = new Padding(4, 5, 4, 5);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(pictureBox1);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(NamesBirthdayPeopleLabel);
			splitContainer2.Panel2.Controls.Add(BirtdayLabel);
			splitContainer2.Size = new Size(650, 138);
			splitContainer2.SplitterDistance = 89;
			splitContainer2.SplitterWidth = 5;
			splitContainer2.TabIndex = 23;
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(4, 5);
			pictureBox1.Margin = new Padding(4, 5, 4, 5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(112, 129);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// NamesBirthdayPeopleLabel
			// 
			NamesBirthdayPeopleLabel.AutoSize = true;
			NamesBirthdayPeopleLabel.Location = new Point(19, 86);
			NamesBirthdayPeopleLabel.Margin = new Padding(4, 0, 4, 0);
			NamesBirthdayPeopleLabel.Name = "NamesBirthdayPeopleLabel";
			NamesBirthdayPeopleLabel.Size = new Size(0, 20);
			NamesBirthdayPeopleLabel.TabIndex = 23;
			// 
			// BirtdayLabel
			// 
			BirtdayLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			BirtdayLabel.AutoSize = true;
			BirtdayLabel.Location = new Point(19, 48);
			BirtdayLabel.Margin = new Padding(4, 0, 4, 0);
			BirtdayLabel.Name = "BirtdayLabel";
			BirtdayLabel.Size = new Size(169, 20);
			BirtdayLabel.TabIndex = 22;
			BirtdayLabel.Text = "Today is the birthday of ";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1072, 674);
			Controls.Add(splitContainer1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(4, 5, 4, 5);
			MinimumSize = new Size(1087, 707);
			Name = "MainForm";
			Text = "ContactsApp";
			FormClosing += MainForm_FormClosing;
			Load += MainForm_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			RemoveTableLayoutPanel.ResumeLayout(false);
			EditTableLayoutPanel.ResumeLayout(false);
			AddTableLayoutPanel.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VkIDTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label VkIDLabel;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Findlabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox AllContactsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel EditTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel AddTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel RemoveTableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BirtdayLabel;
        private System.Windows.Forms.Label NamesBirthdayPeopleLabel;
    }
}

