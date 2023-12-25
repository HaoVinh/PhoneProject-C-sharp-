using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DTO
{
    internal class accountDTO
    {
        private String accID;
        private String userName;
        private String password;
        private String empID;
        private Permission accountPermission;

        public string AccID { get => accID; set => accID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string EmpID { get => empID; set => empID = value; }
        internal Permission AccountPermission { get => accountPermission; set => accountPermission = value; }

        public accountDTO()
        {

        }

        public accountDTO(string accID, string userName, string password, string empID, Permission accountPermission)
        {
            this.accID = accID;
            this.userName = userName;
            this.password = password;
            this.empID = empID;
            this.accountPermission = accountPermission;
        }

        public enum Permission { None, Manager, Employee }
    }
}

