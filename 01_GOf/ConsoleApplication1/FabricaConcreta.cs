using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApplication1
{
    public class FabricaConcreta : CommandFactory
    {
        public override Comando CriarComando(string cmd)
        {
            var assembly = Assembly.GetExecutingAssembly().GetName().Name;

            var sb = new StringBuilder();
            sb.Append(assembly);
            sb.Append(".");
            sb.Append(cmd);

            

            var o = Activator.CreateInstance(assembly, sb.ToString());

            return (Comando)o.Unwrap();
        }
    }
}
