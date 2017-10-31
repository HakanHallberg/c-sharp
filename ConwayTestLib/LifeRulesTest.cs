using System;
using NUnit.Framework;
using ConwayLib;

namespace ConwayTestLib
{
    [TestFixture]
    public class LifeRulesTest
    {
        [Test]
        public void LiveCell_FewerThen2Nighburs_Dies([Values(0, 1)] int liveNeighburs)
        {
            var currentState = CellState.Alive;          
            CellState newState = LifeRules.GetNewState(currentState, liveNeighburs);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void LiveCell_2Or3LiveNeighburs_Lives([Values(2, 3)] int liveNeighburs)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighburs);
            Assert.AreEqual(CellState.Alive, newState);
        }
         
        [Test]
        public void LiveCell_MoreThan3Neighburs_Dies([Range(4, 8)] int liveNeighburs)
        {
            var currentState = CellState.Alive;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighburs);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void DeadCell_3LiveNeighburs_Lives()
        {
            var liveNeighburs = 3;
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighburs);
            Assert.AreEqual(CellState.Alive, newState);
        }

        [Test]
        public void DeadCell_FewerThan3LiveNeighburs_StaysDead([Range(0, 2)] int liveNeighburs)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighburs);
            Assert.AreEqual(CellState.Dead, newState);
        }

        [Test]
        public void DeadCell_MoreThan3LiveNeighburs_StaysDead([Range(4, 8)] int liveNeighburs)
        {
            var currentState = CellState.Dead;
            CellState newState = LifeRules.GetNewState(currentState, liveNeighburs);
            Assert.AreEqual(CellState.Dead, newState);
        }
    }
}
