using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Command : ICommand
    {
        public void Comand<TEntity>(TEntity t, string cmd)
        {
            t.GetType().GetProperties().ToList().ForEach(x => Console.WriteLine(x.Name));

            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name);

            t.GetType().GetMethods().ToList().ForEach(x => x.GetParameters().ToList().ForEach(y => Console.WriteLine(y.Name)));
        }
    }
}
