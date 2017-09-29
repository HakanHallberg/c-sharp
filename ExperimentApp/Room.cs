using System;
using System.Collections.Generic;
using System.Linq;

namespace ExperimentApp
{
    public class Room
    {
        private List<Window> Windows = new List<Window>();

        

        public int NumberOfClosedWindows
        {
            get
            {
                return Windows.Where(window => !window.IsOpen).Sum(Window => 1);
            }
        }

        public void AddWindow(Window window1)
        {
            Windows.Add(window1);
        }
    }
}