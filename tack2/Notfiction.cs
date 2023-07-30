using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace tack2
{
    public class Notfiction:Book
    {
        public string subject;
        public override void checkout()
        {
            Console.WriteLine("Not_Fiction book '"+ title+"' checked out ");


        }
        public override void returnbook()
        {
            Console.WriteLine("Not Fiction book '"+title+"' returned.");
            
        }
        

        
    }
}
