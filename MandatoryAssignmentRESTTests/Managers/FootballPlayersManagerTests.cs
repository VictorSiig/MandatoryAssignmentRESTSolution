using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignmentREST.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentREST.Managers.Tests {
    [TestClass()]
    public class FootballPlayersManagerTests {
        [TestMethod()]
        public void GetAllTest() {
            FootballPlayersManager footballPlayersManager = new FootballPlayersManager();
            Assert.AreEqual(4, footballPlayersManager.GetAll(4));
        }
        
        [TestMethod()]
        public void GetByIdTest() {
            FootballPlayersManager footballPlayersManager = new FootballPlayersManager();
            Assert.AreEqual("Victor Siig", footballPlayersManager.GetById(1));
        }

        [TestMethod()]
        public void AddTest() {
            FootballPlayersManager footballPlayersManager = new FootballPlayersManager();

            Assert.AreEqual
        }

        [TestMethod()]
        public void DeleteTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest() {
            Assert.Fail();
        }
    }
}