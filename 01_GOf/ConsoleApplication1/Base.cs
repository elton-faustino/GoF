using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Base
    {
        public ICommand _cmd { get; set; }

        public Base(Command _command)
        {
            _cmd = _command;
        }

        public void Teste<TEntity>(TEntity t, string cmd)
        {
            _cmd.Comand<TEntity>(t, cmd);
        }
    }
}
