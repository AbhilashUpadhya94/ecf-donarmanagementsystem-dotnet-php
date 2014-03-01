using DataAccess.Enums;
using DMSBusinessService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DMSBusinessService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IDMSService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }


        public bool Register(UserInfo userInfo)
        {
            return true;
        }


        public LoginStatus Login(String id, String pwd)
        {
            return LoginStatus.Expired;
        }

        public bool ChangePassword(string username, string oldPwd, string newPwd)
        {
            throw new NotImplementedException();
        }

        public bool CreateNewPassword(string username, string pwd)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrUpdateDonorDetails(DonarDetails donarInfo)
        {
            throw new NotImplementedException();
        }

        public DonarDetails GetDonorDetails(string username)
        {
            throw new NotImplementedException();
        }
    }
}
