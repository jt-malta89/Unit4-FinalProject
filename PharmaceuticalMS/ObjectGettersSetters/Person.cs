using System;

namespace ObjectGettersSetters
{
    [Serializable]
    public class Person
    {
        private string p_Name, p_Surname, p_IdCard, p_Address, p_Email, p_NoBuildingName;
        private DateTime p_DateofBirth;
        private int p_ContactNo;

        public Person() { }

        public Person(string Name, string Surname, string IdCard, string Address, DateTime DOB, int ContactNo, string Email, string NoBuildingName)
        {
            this.p_Name = Name;
            this.p_Surname = Surname;
            this.p_IdCard = IdCard;
            this.p_Address = Address;
            this.p_DateofBirth = DOB;
            this.p_ContactNo = ContactNo;
            this.p_Email = Email;
            this.p_NoBuildingName = NoBuildingName;
        }

        public string Name
        {
            get
            {
                return this.p_Name;
            }
            set
            {
                this.p_Name = value;
            }
        }

        public string Surname
        {
            get
            {
                return this.p_Surname;
            }
            set
            {
                this.p_Surname = value;
            }
        }

        public string IdCard
        {
            get
            {
                return this.p_IdCard;
            }
            set
            {
                this.p_IdCard = value;
            }
        }

        public string Address
        {
            get
            {
                return this.p_Address;
            }
            set
            {
                this.p_Address = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.p_DateofBirth;
            }
            set
            {
                this.p_DateofBirth = value;
            }
        }

        public int ContactNo
        {
            get
            {
                return this.p_ContactNo;
            }
            set
            {
                this.p_ContactNo = value;
            }
        }

        public string Email
        {
            get
            {
                return this.p_Email;
            }
            set
            {
                this.p_Email = value;
            }
        }

        public string NoBuildingName
        {
            get
            {
                return this.p_NoBuildingName;
            }
            set
            {
                this.p_NoBuildingName = value;
            }
        }
    }
}