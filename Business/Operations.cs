using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
        public class Operations
    {
        private UserManagement userManagement = new UserManagement();

        public bool RegisterEmployer(string username, string password)
        {
            userManagement.RegisterEmployer(username, password);
            return true; // İşlem başarılı olarak kabul edildiğini varsayalım.
        }

        public bool RegisterEmployee(string username, string password)
        {
            userManagement.RegisterEmployee(username, password);
            return true; // İşlem başarılı olarak kabul edildiğini varsayalım.
        }

        public bool LoginEmployer(string username, string password)
        {
            return userManagement.LoginEmployer(username, password);
        }

        public bool LoginEmployee(string username, string password)
        {
            return userManagement.LoginEmployee(username, password);
        }
        public bool RegisterUniversity(string username, string university)
        {
            return userManagement.UpdateUniversity(username, university);
        }

        public bool SaveProgrammingLanguages(string username, List<string> languages)
        {
            return userManagement.SaveProgrammingLanguages(username, languages);
        }
    }

}
