using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{ 
    // Publisher

    internal class CanChannel
    {
        public event EventHandler<Frame> NewFrameCreated;
        public int NumberGeneratedFrames { get; set; }

        public void StartSimulation()
        {
            var startTime = DateTime.Now;

            var count = 15;

            for (var i = 0; i < count; ++i)
            {
                ++NumberGeneratedFrames;

                var newFrame = new Frame
                {
                    Id = new Random().Next(1, 10),
                    Message = new List<byte> { 0, 1, 2, 3, 4 }
                };

                //Console.WriteLine($"A new message with ID = {newFrame.Id} was generated...");
                NewFrameCreated?.Invoke(this, newFrame); // sau if (NewFrameCreated != null) NewFrameCreated.Invoke(this, null);

                Thread.Sleep(new Random().Next(1000, 1500));
            }

            Console.WriteLine($"Timpul real de generare a tuturor frame-urilor: {DateTime.Now - startTime}");
        }
    }
}
