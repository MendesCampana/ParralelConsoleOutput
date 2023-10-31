using System;
using System.Collections.Generic;
using System.Text;

namespace ParralelConsoleOutput
{
    public interface IParallelOutput
    {
        public void StartOutput();
        public void StopOutput();
    }
}
