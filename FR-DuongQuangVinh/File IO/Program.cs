using System;
using System.Collections.Generic;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            string path = @"C:\Users\PC\Desktop\Fresher c# NTQ Solution\git\FR-DuongQuangVinh\File IO\File";
            List<Book> _lstbooks = new List<Book>();
            int _menu;
            do
            {
                Console.WriteLine("có cac service sau:");
                Console.WriteLine("1.Doc file");
                Console.WriteLine("2.Ghi file");

                _menu = int.Parse(Console.ReadLine());
                switch (_menu)
                {
                    case 1:
                        _lstbooks = service.openFile(path);
                        if (_lstbooks == null) break;
                        
                        foreach (var x in _lstbooks)
                        {
                            x.inRaManHinh();
                        }

                        break;
                    case 2:
                        _lstbooks = service.Add();
                        Console.WriteLine(service.saveFile(path, _lstbooks));
                        break;
                    default:
                        Console.WriteLine("Hen gap lai");
                        break;
                }
            } while (_menu < 3);
        }
    }
}
