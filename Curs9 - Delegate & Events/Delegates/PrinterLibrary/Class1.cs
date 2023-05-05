namespace PrinterLibrary
{
    public class PrintMessage
    {

        public delegate void Encript(ref string text);

        private Encript _callbackEncriptMethod;

        public PrintMessage(Encript encriptMethod)
        {
            _callbackEncriptMethod = encriptMethod;
        }

        public void PrintToConsole(string message)
        {
            var encodeMessage = message;

            _callbackEncriptMethod(ref encodeMessage);

            Console.WriteLine(encodeMessage);
        }
    }
}