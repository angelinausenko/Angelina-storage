namespace Lab_4;
class Program
{


    static void Main(string[] args)
    {
        //число х більше або дорівнює 5,
        //та менше або дорівнює 15

        //Введення вихідних даних
        Console.Write("x=");
        double x = double.Parse(Console.ReadLine());

        //реалізація алгоритму
        if (x >= 5 && x <= 15)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
        //
        Console.ReadKey();
        


 


    }
}

