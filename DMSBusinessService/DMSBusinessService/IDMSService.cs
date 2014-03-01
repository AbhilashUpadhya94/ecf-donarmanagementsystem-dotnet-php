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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode=SessionMode.Allowed)]
    public interface IDMSService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Boolean Register(UserInfo userInfo, String userName);

        [OperationContract]
        LoginStatus Login(String id, String pwd);

        [OperationContract]
        Boolean ChangePassword(String username, String oldPwd, String newPwd);

        [OperationContract]
        Boolean CreateNewPassword(String username, String pwd);

        [OperationContract]
        Boolean UpdateOrUpdateDonorDetails(DonarDetails donarInfo, String userName);

        [OperationContract]
        DonarDetails GetDonorDetails(String username);

        [OperationContract]
        List<String> GetDonarSources();


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
