using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniPhoneBook.Models
{
    public class CONTACT
    {
        private int contactId;
        private string contactName;
        private string type;
        private int personId;

        public int ContactId
        {
            get
            {
                return contactId;
            }

            set
            {
                contactId = value;
            }
        }

        public string ContactName
        {
            get
            {
                return contactName;
            }

            set
            {
                contactName = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int PersonId
        {
            get
            {
                return personId;
            }

            set
            {
                personId = value;
            }
        }
    }
}