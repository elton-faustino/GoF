using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    class Program
    {
        static void Main(string[] args)
        {
            new MeuFor().MeuMetodoFor<double>(x => Console.WriteLine(x + 30));

            Console.ReadKey();
        }
    }

    public class MeuFor
    {
        public void MeuMetodoFor<TEntity>(Action<TEntity> action)
        {
            TEntity[] vet = new TEntity[10];

            for (int i = 0; i < vet.Length; i++)
                action(vet[i]);
        }
    }

}
