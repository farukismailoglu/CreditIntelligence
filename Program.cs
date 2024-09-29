public class Program
{
    public static void Main()
    {
        var kkbServisi = new KkbSorguServisi();
        kkbServisi.GetCrsCorporatePackages("Tahsis", 123, 1);
        kkbServisi.GetCrsCorporatePackages("Rating", 456, 2);
    }
}
