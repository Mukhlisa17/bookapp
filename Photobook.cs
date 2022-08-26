using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookapp
{
    public class Photobooks

    {
        protected int numpage;


        public int GetNumberPages()
        {

            return numpage;
        }
        Photobooks()
        {
            numpage = 16;
        }
        Photobooks(int numpage)
        {
            this.numpage = numpage;

        }

    }
    public class BigPhotoBook : Photobooks
    {
        public BigPhotoBook()
        {
            numpage = 64;
        }

    }
}
