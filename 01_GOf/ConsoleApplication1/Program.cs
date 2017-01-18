using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using KingAOP.Aspects;
using System.Dynamic;
using KingAOP;
using System.Linq.Expressions;

namespace ConsoleApplication1
{
    public class Program
    {

        static void Main(string[] args)
        {
            try
            {
                dynamic helloWorld = new Aspect();

                helloWorld.HelloWorldCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        class HelloWorldAspect : OnMethodBoundaryAspect
        {
            public override void OnEntry(MethodExecutionArgs args)
            {
                Console.WriteLine("OnEntry: Hello KingAOP");
            }

            public override void OnExit(MethodExecutionArgs args)
            {
                Console.WriteLine("OnExit: Hello KingAOP");
            }
        }

        class Aspect : IDynamicMetaObjectProvider
        {
            [HelloWorldAspect]
            public void HelloWorldCall()
            {
                Console.WriteLine("Hello World");
            }

            public DynamicMetaObject GetMetaObject(Expression parameter)
            {
                return new AspectWeaver(parameter, this);
            }
        }

        public static void Teste()
        {
            new Base(
                new Injetora())
                    ._cmd.Comand<Student>(new Student(), "Delete");

            Console.ReadKey();
        }

    }
}
