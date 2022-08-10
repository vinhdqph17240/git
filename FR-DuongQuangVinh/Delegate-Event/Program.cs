using System;

namespace Delegate_Event
{
    class Program
    {
        public delegate void SuKienThongBao(DateTime dateTime);
        static void Main(string[] args)
        {
            Service service = new Service();
            service.NhanThongBao();
            service.DuaTre();
        }
    }
}
