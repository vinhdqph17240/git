using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    class Service
    {
        private FileStream _fs;
        private BinaryFormatter _bf;
        private int _input;
        private List<Book> _lstbooks = new List<Book>();
        public List<Book> Add()
        {
            Console.WriteLine("Mời bạn nhập số lượng muốn them sach : ");
            _input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _input; i++)
            {
                Book book = new Book();
                Console.WriteLine("Moi ban nhap ma sach: ");
                book.MaSach = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập ten sach: ");
                book.TenSach = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập ten tac gia: ");
                book.TenTacGia = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập nha xuat ban: ");
                book.NhaXuatBan = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập nam xuat ban: ");
                book.NamSanXuat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời bạn nhập so hieu ISBN: ");
                book.SoHieuISBN = Convert.ToInt32(Console.ReadLine());
                _lstbooks.Add(book);
            }
            return _lstbooks;
        }
        public List<Book> openFile(string path)
        {
            try
            {

                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                _lstbooks = (List<Book>)_bf.Deserialize(_fs);
                _fs.Close();
                return _lstbooks;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _fs.Close();
                return null;
            }
        }
        public string saveFile(string path, List<Book> lst)
        {
            /* try
             {*/
            _fs = new FileStream(path, FileMode.OpenOrCreate);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, lst);
            _fs.Close();
            return "Save thanh cong";
            /*}
            catch (Exception e)
            {
                Console.WriteLine(e);
                _fs.Close();
                return "Ghi file thất bại";
            }*/
        }
    }
}
