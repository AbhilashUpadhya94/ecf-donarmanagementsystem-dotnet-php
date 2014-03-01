using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DMSBusinessService.DataContracts
{
    [DataContract]
    public class UserInfo
    {
        private Guid userID = Guid.Empty;
        private Status status = Status.None;
        private Gender gender = Gender.None;
        private String userName = String.Empty;
        private String password = String.Empty;
        private String intials = String.Empty;
        private String firstName = String.Empty;
        private String lastName = String.Empty;
        private String dob = String.Empty;
        private String address = String.Empty;
        private String city = String.Empty;
        private String state = String.Empty;
        private String pinCode = String.Empty;
        private String country = String.Empty;
        private Int32 contact;
        private Int32 contact1;
        private String middleName = String.Empty;

        [DataMember]
        public String MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        [DataMember]
        public Int32 Contact1
        {
            get { return contact1; }
            set { contact1 = value; }
        }

        [DataMember]
        public Int32 Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        [DataMember]
        public String Country
        {
            get { return country; }
            set { country = value; }
        }

        [DataMember]
        public String PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }

        [DataMember]
        public String State
        {
            get { return state; }
            set { state = value; }
        }

        [DataMember]
        public String City
        {
            get { return city; }
            set { city = value; }
        }

        [DataMember]
        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        [DataMember]
        public String Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        [DataMember]
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [DataMember]
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [DataMember]
        public String Intials
        {
            get { return intials; }
            set { intials = value; }
        }


        [DataMember]
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        [DataMember]
        public String UserName
        {
            get
            {

                return userName;
            }
            set { userName = value; }
        }

        public Guid UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        [DataMember]
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        [DataMember]
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}