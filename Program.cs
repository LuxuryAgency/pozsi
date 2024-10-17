namespace autohaladas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            auto a = new auto { Fogyasztas = 7, MaxÜzemanyag = 55, MegTettUt = 0,Üzemagyagszint=55 };
  
            a.fele += Fele;
            a.kifogy += Kifogy;
            a.Haladas(500);
            a.Haladas(500);
            a.Haladas(500);
            a.Haladas(500);

        }

        static void Fele(int megtett)
        {
            Console.WriteLine("Fele üa elfogyott");
            Console.WriteLine($"Megtett ut:{megtett}");
        }
        static void Kifogy(int megtett)
        {
            Console.WriteLine("üa elfogyott");
            Console.WriteLine($"Megtett ut:{megtett}");
        }
    }
}
