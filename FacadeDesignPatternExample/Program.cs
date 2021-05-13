using System;

namespace FacadeDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Facade facade = new Facade();
                if(facade.TakeBankLoan(new Customer() { Id = 1, Name = "Joseph" }, 5000))
                {
                    Console.WriteLine("OK.!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error -> {ex.Message}");
            }
            Console.Read();
        }
    }
}
