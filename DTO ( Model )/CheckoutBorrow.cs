using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class CheckoutBorrow
    {
        public string stt { get; set; }
        public string kindname { get; set; }
        public int numberBorrowBook { get; set; }
        public CheckoutBorrow() { }
        public CheckoutBorrow(string tt, string name, int number)
        {
            this.stt = tt;
            this.kindname = name;
            this.numberBorrowBook = number;
        }

    }
}
