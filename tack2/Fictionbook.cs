using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tack2
{
    public class Fictionbook:Book
    {
        public String genre;
        public override void checkout()
        {
            Console.WriteLine("Fiction book '"+ title+"' checked out");

        }
        public override void returnbook()
        {
            Console.WriteLine("Fiction book '"+title+"' returned.");
            
        }        
        

    }
}
