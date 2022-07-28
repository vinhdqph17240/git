using System;

namespace Class_TinhDongGoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Service _sr = new Service();
            _sr.AddCustome();
            if (_sr.LogOn())
            {
                Console.WriteLine("dang nhap thanh cong");
            }
            else
            {
                Console.WriteLine("sai tk hoac mnk");
            }
            
        }
    }
}
