using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Insert : Comando
    {
        public override string Cmd()
        {
            return "INSERT INTO";
        }
    }
}
