using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    class Demo
    {
        Tuple<decimal, decimal> GetCoordinates()
        {
            //Latitude, Longitude
            return new Tuple<decimal, decimal>(59.3308324m, 18.0453261m);
        }
        void TuplesAndDeconstruction()
        {
            var c1 = GetCoordinates();

        }

        void BinaryLiteralsAndDigitSeparators()
        {

        }

        void OutVariablesAndDiscards(string intString)
        {
            int i;
            if (int.TryParse(intString, out i))
            {

            }

        }

        Person person = null;
        void ThrowExpressions(Person p)
        {

            if (p == null)
            {
                throw new ArgumentNullException();
            }
            person = p;

        }

        void PatternMatching(object x)
        {

        }

        void LocalFunctions()
        {

        }


        void RefReturns()
        {
            var a = new MyAccount();
            var m = a.GetAmount();

            m += 100000;

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
        public Person()
        {
            Name = String.Empty;
        }
    }
    class Developer : Person
    {
        public int YearsOfExperiens { get; set; }
    }
    class RegularPerson : Person
    {

    }
}
