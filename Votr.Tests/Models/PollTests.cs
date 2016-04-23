using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Votr.Models;

namespace Votr.Tests.Models
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class PollTests
    {
       

        [TestMethod]
        public void PollEnsureICanCreateInstance()
        {
            Poll p = new Poll();
            Assert.IsNotNull(p);
            //
            // TODO: Add test logic here
            //
        }
    }
}
