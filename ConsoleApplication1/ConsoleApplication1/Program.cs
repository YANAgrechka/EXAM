using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface ICard
    {
        int Sum { get; set; }
        int add(int a);
        int del(int a);
            
    }
    abstract class Address
    {
         public string address;
    }
    class Person : Address, ICard
    {
        public int sum;
        public int Sum
        {
            get
            { return sum; }
            set
            { sum = value; }
        }


        public int add(int a)
        {
            sum += a;
            return sum;
        }

        public int del(int a)
        {
            sum -= a;
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.sum = 10;
            person.del(5);
            Console.WriteLine(person.sum);
            person.add(7);
            Console.WriteLine(person.sum);
            person.address = "Sverdlova 13a";
            Console.WriteLine(person.address);

        }
    }
}
