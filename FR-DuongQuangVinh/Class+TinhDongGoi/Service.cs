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
		public void Add()
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
			foreach (var x in _lstAccount)
			{
				x.inRaManHinh();
			}
		}
	}
}
