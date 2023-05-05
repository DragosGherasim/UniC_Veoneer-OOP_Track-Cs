using PrinterLibrary;

namespace Delegates
{
    internal class Program
    {

        delegate bool _validate(int a, int b);

        delegate void _print(string message);

        public delegate void _encript(ref string text);

        static void Main(string[] args)
        {
            var encriptMethod = new _encript(MyEncriptMethod);
            encriptMethod += MyEncriptMethod2;

            var myText = "I can understand this !";
            encriptMethod(ref myText);

            //var myPrinterEncriptMethod = new PrintMessage.Encript(MyEncriptMethod);
            PrintMessage myPrinter = new PrintMessage(new PrintMessage.Encript(MyEncriptMethod));
            myPrinter.PrintToConsole(myText);

            //Console.WriteLine(myText);

            encriptMethod -= MyEncriptMethod2;

            encriptMethod(ref myText);

            Console.WriteLine(myText);
        }

        private static void MyEncriptMethod(ref string text)
        {
            text = new string(text.Reverse().ToArray());
        }

        private static void MyEncriptMethod2(ref string text)
        {
            text = text.ToUpper();
        }
    }
}