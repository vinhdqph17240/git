using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class PhanSo
    {
        private float tu;
        private float mau;
        public PhanSo()
        {

        }

        public PhanSo(float tu, float mau)
        {
            this.Tu = tu;
            this.Mau = mau;
        }

        public float Tu { get => tu; set => tu = value; }
        public float Mau { get => mau; set => mau = value; }
        public void inRaManHinh()
        {
            Console.WriteLine("Tử số: {0}, Mấu số: {1}",tu,mau);
        }
    }
}
