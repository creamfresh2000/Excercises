using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Skill
{
    public class Stopwatch
    { 
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private bool running = false;

        public void Start(DateTime start)
        {
            if (!running)
            {
                StartTime = start;
                running = true;
            }
            else
            {
                throw new InvalidExpressionException("Stopwatch is already running!!!");
            }
        }

        public void Stop(DateTime stop)
        {
            if (running)
            {
                EndTime = stop;
                running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            var duration = EndTime - StartTime;
            return duration;
        }
    }
}
