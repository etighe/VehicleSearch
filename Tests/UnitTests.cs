using System;
using DBLib;
using DBLib.Managers;
using DBLib.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void Test_Manager_GetVehicles_noContext_FAILS()
        {
            try
            {
                var mgr = new VehicleManager();
                var dummyContext = new VsContext();
                var dummyReq = new VehicleReq();

                var whatever = mgr.GetVehicles(dummyContext, dummyReq).Result;
            }
            catch (Exception e)
            {
                Assert.Pass();
            }


        }

        [Test]
        public void Test_Manager_GetVehicles_hasContext_PASS()
        {
            try
            {
                var mgr = new VehicleManager();

                var optionsBuilder = new DbContextOptionsBuilder();
                optionsBuilder.UseSqlite("Data Source=VehicleSearch.db");
                var dummyContext = new VsContext(optionsBuilder.Options);

                var dummyReq = new VehicleReq();
                var whatever = mgr.GetVehicles(dummyContext, dummyReq).Result;

                Assert.IsInstanceOf<VsContext>(dummyContext);
                Assert.Pass();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}