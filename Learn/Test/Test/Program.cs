using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("杨清生");
            p.Ff();
            Console.ReadKey();
           
        }
    }
    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        private string _name;

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public void Ff()
        {
            Console.WriteLine("{0}这是一个测试方法",this.Name);
        }
    }
}
