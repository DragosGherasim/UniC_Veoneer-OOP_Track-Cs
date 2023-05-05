using System.Diagnostics;
using System.Runtime.CompilerServices;


var test = new Test(10);
var startTime = DateTime.Now;
test.Slide_9_4();

Console.WriteLine("Threads exited {0}", (DateTime.Now - startTime));
class Test
{
    private List<string> _sourceCollection = new List<string>();

    public Test(int index)
    {
        for(var i = 1; i <= index; ++i)
        {
            this._sourceCollection.Add($"s{i}");
        }
    }
    public void Slide_9()
    {
        foreach (var item in _sourceCollection)
        {
            Process(item);
        }
    }

    public void Slide_9_2()
    {
        var options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };
        Parallel.For(0, _sourceCollection.Count, options, iteration => Process(_sourceCollection[iteration]));
    }

    public void Slide_9_3()
    {
        var options = new ParallelOptions() { MaxDegreeOfParallelism = 3 };
        Parallel.ForEach(_sourceCollection, options, iteration => Process(iteration));
    }

    public void Slide_9_4() 
    {
        var tList = new Thread[4];

        for (var i=0; i < tList.Length; ++i)
        {
            var t = new ThreadStart(Start);
            tList[i] = new Thread(t);
            tList[i].Start();
        }

        foreach(var t in tList)
        {
            t.Join();
        }

        Console.WriteLine("Slide_9_4");
    }

    static void  Start()
    {
        Console.WriteLine("Start()");
    }

    private void Process(object o) {
        Console.WriteLine($"{o}, Thread={Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);
    }
}
