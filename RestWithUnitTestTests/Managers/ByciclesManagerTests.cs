using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestWithUnitTest.Managers;
using RestWithUnitTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestWithUnitTest.Managers.Tests
{
    [TestClass()]
    public class ByciclesManagerTests
    {

        [TestMethod()]
        public void GetAllTest()
        {

            ByciclesManager manager = new ByciclesManager();
            List<Bycicles> all = manager.GetAll();
            Assert.AreEqual(2, all.Count);

        }


        [TestMethod()]
        public void AddTest()
        {
            ByciclesManager manager = new ByciclesManager();

            Bycicles ny = new Bycicles() { Name = "Puk" };
            Bycicles ny2 = manager.Add(ny);
            Assert.AreEqual(ny.Name, ny2.Name);
            Assert.AreEqual(3, ny2.Id);

        }




    }

}