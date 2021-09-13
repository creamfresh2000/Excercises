using System;
using System.Threading;
using System.Threading.Channels;

namespace Skill
{
    class Program
    {
     
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start(DateTime.Now);

                for (var j = 0; j <= 100; j++)
                {
                    Thread.Sleep(12);
                }

                stopwatch.Stop(DateTime.Now);

                Console.WriteLine("Time spend:" + stopwatch.GetInterval().ToString());
                Console.ReadLine();

            }
        }
    }
}
