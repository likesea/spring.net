using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;

namespace SpringAOP
{
    public class ConsoleLogginBeforeAdvice:IMethodBeforeAdvice
    {
        public void Before(MethodInfo method, object[] args, object target)
        {
            Console.Out.WriteLine("Intercepted call to this method : " + method.Name);
            Console.Out.WriteLine("    The target is               : " + target);
            Console.Out.WriteLine("    The arguments are           : ");
            if (args != null)
            {
                foreach (var arg in args)
                {
                    Console.Out.WriteLine("\t:"+arg);
                }
            }
        }
    }
}
