using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOModel;
using DALConnector;
namespace BULBus
{
    public class BULAuthor
    {
        DALAuthor dg = new DALAuthor();

        public List<Author> LayDanhSachDG()
        {
            return dg.LayThongTinDocGia();
        }
        public List<string> LayDanhSachDGWithID()
        {
            List<string> list = new List<string>();
            for(int i=0; i< dg.LayThongTinDocGia().Count; i++)
            {
                list.Add(dg.LayThongTinDocGia()[i].MaDocGia);
            }
            return list;
        }
        public bool Them(Author adddG)
        {
            return dg.ThemDG(adddG);

        }
        public bool KiemTraDG(string maDG)
        {
            return dg.checkDG(maDG);
        }
        public bool EditDocGia(Author aDG)
        {
            return    dg.SuaDocGia(aDG);
        }
        public bool DeleteDocGia(string ma)
        {
            return dg.XoaDocGia(ma);
        }
        public List<Author> TimDocGia(string ma)
        {
            return dg.TimDocGia(ma);
        }
    }
}
