using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiLuyenTapOOP
{
    public interface IServiceBook
    {
        void Add();
        void Xuat();
        void SapXepTheoNamXuatBan();
        void SapXepTheoTenTacGia();
        void SapXepTheoTenSach();
        void Update();
        void Delete();
        void SearchTenSach();
    }
}
