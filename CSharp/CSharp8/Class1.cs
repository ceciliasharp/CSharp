using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public class Demo
    {
        public void Demo1(Person person)
        {
            var customer = person as Customer;

            if (customer.Level == 5)
            { }

        }

        public void Demo2(Person person)
        {
            var s = person.Name;
            var w = new Work();

            w.Assign(person);
        }

        public Person? GetPerson()
        {
            return new Person();
        }
    }

    public class Work
    {
        public void Assign(Person p)
        {

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public Person()
        {
            Name = string.Empty;
        }
    }

    public class Customer : Person
    {
        public int Level { get; set; }
        public Customer()
        {
            Level = 0;
        }
    }


}
