using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void drawLine(int lenght = 10)
        {
            string line = "".PadRight(lenght, '=');
            WriteLine(line);
        }

        public static void writeTitle(string titulo)
        {
            drawLine(titulo.Length + 4);
            WriteLine($"| {titulo} |");
            drawLine(titulo.Length + 4);
        }
    }
}