﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// A class containing all information about the contact.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Contact's surname.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Contact's surname.
        /// </summary>
        private string _name;

        /// <summary>
        /// Contact's birthday.
        /// </summary>
        private DateTime _dateBirth;

        /// <summary>
        /// Contact's email.
        /// </summary>
        private string _email;

        /// <summary>
        /// Contact's ID Vkontakte.
        /// </summary>
        private string _vkID;

        /// <summary>
        /// Returns and sets the contact's surname.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length >= 50)
                {
                    throw new ArgumentException("AAA");
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Returns and sets the contact's name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
          
                if (value.Length >= 50)
                {
                    throw new ArgumentException("AAA");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Contact's number.
        /// </summary>
        public PhoneNumber Number { get; set; }

        /// <summary>
        /// Returns and sets the contact's birthday.
        /// </summary>
        /// 
        public DateTime DateBirth
        {
            get
            {
                return _dateBirth;
            }
            set
            {
                _dateBirth = value;
            }
        }

        /// <summary>
        /// Returns and sets the contact's email.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length >= 50)
                {
                    throw new ArgumentException("AAA");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Returns and sets the contact's ID Vkontakte.
        /// </summary>
        public string VKID
        {
            get
            {
                return _vkID;
            }
            set
            {
                if (value.Length >= 50)
                {
                    throw new ArgumentException("AAA");
                }
                _vkID = value;

            }
        }

        /// <summary>
        /// Creates a contact.
        /// </summary>
        /// <param name="surname">Contact's surname.</param>
        /// <param name="name">Contact's name..</param>
        /// <param name="number">Contact's number.</param>
        /// <param name="dateBirth">Contact's birthday.</param>
        /// <param name="email">Contact's email.</param>
        /// <param name="vkID">A double precision number.</param>

        public Contact(string surname, string name, PhoneNumber number,
                       DateTime dateBirth, string email, string vkID)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            this.DateBirth = dateBirth;
            this.Email = email;
            this.VKID = vkID;
        }

		public Contact()
		{
		}

		/// <summary>
		/// Makes a copy of the object <see cref="Contact"/>
		/// </summary>
		public object Clone()
        {
            return new Contact(Surname = this.Surname, Name = this.Name,
                Number = this.Number, DateBirth = this.DateBirth,
                Email = this.Email, VKID = this.VKID);
        }
    }
}
