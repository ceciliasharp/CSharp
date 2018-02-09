using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp72
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Span and ref-like types
        void Span()
        {
            var arr = new byte[10];
            Span<byte> bytes = arr; // Implicit cast from T[] to Span<T>


            Span<byte> slicedBytes = bytes.Slice(start: 5, length: 2);
            slicedBytes[0] = 42;
            slicedBytes[1] = 43;
        }

        void InParameters(int value)
        {
            value++;
        }


        void NonTrailingNamedArguments()
        {

        }


        void Foo(int X, int Y, int Z)
        { }


    }

    class PrivateProtected
    {

    }
}
