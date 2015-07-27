using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop;

namespace SpringAOP
{
    public class ExceptionAdvice: IThrowsAdvice
    {
        public void AfterThrowing(Exception ex)
        {
            Console.Out.WriteLine("Advised method threw this exception : " + ex);
        }
    }
}
