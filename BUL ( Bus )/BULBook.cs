using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALConnector;
using DTOModel;
namespace BULBus
{
    public class BULBook
    {
        DALBook myTaiLieuDal = new DALBook();
        /*------------------------ thể loại -----------------------------*/
        public List<kind> ListViewKind()
        {
            return myTaiLieuDal.ListViewKind();
        }
        public List<string> listID()
        {
            return myTaiLieuDal.ListTheLoai();
        }
        public bool UpdateKind(kind k)
        {
            return myTaiLieuDal.UpdateKind(k);
        }
        public List<kind> SearchByID (string id)
        {
            return myTaiLieuDal.SearchKind(id);
        }
        public bool DeleteKind (string id)
        {
            return myTaiLieuDal.DeleteKind(id);
        }

        /*------------------------ tài liệu -----------------------------*/
        public bool AddKind(kind k)
        {
            return myTaiLieuDal.AddKind(k);
        }

        public List<Book> LayDanhSachTaiLieu()
        {
            return myTaiLieuDal.LayThongTinTaiLieu();
        }
        public bool ThemMotTaiLieu(Book aTL)
        {
            return myTaiLieuDal.ThemTL(aTL);
        }
        public bool SuaThongTinTaiLieu(Book aTl)
        {
            return myTaiLieuDal.SuaTaiLieu(aTl);
        }
        public bool XoaMotTaiLieu(string ma)
        {
            return myTaiLieuDal.XoaTaiLieu(ma);
        }
        public List<Book> TimTaiLieuTheoMa(string ma)
        {
            return myTaiLieuDal.TimTaiLieu(ma);
        }
    }
}
