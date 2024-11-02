using System;


namespace extension.methods
{
    // Методы расширения (extension methods) позволяют добавлять новые методы в уже существующие типы 
    // без создания нового производного класса. Эта функциональность бывает особенно полезна, когда 
    // необходимо добавить в некоторый тип новый метод, но сам тип (класс или структуру) изменить нельзя.
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Методы расширения позволяют добавлять новые методы в уже существующие типы без создания нового производного класса";
            char c = 'е';
            int i = s.SymbolCount(c);
            // i = StringExtension.SymbolCount(s, c);
            Console.WriteLine("Буква '" + c + "' встречается в строке " + i + " раз");
        }
    }

    public static class StringExtension
    {
        public static int SymbolCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
}