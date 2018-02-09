using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71
{
    class Program
    {
        //Async main
        static void Main(string[] args)
        {
            var webReq = WebRequest.Create("");
            var response = webReq.GetResponseAsync();
        }


        void DefaultExpressions()
        {
            int i;

        }
        void InferredTupleElementNames()
        {
            var c = new Cube();

        }
  
    }

    class Cube
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
