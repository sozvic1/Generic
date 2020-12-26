using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region first task
            var book1 = new Book<int>() { Name = "Clr via C#", Price = 700 };
            book1.Show();
            var book2 = new Book<double>() { Name = "Clr via C#", Price = 500.50 };
            book2.Show();
            // Console.Read();
            #endregion
           
            #region second task
            var  myClass =  MyClass<Car>.FactoryMethod();
            Console.WriteLine($"Имя типа {myClass}");
            #endregion

            #region third task
            var calculator = new Calculator<double, double>();
            Console.WriteLine($"{3} + {2} = {calculator.Addition(3, 2)} ," +
                $" вычетание {5} - {3} = {calculator.Subtraction(5,3)}," +
                $" умножение {5} * {3} = {calculator.Multiplication(5,3)} "); 
            Console.ReadKey();
            #endregion

            #region third task
            
          
            DateTime? time =null; //не ссылочный тип
            if(time==null)
            {
                Console.WriteLine("равны");
            }
            #endregion
        }
    }
}
