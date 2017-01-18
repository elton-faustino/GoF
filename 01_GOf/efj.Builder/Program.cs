using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efj.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            Builder b1 = new B1();
            Builder b2 = new B2();

            director.Construct(b1);
            Product p1 = b1.RetornaProduto();
            p1.Printar();

            director.Construct(b2);
            Product p2 = b2.RetornaProduto();
            p2.Printar();

            Console.ReadKey();
        }
    }

    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.ConstruirParteA();
            builder.ConstruirParteB();
        }
    }

    public abstract class Builder
    {
        public abstract void ConstruirParteA();
        public abstract void ConstruirParteB();
        public abstract Product RetornaProduto();
    }

    public class B1 : Builder
    {
        private Product p = new Product();

        public override void ConstruirParteA()
        {
            p.AdicionarParte("parte a");
        }

        public override void ConstruirParteB()
        {
            p.AdicionarParte("parte b");
        }

        public override Product RetornaProduto()
        {
            return p;
        }
    }

    public class B2 : Builder
    {
        private Product p = new Product();

        public override void ConstruirParteA()
        {
            p.AdicionarParte("parte x");
        }

        public override void ConstruirParteB()
        {
            p.AdicionarParte("parte y");
        }

        public override Product RetornaProduto()
        {
            return p;
        }
    }

    public class Product
    {
        public List<string> lista = new List<string>();

        public void AdicionarParte(string nome)
        {
            lista.Add(nome);
        }

        public void Printar()
        {
            lista.ForEach(x => Console.WriteLine(x));
        }
    }

}
