using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Service
    {
        int _N;
        int[] _arrayN;


        public void NhapMang()
        {
            Console.WriteLine("mời nhập số lượng muốn có trong mảng");
            _N = Convert.ToInt32(Console.ReadLine());
            _arrayN = new int[_N];
            for (int i = 0; i < _N; i++)
            {
                Console.Write("Phan tu {0} là: ", i + 1);
                _arrayN[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void XuatMang()
        {
            for (int i = 0; i < _N; i++)
            {
                Console.Write(_arrayN[i]);

            }
        }
        public void TangDan()
        {
            for (int i = 0; i < _N; i++)
            {
                for (int j = i + 1; j < _N; j++)
                {
                    if (_arrayN[i] > _arrayN[j])
                    {
                        int temp = _arrayN[i];
                        _arrayN[i] = _arrayN[j];
                        _arrayN[j] = temp;
                    }
                }
            }
            XuatMang();
        }
        public void GiamDan()
        {
            for (int i = 0; i < _N; i++)
            {
                for (int j = i + 1; j < _N; j++)
                {
                    if (_arrayN[i] < _arrayN[j])
                    {
                        int temp = _arrayN[i];
                        _arrayN[i] = _arrayN[j];
                        _arrayN[j] = temp;
                    }
                }
            }
            XuatMang();
        }
        public void Xoa()
        {

            XuatMang();
            Console.WriteLine("Chọn vị trí muốn xóa");
            int slot = Convert.ToInt32(Console.ReadLine());
            int i = slot - 1;
            while (i < _N - 1)
            {
                _arrayN[i] = _arrayN[i + 1];
                i++;
            }
            _N--;
            Console.WriteLine("Sau khi xóa");
            XuatMang();

        }
        public void SoSanh()
        {
            Console.WriteLine("mời nhập số lượng muốn có trong 2 mảng ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool x = true;
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu mảng 1 - {0} là: ", i + 1);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }           
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu mảng 2 - {0} là: ", i + 1);
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] == array2[i])
                {
                    x = true;
                }
                else
                {
                    x = false;
                }
            }
            if (x)
            {
                Console.WriteLine("hai mảng bằng nhau");
            }
            else
            {
                Console.WriteLine("hai mảng không bằng nhau");
            }

        }
    }
}
