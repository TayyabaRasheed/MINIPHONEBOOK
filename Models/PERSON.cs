using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MiniPhoneBook.Models
{
    public class PERSON
    {
       
        private string personId;
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime dateOfBirth;
        private DateTime addedOn;
        private string addedBy;
        private string homeAddress;
        private string homeCity;
        private string faceBookAccount;
        private string linkedInId;
        private DateTime updatedOn;
        private string twitterId;
        private string emailId;

        [Required(ErrorMessage = "This Is a required field")]
        [Display(Name = "UserID")]
        public string PersonId
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
        [Required(ErrorMessage = "This Is a required field")]
        [Display(Name = "FirstName")]
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        
        [Display(Name = "MiddleName")]
        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }
        [Required(ErrorMessage = "This Is a required field")]
        [Display(Name = "LastName")]
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        [Required(ErrorMessage = "This Is a required field")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public DateTime AddedOn
        {
            get
            {
                return addedOn;
            }

            set
            {
                addedOn = value;
            }
        }
        [Required(ErrorMessage = "This Is a required field")]
        //[Display(Name = "UserID")]
        public string AddedBy
        {
            get
            {
                return addedBy;
            }

            set
            {
                addedBy = value;
            }
        }

        public string HomeAddress
        {
            get
            {
                return homeAddress;
            }

            set
            {
                homeAddress = value;
            }
        }

        public string HomeCity
        {
            get
            {
                return homeCity;
            }

            set
            {
                homeCity = value;
            }
        }

        public string FaceBookAccount
        {
            get
            {
                return faceBookAccount;
            }

            set
            {
                faceBookAccount = value;
            }
        }

        public string LinkedInId
        {
            get
            {
                return linkedInId;
            }

            set
            {
                linkedInId = value;
            }
        }

        public DateTime UpdatedOn
        {
            get
            {
                return updatedOn;
            }

            set
            {
                updatedOn = value;
            }
        }

        public string TwitterId
        {
            get
            {
                return twitterId;
            }

            set
            {
                twitterId = value;
            }
        }
        [Required(ErrorMessage = "This Is a required field")]
        //[Display(Name = "UserID")]
        public string EmailId
        {
            get
            {
                return emailId;
            }

            set
            {
                emailId = value;
            }
        }
    }
}