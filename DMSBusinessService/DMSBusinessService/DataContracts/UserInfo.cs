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