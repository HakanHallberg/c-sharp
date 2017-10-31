using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayLib
{
    public enum CellState
    {
        Alive,
        Dead,
    }
    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighburs)
        {
            switch (currentState)
            {
                case CellState.Alive:
                    if (liveNeighburs < 2 || liveNeighburs > 3)
                        return CellState.Dead;
                    break;
                case CellState.Dead:
                    if (liveNeighburs == 3)
                        return CellState.Alive;
                    break;
            }
            return currentState;
        }
    }
}
