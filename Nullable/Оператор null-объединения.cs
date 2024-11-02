using System;

namespace Nullable
{
    /*
     В различных ситуациях бывает удобно, чтобы объекты числовых типов данных имели значение null, 
     то есть были не определены. Стандартный пример - работа с базой данных, которая может 
     содержать значения null. Невозможно заранее знать, что мы получим из базы данных - 
     какое-то определенное значение или же null. Для этого следует использовать знак вопроса ? после типа значений.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int? a = 7; 
            //Nullable<int> a = 7;
            a = null;
            int? b = null; // Nullable<int> b = null;
            bool? c = null; // Nullable<bool> c = null;
            bool? d = true; //  Nullable<bool> d = true;
            double? e = 5.7; // Nullable<System.Double> e = 5.7;

            // Чтобы получить доступ к значению Nullable, следует использовать свойство Value
            // Чтобы проверить, имеется ли у структуры какое-либо значение, следует применить свойство HasValue
            State? state = null;
            if (state.HasValue)
                Console.WriteLine(state.Value.Name);
            state = new State() { Name = "Украина" };
            if (state.HasValue)
                Console.WriteLine(state.Value.Name);

            //Nullable<Country> country = null; //недопустимо

            // явное преобразование от T? к T
            int? x1 = 7;
            if (x1.HasValue)
            {
                int x2 = (int)x1;
                Console.WriteLine(x2);
            }

            //неявное преобразование от T к T?
            int x3 = 4;
            int? x4 = x3;
            Console.WriteLine(x4);

            // явные сужающие преобразования от V к T?
            long l1 = 10;
            int? l2 = (int?)l1;
            Console.WriteLine(l2);

            // Оператор ?? называется оператором null-объединения. 
            // Он применяется для установки значений по умолчанию 
            // для типов, которые допускают значение null. 
            // Оператор ?? возвращает левый операнд, если этот операнд не равен null. 
            // Иначе возвращается правый операнд. 
            int? x = null;
            int y = x ?? 100;  // равно 100, так как x равен null
            Console.WriteLine(y);

            int? z = 200;
            int t = z ?? 50; // равно 200, так как z не равен null
            Console.WriteLine(t);

            Country c1 = null;
            Country c2 = c1 ?? new Country { Name = "Украина" };
            Console.WriteLine(c2.Name);

            int n = 44;
            // int m = n ?? 100; // недопустимо
            // Переменная n не является nullable-типом и не может принимать значение null, 
            // поэтому в качестве левого операнда в операции ?? она использоваться не может
        }
    }

    class Country
    {
        public string Name { get; set; }
    }
    struct State
    {
        public string Name { get; set; }
    }
}
