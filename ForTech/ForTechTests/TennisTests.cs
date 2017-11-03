using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForTech;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ForTech.Tests
{
    [TestClass()]
    public class TennisTests
    {
        

        [TestMethod()]
        public void Give_0_and_30_return_Love_Thirty()
        {
            var result = GetPlayerStatus(0,30);
            Assert.AreEqual("Love Thirty", result);
        }

        [TestMethod()]
        public void Give_40_and_40_return_deuce()
        {
            var result = GetPlayerStatus(40, 40);
            Assert.AreEqual("duece", result);
        }

        [TestMethod()]
        public void Give_41_and_40_return_deuce()
        {
            var result = GetPlayerStatus(41, 40);
            Assert.AreEqual("advantage", result);
        }

        private string GetPlayerStatus(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore ==40 && playerTwoScore == 40)
            {
                return ResultEnum.duece.ToString();
            }
            if (playerOneScore > 40 || playerTwoScore > 40)
            {
                return ResultEnum.advantage.ToString();
            }

            return string.Format("{0}"+" "+"{1}", ((ResultEnum)playerOneScore), ((ResultEnum)playerTwoScore));
        }

        public enum ResultEnum
        {
            Love = 0,
            duece,
            advantage,
            Fifteen = 15,
            Thirty = 30,
            Forty = 40
        }
    }
}
