//DELEGATE KULLANIMI
internal class Program
{
    //Geriye değer döndürmeyen iki adet parametre alan bir delegate tanımlıyoruz.
    public delegate void numDelegate(int a, int b);

    //Delegate atamak üzere toplama işlemi yapan bir metot tanımlıyoruz.
    public static void sum(int a, int b)
    {
        Console.WriteLine("Toplam: {0}", a+b);
    }

    //Delegate atamak üzere çıkarma işlemi yapan bir metot tanımlıyoruz.
    public static void subtract(int a, int b)
    {
        Console.WriteLine("Fark = {0}", a - b);
    }

    //Main Metot
    private static void Main(string[] args)
    {
        //Tanımlamış olduğumuz metotlarımızı kullanmak üzere taşıyabilmesi için delegatelerimize yüklüyoruz.
        numDelegate sumDelegate = new numDelegate(sum);

        numDelegate subtractDelegate = new numDelegate(subtract);

        //Delegate çağırma.
        //Verdiğimiz parametreleri delegateler üzerinden kullanılmak üzere metotlarımıza iletiyoruz.
        sumDelegate(10, 5);
        subtractDelegate(10, 5);
    }
}