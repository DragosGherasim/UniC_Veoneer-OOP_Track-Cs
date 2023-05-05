using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simulator = new CanChannel();

            var tracer = new CanTracer(simulator);

            // Thread2 -> trace.Start()
            // Thread1 -> simulator.StartSimulator()
            // Thread2 -> Sleep(1500) // 15 s
            // Thread2 -> trace.StopTrace()

            /*tracer.StartTrace();

            simulator.StartSimulation();

            tracer.StopTrace();*/

            var thread1 = new Thread(tracer.StartTrace);
            var thread2 = new Thread(simulator.StartSimulation);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.ReadKey();
        }
    }
}
