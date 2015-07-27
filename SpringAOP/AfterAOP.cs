using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;

namespace SpringAOP
{
    public class ConsoleLogginAfterAdvice:IAfterReturningAdvice
    {
        public void AfterReturning(
           object returnValue, MethodInfo method, object[] args, object target)
        {
            Console.Out.WriteLine("This method call returned successfully : " + method.Name);
            Console.Out.WriteLine("    The target was                     : " + target);
            Console.Out.WriteLine("    The arguments were                 : ");
            if (args != null)
            {
                foreach (object arg in args)
                {
                    Console.Out.WriteLine("\t: " + arg);
                }
            }
            Console.Out.WriteLine("    The return value is                : " + returnValue);
        }
    }
}
