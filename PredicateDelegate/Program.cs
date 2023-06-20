internal class Program
{
    //Girilen parametreye göre bir kişinin yaşının genç olup olmadığını kontrol eden bir metot yazıyoruz.
    public static bool IsTeenger(int age) 
    {
        if (15 < age && age <25)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private static void Main(string[] args)
    {
        //Yazdığımız metotu delagete'imize yüklüyoruz.
        Predicate<int> predicate = IsTeenger;

        //Delegate'imizi çağırıyoruz.
        Console.WriteLine(predicate(23));
    }
}