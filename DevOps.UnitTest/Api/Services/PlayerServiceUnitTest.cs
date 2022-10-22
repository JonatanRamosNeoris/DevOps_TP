using DevOps.Web.Api.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DevOps.UnitTest.Api.Services
{
    [TestClass]
    public class PlayerServiceUnitTest
    {
        [TestMethod]
        public void PlayerService_Respository_Player_ID_Invalid_TestMethod()
        {
            var service = new PlayerService();

            // si no tengo datos lo doy como bueno
            if (service.Respository.Count == 0) Assert.IsTrue(true);
            else
            {
                var player = service.Respository.FirstOrDefault(e => e.ID <= 0);

                Assert.IsNull(player);
            }
        }

        [TestMethod]
        public void PlayerService_Respository_Player_Name_Invalid_TestMethod()
        {
            var service = new PlayerService();

            // si no tengo datos lo doy como bueno
            if (service.Respository.Count == 0) Assert.IsTrue(true);
            else
            {
                var player = service.Respository.FirstOrDefault(e => string.IsNullOrWhiteSpace(e.Name));

                Assert.IsNull(player);
            }
        }

        [TestMethod]
        public void PlayerService_Respository_Player_LastName_Invalid_TestMethod()
        {
            var service = new PlayerService();

            // si no tengo datos lo doy como bueno
            if (service.Respository.Count == 0) Assert.IsTrue(true);
            else
            {
                var player = service.Respository.FirstOrDefault(e => string.IsNullOrWhiteSpace(e.LastName));

                Assert.IsNull(player);
            }
        }
    }
}
