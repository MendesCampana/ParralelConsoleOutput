using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParralelConsoleOutput
{
    public class ParallelConsoleOutputer : IParallelOutput
    {
        private bool _isRunning = false;
        private readonly string _outputText;
        private readonly int _outputIntervalSeconds;
        private readonly ConsoleColor _outputColor;    

        public ParallelConsoleOutputer(string outputText, double outputIntervalSeconds, ConsoleColor outputColor)
        {
            _outputText = outputText;
            _outputIntervalSeconds = (int)(outputIntervalSeconds * 1000);
            _outputColor = outputColor;
        }

        public void StartOutput()
        {
            if (!_isRunning)
                Task.Factory.StartNew(ParallelBackGroundWorker);
        }

        public void StopOutput()
        {
            _isRunning = false;
        }
        private void ParallelBackGroundWorker()
        {
            _isRunning = true;
            while(_isRunning)
            {
                Console.ForegroundColor = _outputColor;
                Console.WriteLine(_outputText);
                Thread.Sleep(_outputIntervalSeconds );
            }
        }
    }
}
