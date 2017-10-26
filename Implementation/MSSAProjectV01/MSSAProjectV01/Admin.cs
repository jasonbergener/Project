using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSAProjectV01
{
    class Admin
    {
        protected string Email;
        protected byte[] Password;
        protected string FirstName;
        protected string LastName;
        protected string Phone;

        Admin(string email, byte[] password, string firstname, string lastname, string phone)
        {
            Email = email;
            Password = password;
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
        }

        protected void CreateTeam()
        {
            //To do
        }

        protected void DeleteTeam()
        {
            //To do
        }

        protected void UpdateStats()
        {
            //To do
        }
    }
}
 
    
