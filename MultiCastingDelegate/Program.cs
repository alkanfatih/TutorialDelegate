using System.Runtime.ConstrainedExecution;

internal class Program
{
    //Geriye değer döndürmeyen iki adet parametre alan bir delegate tanımlıyoruz.
    public delegate void CalculateDelegate(int width,int height);

    //Delegate atanmak üzere alan hesabı yapan iki parametreli bir metot tanımlıyoruz.
    public static void Area(int width, int height)
    {
        Console.WriteLine("Alan: {0}", (width*height));
    }

    //Delegate atanmak üzere çevre hesabı yapan iki parametreli bir metot tanımlıyoruz.
    public static void Perimeter(int width, int height)
    {
        Console.WriteLine("Alan: {0}", 2 * (width + height));
    }

    private static void Main(string[] args)
    {
        // Delagete objesi oluşturuyoruz.
        // parametre olarak Area methodunu gönderiyoruz.
        CalculateDelegate calculateDelegate = new CalculateDelegate(Area);

        // Oluşturduğumuz delegate objesine ayrıca Perimeter metodunu da ekliyoruz. (+= operatörü ile)
        calculateDelegate += Perimeter;

        //Atama yaptığımız delegate'i çağırıyoruz.
        calculateDelegate(50, 20);
    }
}