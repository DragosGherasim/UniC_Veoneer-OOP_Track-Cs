using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Events
{
    // Subscriber

    internal class CanTracer
    {
        private CanChannel _channel;

        public CanTracer(CanChannel channel)
        {
            _channel = channel;
        }
        
        public void StartTrace()
        {
            _channel.NewFrameCreated += OnNewFrameGenerated;

            Thread.Sleep(15000);

            StopTrace();
        }

        private void OnNewFrameGenerated(object sender, Frame e)
        {
            PrintFrame(e);
        }

        public void StopTrace()
        {
            Console.WriteLine($"Number of frames generated : {_channel.NumberGeneratedFrames}");

            _channel.NewFrameCreated -= OnNewFrameGenerated;
        }

        public void PrintFrame(Frame frame)
        {
            Console.WriteLine($"A new message with ID = {frame.Id} was generated...");
        }
    }
}
