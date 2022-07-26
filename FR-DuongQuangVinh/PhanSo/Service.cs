using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    class Service
    {
        PhanSo _PhanSo = new PhanSo();
        float _UCLN;
        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhập tử:");
                _PhanSo.Tu = Convert.ToInt32(Console.ReadLine());
            } while (_PhanSo.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu:");
                _PhanSo.Mau = Convert.ToInt32(Console.ReadLine());
            } while (_PhanSo.Mau <= 0);

        }
        public void Xuat()
        {
            _PhanSo.inRaManHinh();
        }
        public int UCLN(int tu, int mau)
        {
            int UCLN = 0;
            while (tu != mau)
            {
                if (tu > mau)
                {
                    tu = tu - mau;
                }
                else
                {
                    mau = mau - tu;
                }
            }
            return UCLN;
        }
        public void RutGon()
        {
            if (_PhanSo.Tu == null)
            {
                Console.WriteLine("không có phân số để rút gọn vui lòng nhập phân số");
            }
            else
            {


                float tu = _PhanSo.Tu;
                float mau = _PhanSo.Mau;
                while (tu != mau)
                {
                    if (tu > mau)
                    {
                        tu = tu - mau;
                    }
                    else
                    {
                        mau = mau - tu;
                    }
                }
                _UCLN = tu;
                _PhanSo.Tu = _PhanSo.Tu / _UCLN;
                _PhanSo.Mau = _PhanSo.Mau / _UCLN;
                Console.WriteLine("phân số sau khi rút gọn");
                _PhanSo.inRaManHinh();
            }
        }
        public void CongHaiPhanSo()
        {
            PhanSo sumPhanSo = new PhanSo();

            PhanSo PhanSo1 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 1:");
                PhanSo1.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 1:");
                PhanSo1.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Mau <= 0);

            PhanSo PhanSo2 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 2:");
                PhanSo2.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 2:");
                PhanSo2.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Mau <= 0);
            if (PhanSo2.Mau == PhanSo1.Mau)
            {
                sumPhanSo.Tu = PhanSo1.Tu + PhanSo2.Tu;
                sumPhanSo.Mau = PhanSo1.Mau;
                sumPhanSo.inRaManHinh();
            }
            else
            {
                if (PhanSo1.Mau % PhanSo2.Mau == 0)
                {
                    PhanSo2.Tu = (PhanSo1.Mau / PhanSo2.Mau) * PhanSo2.Tu;
                    PhanSo2.Mau = PhanSo1.Mau;
                    sumPhanSo.Mau = PhanSo1.Mau;
                    sumPhanSo.Tu = PhanSo1.Tu + PhanSo2.Tu;
                    sumPhanSo.inRaManHinh();

                }
                else if (PhanSo2.Mau % PhanSo1.Mau == 0)
                {
                    PhanSo1.Tu = (PhanSo2.Mau / PhanSo1.Mau) * PhanSo1.Tu;
                    PhanSo1.Mau = PhanSo2.Mau;
                    sumPhanSo.Mau = PhanSo2.Mau;
                    sumPhanSo.Tu = PhanSo1.Tu + PhanSo2.Tu;
                    sumPhanSo.inRaManHinh();
                }
                else
                {
                    PhanSo1.Tu = PhanSo1.Tu * PhanSo2.Mau;
                    PhanSo1.Mau = PhanSo1.Mau * PhanSo2.Mau;
                    PhanSo2.Tu = PhanSo2.Tu * PhanSo1.Mau;
                    PhanSo2.Mau = PhanSo2.Mau * PhanSo1.Mau;
                    sumPhanSo.Tu = PhanSo1.Tu + PhanSo2.Tu;
                    sumPhanSo.Mau = PhanSo1.Mau + PhanSo2.Mau;
                    sumPhanSo.inRaManHinh();
                }
            }
        }
        public void truHaiPhanSo()
        {
            PhanSo HieuPhanSo = new PhanSo();

            PhanSo PhanSo1 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 1:");
                PhanSo1.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 1:");
                PhanSo1.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Mau <= 0);

            PhanSo PhanSo2 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 2:");
                PhanSo2.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 2:");
                PhanSo2.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Mau <= 0);

            if (PhanSo2.Mau == PhanSo1.Mau)
            {
                HieuPhanSo.Tu = PhanSo1.Tu - PhanSo2.Tu;
                HieuPhanSo.Mau = PhanSo1.Mau;
                HieuPhanSo.inRaManHinh();
            }
            else
            {
                if (PhanSo1.Mau % PhanSo2.Mau == 0)
                {
                    PhanSo2.Tu = (PhanSo1.Mau / PhanSo2.Mau) * PhanSo2.Tu;
                    PhanSo2.Mau = PhanSo1.Mau;
                    HieuPhanSo.Mau = PhanSo1.Mau;
                    HieuPhanSo.Tu = PhanSo1.Tu - PhanSo2.Tu;
                    HieuPhanSo.inRaManHinh();

                }
                else if (PhanSo2.Mau % PhanSo1.Mau == 0)
                {
                    PhanSo1.Tu = (PhanSo2.Mau / PhanSo1.Mau) * PhanSo1.Tu;
                    PhanSo1.Mau = PhanSo2.Mau;
                    HieuPhanSo.Mau = PhanSo2.Mau;
                    HieuPhanSo.Tu = PhanSo1.Tu - PhanSo2.Tu;
                    HieuPhanSo.inRaManHinh();
                }
                else
                {
                    PhanSo1.Tu = PhanSo1.Tu * PhanSo2.Mau;
                    PhanSo1.Mau = PhanSo1.Mau * PhanSo2.Mau;
                    PhanSo2.Tu = PhanSo2.Tu * PhanSo1.Mau;
                    PhanSo2.Mau = PhanSo2.Mau * PhanSo1.Mau;
                    HieuPhanSo.Tu = PhanSo1.Tu - PhanSo2.Tu;
                    HieuPhanSo.Mau = PhanSo1.Mau - PhanSo2.Mau;
                    HieuPhanSo.inRaManHinh();
                }
            }
        }
        public void nhanHaiPhanSo()
        {
            PhanSo tichPhanSo = new PhanSo();

            PhanSo PhanSo1 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 1:");
                PhanSo1.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 1:");
                PhanSo1.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Mau <= 0);

            PhanSo PhanSo2 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 2:");
                PhanSo2.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 2:");
                PhanSo2.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Mau <= 0);
            tichPhanSo.Tu = PhanSo1.Tu * PhanSo2.Tu;
            tichPhanSo.Mau = PhanSo1.Mau * PhanSo2.Mau;
            tichPhanSo.inRaManHinh();
        }
        public void chiaHaiPhanSo()
        {
            PhanSo thuongPhanSo = new PhanSo();

            PhanSo PhanSo1 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 1:");
                PhanSo1.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 1:");
                PhanSo1.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Mau <= 0);

            PhanSo PhanSo2 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 2:");
                PhanSo2.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 2:");
                PhanSo2.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Mau <= 0);
            float a = PhanSo2.Tu;
            float b = PhanSo2.Mau;
            PhanSo2.Tu = b;
            PhanSo2.Mau = a;
            thuongPhanSo.Tu = PhanSo1.Tu / PhanSo2.Tu;
            thuongPhanSo.Mau = PhanSo1.Mau / PhanSo2.Mau;
            thuongPhanSo.inRaManHinh();
        }
        public void soSanh2PhanSo()
        {
            PhanSo PhanSo1 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 1:");
                PhanSo1.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 1:");
                PhanSo1.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo1.Mau <= 0);

            PhanSo PhanSo2 = new PhanSo();
            do
            {
                Console.WriteLine("Nhập tử phân số 2:");
                PhanSo2.Tu = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Tu <= 0);
            do
            {
                Console.WriteLine("Nhập mẫu phân số 2:");
                PhanSo2.Mau = Convert.ToInt32(Console.ReadLine());
            } while (PhanSo2.Mau <= 0);
            if (PhanSo1.Mau == PhanSo2.Mau)
            {
                if (PhanSo1.Tu > PhanSo2.Tu)
                {
                    Console.WriteLine("Phân số lớn hơn là:");
                    PhanSo1.inRaManHinh();
                }
                else if (PhanSo1.Tu < PhanSo2.Tu)
                {
                    Console.WriteLine("Phân số lớn hơn là:");
                    PhanSo2.inRaManHinh();
                }
                else
                {
                    Console.WriteLine(" 2 phân số bằng nhau");
                }

            }
            else if (PhanSo1.Tu == PhanSo2.Tu)
            {
                if (PhanSo1.Mau > PhanSo2.Mau)
                {
                    Console.WriteLine("Phân số lớn hơn là:");
                    PhanSo2.inRaManHinh();
                }
                else if (PhanSo1.Mau > PhanSo2.Mau)
                {
                    Console.WriteLine("Phân số lớn hơn là:");
                    PhanSo1.inRaManHinh();
                }
                else
                {
                    Console.WriteLine(" 2 phân số bằng nhau");
                }
            }
            else
            {
                float mau1 = PhanSo1.Mau;
                float mau2 = PhanSo2.Mau;
                PhanSo1.Tu = PhanSo1.Tu * mau2;
                PhanSo1.Mau = PhanSo1.Mau * mau2;
                PhanSo2.Tu = PhanSo2.Tu * mau1;
                PhanSo2.Mau = PhanSo2.Mau * mau1;
                if (PhanSo1.Tu > PhanSo2.Tu)
                {
                    Console.WriteLine("Phân số lớn hơn là:");
                    PhanSo1.inRaManHinh();
                }
                else if (PhanSo1.Tu < PhanSo2.Tu)
                {
                    Console.WriteLine("Phân số lớn hơn là:");
                    PhanSo2.inRaManHinh();
                }
                else
                {
                    Console.WriteLine(" 2 phân số bằng nhau");
                }

            }
        }
        public void NhapDayPhanSo()
        {
            int tt = 1;

            Console.WriteLine("mời nhập số lượng phân số muốn có trong dãy");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[2, n];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("phần tử array[{0},{1}] là:", i + 1, j + 1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("tử số và  mấu số thứ {0} lần lượt là:", j+1);
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }


        }
    }
}
