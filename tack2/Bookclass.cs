using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tack2
{
  public abstract  class Book
    {
        public string author;
        public  string title;
       public int  ISBN;
        public int numpage;
        public abstract void checkout();

        public abstract void returnbook();     

    }
}
