using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_bot;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SqlQueries sqlqueries = new SqlQueries();
            Assert.IsNotNull(sqlqueries.custom_que("SELECT *","store"));
        }
}
}
