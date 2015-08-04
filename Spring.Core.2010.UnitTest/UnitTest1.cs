using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;
using Spring.Core.UnitTest;

namespace Spring.Core._2010.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DefaultApplicationContext()
        {
       
            IApplicationContext ctx = ContextRegistry.GetContext();
            var entity = ctx.GetObject("personDao") as PersonDao;
            entity.Save();
        }
    }
}
