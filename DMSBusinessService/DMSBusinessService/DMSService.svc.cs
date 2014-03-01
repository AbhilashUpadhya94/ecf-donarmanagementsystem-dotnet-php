using DataAccess.Enums;
using DMSBusinessService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DataAccess;

namespace DMSBusinessService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IDMSService
    {
        DMSORMDataContext context = new DMSORMDataContext();
        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public bool Register(UserInfo userInfo)
        {
            Login login = new DataAccess.Login();
            login.UserName = userInfo.UserName;
            login.Password = userInfo.Password;
            login.UserID = Guid.NewGuid().ToString();
            UserInformation uinfo = new DataAccess.UserInformation();
            context.Logins.InsertOnSubmit(login);
            uinfo.UserId = login.UserID;
            fillGender(userInfo, uinfo);
            uinfo.Address = userInfo.Address;
            uinfo.Contact = userInfo.Contact;
            uinfo.Contact1 = userInfo.Contact1;
            uinfo.Country = userInfo.Country;
            uinfo.DOB = DateTime.Parse(userInfo.Dob);
            uinfo.FirstName = userInfo.FirstName;
            uinfo.id = Guid.NewGuid().ToString();
            uinfo.Initials = userInfo.Intials;
            uinfo.LastName = userInfo.LastName;
            uinfo.MiddleName = userInfo.MiddleName;
            context.UserInformations.InsertOnSubmit(uinfo);
            try
            {
                context.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static void fillGender(UserInfo userInfo, DataAccess.UserInformation uinfo)
        {
            switch (userInfo.Gender)
            {
                case Gender.Male:
                    uinfo.Gender = 'M';
                    break;
                case Gender.Female:
                    uinfo.Gender = 'F';
                    break;
                case Gender.Transgender:
                    uinfo.Gender = 'T';
                    break;
                case Gender.None:
                    uinfo.Gender = 'N';
                    break;
            }
        }

        public LoginStatus Login(string id, string pwd)
        {
            var user = from users in context.Logins where users.UserName == id select users;
            if (user.Count() == 0)
            {
                user = from users in context.Logins where users.Email == id select users;
            }
            if (user.Count() == 0)
            {
                return LoginStatus.Error;
            }
            else
            {
                var valid = (user.ToList()[0] as Login).IsValidUser(pwd);
                if (valid)
                {
                    return LoginStatus.LoggedIn;
                }
            }
            return LoginStatus.Error;
        }

        public ChangePasswordStatus ChangePassword(string username, string oldPwd, string newPwd)
        {
            try
            {
                var users = from user in context.Logins where user.UserName == username select user;
                if (users.Count() == 1)
                {
                    var login = users.ToList()[0] as Login;
                    if (oldPwd == login.Password)
                    {
                        login.Password = newPwd;
                        return ChangePasswordStatus.Success;
                    }
                    else
                    {
                        return ChangePasswordStatus.OldPwdMismatch;
                    }
                }
                return ChangePasswordStatus.Error;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateNewPassword(string username, string pwd)
        {
            try
            {
                var users = from user in context.Logins where user.UserName == username select user;
                if (users.Count() == 1)
                {
                    var login = users.ToList()[0] as Login;
                    
                        login.Password = pwd;
                        return true;
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateOrUpdateDonorDetails(DonarDetails donarInfo, string userName)
        {
            throw new NotImplementedException();
        }

        public DonarDetails GetDonorDetails(string donarId)
        {
            var donars = from donar in context.DonorDetails where donar.UserId == donarId select donar;
            if(donars.Count() == 1)
            {
                var donar = donars.ToList()[0] as DataAccess.DonorDetail;
                var users = from user in context.UserInformations where user.UserId == donar.UserId select user;
                var usr = users.ToArray()[0];
                DonarDetails dd = new DonarDetails();
                dd.Name = usr.Initials + " " + usr.FirstName + " " + usr.MiddleName + " " + usr.LastName;
                return dd;
            }
            return null;
        }

        public List<String> GetDonarSources()
        {
            throw new NotImplementedException();
        }


        public List<DonarDetails> GetAllDonars()
        {
            throw new NotImplementedException();
        }
    }
}
