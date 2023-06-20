internal class Program
{
    //Geriye int tipinde değer dönen iki parametreli bir metot tanımlıyoruz.
    public static int Sum(int x, int y)
    {
        return x + y;
    }
    private static void Main(string[] args)
    {
        //İki adet int tipinde parametre alan ve geriye int tipinde değer döndüren (Func delegate'inindeki son parametre çıkış parametresidir.) delegate'imize Sum metodunu yüklüyoruz.
        Func<int, int, int> func = Sum;

        //Delegate'imizi çağırıyoruz.
        int result = func(10, 5);
        Console.WriteLine("Toplam: {0}",result);
    }
}