using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_TinhDongGoi
{
    public class Account
    {
		private string username;
		private string password;
		public Account()
		{

		}

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        ~Account()
        {
            Console.WriteLine("Huy"+ Username);
        }

        public void inRaManHinh()
		{
			Console.WriteLine("Username: {0} password: {1}", Username, Password);
		}
	}
}
