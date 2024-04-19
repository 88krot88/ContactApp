using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Class containing information about the phone number.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Contains information about the phone number.
        /// </summary>
        private string _number;

        /// <summary>
        /// Returns and sets the phone number.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if ((value.Length != 11) || (value[0] != '7'))
                {
                    throw new ArgumentException(value +
                        " The number must contain exactly 11" +
                        "digits and start with 7");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Creates a phone number.
        /// </summary>
        /// <param name="number">Contact phone number.</param>
        public PhoneNumber(string number)
        {
            this.Number = number;
        }
    }
}
