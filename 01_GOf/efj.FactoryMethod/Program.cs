using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efj.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Concrete().Caa("c2");

            Console.ReadKey();
        }
    }

    public abstract class Factory
    {
        public abstract Ca Caa(string name);
    }

    public class Concrete : Factory
    {
        public override Ca Caa(string name)
        {
            Ca c = null;

            if (name.Equals("c1"))
                c = new C1();

            if (name.Equals("c2"))
                c = new C2();

            c.Acelle();
            return c;
        }
    }

    public abstract class Ca
    {
        public abstract void Acelle();
    }

    public class C1 : Ca
    {
        public override void Acelle()
        {
            Console.WriteLine("c1 andando");
        }
    }

    public class C2 : Ca
    {
        public override void Acelle()
        {
            Console.WriteLine("c2 andando");
        }
    }
}
