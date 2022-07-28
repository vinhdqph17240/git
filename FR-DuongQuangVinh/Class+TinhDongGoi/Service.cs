using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_TinhDongGoi
{
    class Service
    {
		private int _input;
		private Account _account;
		private List<Account> _lstAccount = new List<Account>();
		private string _userName;
		private string _passWord;
		private bool a;
		public void AddCustome()
		{
			Console.WriteLine("Mời bạn nhập số lượng muốn tạo account: ");
			_input = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < _input; i++)
			{
				_account = new Account();
				Console.WriteLine("Mời bạn nhập username: ");
				_account.Username = Console.ReadLine();
				Console.WriteLine("Mời bạn nhập password: ");
				_account.Password = Console.ReadLine();
				_lstAccount.Add(_account);
			}
			
		}
		public void GetDetails()
        {
            foreach (var x in _lstAccount)
            {
				x.inRaManHinh();
            }
        }
		public bool LogOn()
        {
			Console.WriteLine("Mời bạn nhập username để đăng nhập: ");
			_userName = Console.ReadLine();
			Console.WriteLine("Mời bạn nhập password để đăng nhập: ");
			_passWord = Console.ReadLine();
            if (_lstAccount.Any(c=>c.Username == _userName && c.Password == _passWord))
            {
				a = true;
            }
            else
            {
				a = false;
            }
			return a;
		}

	}
}
