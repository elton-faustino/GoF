using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new List<T1>()
            {
                new T1(){id = 1, nome = "a"},
                new T1(){id = 2, nome = "b"},
                new T1(){id = 3, nome = "c"}
            };

            var l2 = new List<T2>()
            {
                new T2(){id = 1, nome = "a"},
                new T2(){id = 2, nome = "b"},
            };

            var x = (from lista1 in l1
                     join lista2 in l2
                     on new { nome = lista1.nome, id = lista1.id }
                     equals new { nome = lista2.nome, lista2.id }
                     into aux
                     from c in aux.DefaultIfEmpty()
                     select new { c, lista1 });

            foreach (var item in x.ToList().Where(y => y.c == null))
                Console.WriteLine(item.lista1.id
                    + " "
                    + item.lista1.nome);

            Console.ReadKey();
        }

        public class T1
        {
            public int id { get; set; }

            public string nome { get; set; }
        }

        public class T2
        {
            public int id { get; set; }

            public string nome { get; set; }
        }
    }
}
