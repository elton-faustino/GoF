using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efj.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new FactoryProducer().getFabrica("color");

            IColor c = f.getColor("vermelho");

            c.fill();

            Console.ReadKey();
        }
    }

    public class FactoryProducer
    {
        public AbstractFactory getFabrica(string nome)
        {
            if (nome.Equals("color"))
                return new ColorFactory();

            if (nome.Equals("shape"))
                return new ShapeFactory();

            return null;
        }
    }

    public abstract class AbstractFactory
    {
        public abstract IShape getShape(string name);
        public abstract IColor getColor(string name);
    }

    public class ColorFactory : AbstractFactory
    {
        public override IShape getShape(string name)
        {
            throw new NotImplementedException();
        }

        public override IColor getColor(string name)
        {
            if (name.Equals("vermelho"))
                return new Red();

            if (name.Equals("azul"))
                return new Blue();

            return null;
        }
    }

    public class ShapeFactory : AbstractFactory
    {
        public override IShape getShape(string name)
        {
            if (name.Equals("quadrado"))
                return new Square();

            if (name.Equals("circulo"))
                return new Circle();

            return null;
        }

        public override IColor getColor(string name)
        {
            throw new NotImplementedException();
        }
    }

    public interface IShape
    {
        void draw();
    }

    public interface IColor
    {
        void fill();
    }

    public class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("quadrado");
        }
    }

    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("circulo");
        }
    }

    public class Blue   : IColor
    {
        public void fill()
        {
            Console.WriteLine("desenhando azul");
        }
    }

    public class Red    : IColor
    {
        public void fill()
        {
            Console.WriteLine("desenhando vermelho");
        }
    }
}
