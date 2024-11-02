using System;


namespace AnonymousType
{
    /*
     Иногда возникает задача использовать один тип в одном узком контексте или даже один раз. 
     Создание класса для подобного типа может быть избыточным. 
     Типичная ситуация - получение результата выборки из базы данных: 
     объекты применяются только для получения выборки и больше нигде не используются. 
     Классы для них создавать было бы излишне. А вот анонимный тип прекрасно подходит 
     для временного хранения выборки.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Вывод типа
                // Тип переменной вычисляется на основе выражения на этапе компиляции программы
                var x = 10;
                var y = 3.7;
                var s = "Hello!";
                var c = '!';
                Console.WriteLine(x.GetType());
                Console.WriteLine(y.GetType());
                Console.WriteLine(s.GetType());
                Console.WriteLine(c.GetType());
                // c = y; // ошибка компиляции: невозможно преобразовать double к char

                int[] Mas = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                foreach (var val in Mas)
                    Console.WriteLine(val);

                // Создание анонимного типа
                var manager = new { Company = "Microsoft", Manager = "Сатья Наделла", Age = 48 };
                var director = new { Company = "Google", Director = "Ларри Пейдж", Age = 42 };
                Console.WriteLine(manager.GetType().Name);
                Console.WriteLine(director.GetType().Name);

                Console.WriteLine("Company = " + manager.Company + "\tManager = " + manager.Manager + "\tAge = " + manager.Age);
                Console.WriteLine("Company = " + director.Company + "\tDirector = " + director.Director + "\tAge = " + director.Age);

                // manager = director;  // ошибка компиляции: различные анонимные типы

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}