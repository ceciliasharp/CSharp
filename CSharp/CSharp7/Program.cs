using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        void OutVariables(string intString)
        {
            int i;
            if (int.TryParse(intString, out i))
            {

            }

        }

        void PatternMatching(object x)
        {

        }

        void TuplesAndDeconstruction()
        {
            var c1 = GetCoordinatesOld();
            var lati1 = c1.Item1;
            var longi1 = c1.Item2;

        }

        Tuple<decimal, decimal> GetCoordinatesOld()
        {
            //Latitude, Longitude
            return new Tuple<decimal, decimal>(59.3308324m, 18.0453261m);
        }

        void Discards(string intString)
        {

            if (int.TryParse(intString, out int i))
            {

            }

        }


        void LocalFunctions()
        {

        }



        void BinaryLiteralsAndDigitSeparators()
        {

        }


        void RefReturns()
        {
            var a = new MyAccount();
            var m = a.GetAmount();

            m += 100000;

        }

        Person person;


        void ThrowExpressions(Person p)
        {

            if (person == null)
            {
                throw new ArgumentNullException();
            }
            person = p;

        }

    }


    class MyAccount
    {
        public decimal amount;

        public decimal GetAmount()
        {
            return amount;
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
    class Developer : Person
    {
        public int YearsOfExperiens { get; set; }
    }
    class RegularPerson : Person
    {

    }
}
