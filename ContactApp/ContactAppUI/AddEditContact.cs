using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactAppUI
{
    public partial class AddEditContact : Form
    {
		public Contact Contact { set; get; } = new Contact();
		public AddEditContact()
		{
			InitializeComponent();
		}
		private void AddEditContactOKButton_Click(object sender, EventArgs e)
		{
			var phoneNumber = new PhoneNumber(AddEditContactPhoneTextBox.Text);
			Contact = new Contact(AddEditContactSurnameTextBox.Text,
						AddEditContactNameTextBox.Text, phoneNumber,
						AddEditContactBirthdayDateTimePicker.Value, AddEditContactEmailTextBox.Text,
						AddEditContactVkIDTextBox.Text);

			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void AddEditCancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void ShowNoteInformation()
		{
			if (Contact != null)
			{
				AddEditContactSurnameTextBox.Text = Contact.Surname;
				AddEditContactNameTextBox.Text = Contact.Name;
				AddEditContactBirthdayDateTimePicker.Value = Contact.DateBirth;
				AddEditContactPhoneTextBox.Text = Contact.Number.Number;
				AddEditContactEmailTextBox.Text = Contact.Email;
				AddEditContactVkIDTextBox.Text = Contact.VKID;
			}
		}

		private void DisplayIinformation(object sender, EventArgs e)
		{
			ShowNoteInformation();
		}

		private void AddEditContactSurnameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				AddEditContactOKButton.Enabled = true;
				AddEditContactNameTextBox.BackColor = Color.White;
				Contact.Surname = AddEditContactSurnameTextBox.Text;
			}
			catch
			{
				AddEditContactNameTextBox.BackColor = Color.LightSalmon;
				AddEditContactOKButton.Enabled = false;
				return;
			}
		}
		private void AddEditContactNameTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				AddEditContactOKButton.Enabled = true;
				AddEditContactNameTextBox.BackColor = Color.White;
				Contact.Name = AddEditContactNameTextBox.Text;
			}
			catch
			{
				AddEditContactNameTextBox.BackColor = Color.LightSalmon;
				AddEditContactOKButton.Enabled = false;
				return;
			}
		}
		private void AddEditContactEmailTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				AddEditContactOKButton.Enabled = true;
				AddEditContactEmailTextBox.BackColor = Color.White;
				Contact.Email = AddEditContactEmailTextBox.Text;
			}
			catch
			{
				AddEditContactEmailTextBox.BackColor = Color.LightSalmon;
				AddEditContactOKButton.Enabled = false;
				return;
			}
		}
		private void AddEditContactPhoneTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				AddEditContactOKButton.Enabled = true;
				AddEditContactPhoneTextBox.BackColor = Color.White;
				PhoneNumber number = new PhoneNumber(AddEditContactPhoneTextBox.Text);
				Contact.Number = number;
			}
			catch
			{
				AddEditContactPhoneTextBox.BackColor = Color.LightSalmon;
				AddEditContactOKButton.Enabled = false;
				return;
			}
		}
		private void AddEditContactVkIDTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				AddEditContactOKButton.Enabled = true;
				AddEditContactVkIDTextBox.BackColor = Color.White;
				Contact.VKID = AddEditContactVkIDTextBox.Text;
			}
			catch
			{
				AddEditContactVkIDTextBox.BackColor = Color.LightSalmon;
				AddEditContactOKButton.Enabled = false;
				return;
			}
		}
	}
}
