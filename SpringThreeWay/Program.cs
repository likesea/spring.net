using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;

namespace SpringThreeWay
{
    class Program
    {
        static void Main(string[] args)
        {
            //IApplicationContext ctx = new XmlApplicationContext(new string[]
            //    {
            //        "assembly://SpringThreeWay/SpringThreeWay/AppContext.xml"
            //    });
            IApplicationContext ctx = ContextRegistry.GetContext();
            var personDao = ctx.GetObject("personDao") as PersonDao;
            personDao.Save();
            Console.ReadLine();
        }
    }
}
