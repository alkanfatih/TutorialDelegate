internal class Program
{
    //Geriya değer döndürmeyen string tipinde bir parametre alan bir metot tanımlıyoruz.
    public static void ConsolePrint(string text)
    {
        Console.WriteLine(text);
    }
    private static void Main(string[] args)
    {
        //Tanımladığımız metodumuzu delegate'imize yüklüyoruz.
        Action<string> action = ConsolePrint;

        //Delegate'imizi çağırıyoruz.
        action("Merhaba Dünya");
    }
}