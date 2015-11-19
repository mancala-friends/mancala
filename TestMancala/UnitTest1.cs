using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class UnitTest1
    {

        [TestMethod()]
        public void tryMoveTestBasic()
        {
            Rules daRules = new Rules(1);
            //move player 1 location 0

            //test normal move P1
            daRules.tryMove(5);

            if(daRules.gamestate.playerOne[5] != 0) Assert.Fail("Didn't empty pit P1");
            if (daRules.gamestate.playerOne[6] != 1) Assert.Fail("Didn't place pebble in store P1");
            if (daRules.gamestate.playerTwo[0] != 5) Assert.Fail();
            if (daRules.gamestate.playerTwo[1] != 5) Assert.Fail();
            if (daRules.gamestate.playerTwo[2] != 5) Assert.Fail();
            if (daRules.gamestate.playerTwo[3] != 4) Assert.Fail("went too far");

            //test normal move P2
            daRules.tryMove(5);
            if (daRules.gamestate.playerTwo[5] != 0) Assert.Fail("Didn't empty pit P2");
            if (daRules.gamestate.playerTwo[6] != 1) Assert.Fail("Didn't place pebble in store P2");
            if (daRules.gamestate.playerOne[0] != 5) Assert.Fail();
            if (daRules.gamestate.playerOne[1] != 5) Assert.Fail();
            if (daRules.gamestate.playerOne[2] != 5) Assert.Fail();
            if (daRules.gamestate.playerOne[3] != 4) Assert.Fail("went too far");
        }

        [TestMethod()]
        public void tryMoveTestSteal()
        {
            Rules daRules = new Rules(1);
            //move player 1 location 0

            //test normal move P1
            daRules.tryMove(5);
            daRules.tryMove(3);
            daRules.tryMove(0);

            if (daRules.gamestate.playerOne[6] != 7) Assert.Fail();
            if (daRules.gamestate.playerOne[5] != 0) Assert.Fail();
            if (daRules.gamestate.playerTwo[0] != 0) Assert.Fail();
        }

        [TestMethod()]
        public void tryMoveTestGoAgain()
        {
            //test to go again after landing in store
            Rules daRules = new Rules(1);
            
            daRules.tryMove(2);
            Assert.AreEqual(1, daRules.gamestate.currentPlayer);
        }


        [TestMethod()]
        public void tryMoveTestEmptyPit()
        {
            Rules daRules = new Rules(1);

            Assert.IsFalse(daRules.gamestate.isOver());
            Assert.IsFalse(daRules.tryMove(-1));
            Assert.IsFalse(daRules.tryMove(6));

            //move player 1 location 0
            daRules.tryMove(0);

            if (daRules.gamestate.currentPlayer != 2)
            {
                Assert.Fail("should be player twos turn");
            }

            Assert.IsFalse(daRules.tryMove(-1));
            Assert.IsFalse(daRules.tryMove(6));

            //move player 2 location 0
            daRules.tryMove(0);

            if (daRules.gamestate.currentPlayer != 1)
            {
                Assert.Fail("should be player one's turn");
            }

            //try to move player 1 location 0 again, this should return false(can't move an empty space)
            if (daRules.tryMove(0) == true)
            {
                Assert.Fail("was allowed to move when not allowed");
            }

            if (daRules.gamestate.currentPlayer != 1)
            {
                Assert.Fail("should stay player one's turn");
            }

            daRules.tryMove(2);
            daRules.tryMove(5);
            daRules.tryMove(0);

            //try to move player 2 location 5 again, this should return false(can't move an empty space)
            if (daRules.tryMove(5) == true)
            {
                Assert.Fail("was allowed to move when not allowed");
            }

            if (daRules.gamestate.currentPlayer != 2)
            {
                Assert.Fail("should stay player one's turn");
            }

        }
    }
}

namespace TestMancala
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(2 == 2);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(5 == 5);
        }
    }
}
