using System;
using DBLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;


namespace LibraryTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_DBSeed_Seed_InputFile()
        {
        }

        public void Test_DBSeed_Seed_HasProvider()
        {
           // var moqProvider = new Mock<IServiceProvider>();
            DBSeeder.Seed("dummyPath", new);
        }
    }
}
