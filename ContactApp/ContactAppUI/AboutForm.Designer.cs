namespace ContactAppUI
{
    partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			ContactsAppLabel = new Label();
			VersionLabel = new Label();
			AuthorLabel = new Label();
			About2020Label = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			tableLayoutPanel4 = new TableLayoutPanel();
			tableLayoutPanel5 = new TableLayoutPanel();
			tableLayoutPanel6 = new TableLayoutPanel();
			EmailLinkLabel = new LinkLabel();
			EmailLabel = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			GitHubLinkLabel = new LinkLabel();
			GitHubLabel = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			tableLayoutPanel6.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// ContactsAppLabel
			// 
			ContactsAppLabel.Anchor = AnchorStyles.Left;
			ContactsAppLabel.AutoSize = true;
			ContactsAppLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
			ContactsAppLabel.Location = new Point(4, 10);
			ContactsAppLabel.Margin = new Padding(4, 0, 4, 0);
			ContactsAppLabel.Name = "ContactsAppLabel";
			ContactsAppLabel.Size = new Size(182, 31);
			ContactsAppLabel.TabIndex = 0;
			ContactsAppLabel.Text = "ContactsApp";
			// 
			// VersionLabel
			// 
			VersionLabel.Anchor = AnchorStyles.Left;
			VersionLabel.AutoSize = true;
			VersionLabel.Location = new Point(4, 7);
			VersionLabel.Margin = new Padding(4, 0, 4, 0);
			VersionLabel.Name = "VersionLabel";
			VersionLabel.Size = new Size(53, 20);
			VersionLabel.TabIndex = 1;
			VersionLabel.Text = "v. 1.0.0";
			// 
			// AuthorLabel
			// 
			AuthorLabel.Anchor = AnchorStyles.Left;
			AuthorLabel.AutoSize = true;
			AuthorLabel.Font = new Font("Microsoft Sans Serif", 10F);
			AuthorLabel.Location = new Point(4, 11);
			AuthorLabel.Margin = new Padding(4, 0, 4, 0);
			AuthorLabel.Name = "AuthorLabel";
			AuthorLabel.Size = new Size(191, 20);
			AuthorLabel.TabIndex = 2;
			AuthorLabel.Text = "Author: Panisheva Daria";
			// 
			// About2020Label
			// 
			About2020Label.Anchor = AnchorStyles.Left;
			About2020Label.AutoSize = true;
			About2020Label.Font = new Font("Microsoft Sans Serif", 10F);
			About2020Label.Location = new Point(4, 14);
			About2020Label.Margin = new Padding(4, 0, 4, 0);
			About2020Label.Name = "About2020Label";
			About2020Label.Size = new Size(190, 20);
			About2020Label.TabIndex = 5;
			About2020Label.Text = "2024 Panisheva Daria ©";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(About2020Label, 0, 0);
			tableLayoutPanel1.Location = new Point(55, 368);
			tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
			tableLayoutPanel1.Size = new Size(353, 49);
			tableLayoutPanel1.TabIndex = 6;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(AuthorLabel, 0, 0);
			tableLayoutPanel3.Location = new Point(55, 155);
			tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
			tableLayoutPanel3.Size = new Size(243, 43);
			tableLayoutPanel3.TabIndex = 8;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Controls.Add(ContactsAppLabel, 0, 0);
			tableLayoutPanel4.Location = new Point(55, 45);
			tableLayoutPanel4.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 1;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Size = new Size(227, 52);
			tableLayoutPanel4.TabIndex = 9;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.ColumnCount = 1;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.Controls.Add(VersionLabel, 0, 0);
			tableLayoutPanel5.Location = new Point(55, 95);
			tableLayoutPanel5.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.Size = new Size(76, 34);
			tableLayoutPanel5.TabIndex = 10;
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.ColumnCount = 2;
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.80563F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.19437F));
			tableLayoutPanel6.Controls.Add(EmailLinkLabel, 1, 0);
			tableLayoutPanel6.Controls.Add(EmailLabel, 0, 0);
			tableLayoutPanel6.Location = new Point(55, 232);
			tableLayoutPanel6.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 1;
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel6.Size = new Size(521, 46);
			tableLayoutPanel6.TabIndex = 11;
			// 
			// EmailLinkLabel
			// 
			EmailLinkLabel.Anchor = AnchorStyles.Left;
			EmailLinkLabel.AutoSize = true;
			EmailLinkLabel.Font = new Font("Microsoft Sans Serif", 10F);
			EmailLinkLabel.Location = new Point(190, 13);
			EmailLinkLabel.Margin = new Padding(4, 0, 4, 0);
			EmailLinkLabel.Name = "EmailLinkLabel";
			EmailLinkLabel.Size = new Size(163, 20);
			EmailLinkLabel.TabIndex = 13;
			EmailLinkLabel.TabStop = true;
			EmailLinkLabel.Text = "dasha.panishewa@mail.ru";
			// 
			// EmailLabel
			// 
			EmailLabel.Anchor = AnchorStyles.Left;
			EmailLabel.AutoSize = true;
			EmailLabel.Font = new Font("Microsoft Sans Serif", 10F);
			EmailLabel.Location = new Point(4, 13);
			EmailLabel.Margin = new Padding(4, 0, 4, 0);
			EmailLabel.Name = "EmailLabel";
			EmailLabel.Size = new Size(157, 20);
			EmailLabel.TabIndex = 2;
			EmailLabel.Text = "e-mail for feedback:";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.11253F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.88747F));
			tableLayoutPanel2.Controls.Add(GitHubLinkLabel, 1, 0);
			tableLayoutPanel2.Controls.Add(GitHubLabel, 0, 0);
			tableLayoutPanel2.Location = new Point(55, 288);
			tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(521, 46);
			tableLayoutPanel2.TabIndex = 12;
			// 
			// GitHubLinkLabel
			// 
			GitHubLinkLabel.Anchor = AnchorStyles.Left;
			GitHubLinkLabel.AutoSize = true;
			GitHubLinkLabel.Font = new Font("Microsoft Sans Serif", 10F);
			GitHubLinkLabel.Location = new Point(87, 13);
			GitHubLinkLabel.Margin = new Padding(4, 0, 4, 0);
			GitHubLinkLabel.Name = "GitHubLinkLabel";
			GitHubLinkLabel.Size = new Size(211, 20);
			GitHubLinkLabel.TabIndex = 14;
			GitHubLinkLabel.TabStop = true;
			GitHubLinkLabel.Text = "https://github.com/88krot88";
			// 
			// GitHubLabel
			// 
			GitHubLabel.Anchor = AnchorStyles.Left;
			GitHubLabel.AutoSize = true;
			GitHubLabel.Font = new Font("Microsoft Sans Serif", 10F);
			GitHubLabel.Location = new Point(4, 13);
			GitHubLabel.Margin = new Padding(4, 0, 4, 0);
			GitHubLabel.Name = "GitHubLabel";
			GitHubLabel.Size = new Size(67, 20);
			GitHubLabel.TabIndex = 2;
			GitHubLabel.Text = "GitHub:";
			// 
			// AboutForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(617, 418);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel6);
			Controls.Add(tableLayoutPanel5);
			Controls.Add(tableLayoutPanel4);
			Controls.Add(tableLayoutPanel3);
			Controls.Add(tableLayoutPanel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 5, 4, 5);
			MaximumSize = new Size(635, 465);
			MinimumSize = new Size(635, 465);
			Name = "AboutForm";
			Text = "About";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			tableLayoutPanel6.ResumeLayout(false);
			tableLayoutPanel6.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label About2020Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
    }
}