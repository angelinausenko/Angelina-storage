namespace LabData2;
class Program
{
    static void Main(string[] args)
    {
        // Назва ноутбуку
        string Name = "MacBook Pro";

        // Процесор
        string proccessor = "M1";

        // Пам'ять (в ГБ)
        int memory = 16;

        // Операційна система
        string system = "Ventura 13";

        // Дисплей
        string display = "13-inch";

        Console.WriteLine("Назва ноутбуку " + Name);
        Console.WriteLine("Процесор " + proccessor);
        Console.WriteLine("Пам'ять в ГБ " + memory);
        Console.WriteLine("Операційна система " + system);
        Console.WriteLine("Дисплей " + display);
    }
}

