using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game_FireGmae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_FireGmae.Tests
{
    [TestClass()]
    public class Play_hereTests
    {
        [TestMethod()]
        public void Play_hereTest()
        {
            Play_here obj = new Play_here();
            obj.disableBtn();
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void Play_hereTest2()
        {
            FireTask obj = new FireTask();
           int y= obj.getNumber(1,3);
            if (y < 4)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
            
        }



    }
}