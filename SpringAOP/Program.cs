using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;
using Spring.Aop.Framework;
using Spring.Aop.Support;
using Spring.Aspects.Exceptions;
using Spring.Context.Support;

namespace SpringAOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory(new ServiceCommand());
            factory.AddAdvice(new ExceptionAdvice());
            ICommand cc = (ICommand)factory.GetProxy();
            cc.Execute();
            //cc.DoExecute();
            //var ctx = ContextRegistry.GetContext();
            //ICommand command = (ICommand)ctx.GetObject("myAfterAdvice");
            //command.Execute();
            //command.DoExecute();
            Console.ReadLine();
        }
    }
    public interface ICommand
    {
        void Execute();
        void DoExecute();
    }

    public class ServiceCommand : ICommand
    {
        public void Execute()
        {
            throw new UnauthorizedAccessException();
           //Console.Out.WriteLine("Service implementation : Execute()...");
            
        }
        public void DoExecute()
        {
            Console.Out.WriteLine("Service implementation : DoExecute()...");
        }
    }
    public class ConsoleLoggingAroundAdvice : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            Console.WriteLine();
            Console.Out.WriteLine("Advice executing:calling the advised method..."); 
            object returnValue = invocation.Proceed();
            Console.Out.WriteLine("Advice executed: advised method returned " + returnValue); 
            return returnValue; 
        }
    }
}
