public abstract class CrsCorporateTemplate
{
    // Template method: Sürecin iskeletini tanımlar
    public List<CrsCorporatePackage> GetCrsCorporatePackages(int sorguId, int modulId)
    {
        List<CrsCorporatePackage> crsCorporatePackges = new List<CrsCorporatePackage>();

        DeterminaServiceCallType(sorguId, modulId);

        List<int> parties = new List<int>();
        foreach (var party in parties)
        {
            var crsCorporateParameterPackage = GetCrsCorporateParameterPackage();
            var crsCorporatePackge = GetCrsCorporatePackage(crsCorporateParameterPackage);

            crsCorporatePackges.Add(crsCorporatePackge);
        }

        // LogSorguBitisi(sorguId, modulId);

        return crsCorporatePackges;
    }

    protected abstract CrsCorporateParameterPackage GetCrsCorporateParameterPackage();

    protected abstract void DeterminaServiceCallType(int sorguId, int modulId);

    // Bu kısım ortak olacak
    protected CrsCorporatePackage GetCrsCorporatePackage(CrsCorporateParameterPackage crsCorporateParameterPackge)
    {
        List<DateTime> periods = new List<DateTime>();

        return new CrsCorporatePackage()
        {

        };
    }

    protected abstract List<DateTime> GetCurrentPeriods();
    
    protected virtual void KaydetSonuc(int sorguId, int modulId, string sonuc)
    {
        Console.WriteLine($"Sonuç Kaydedildi. Sorgu ID: {sorguId}, Modül ID: {modulId}, Sonuç: {sonuc}");
    }

    protected virtual void LogSorguBitisi(int sorguId, int modulId)
    {
        Console.WriteLine($"Sorgu Bitti. Sorgu ID: {sorguId}, Modül ID: {modulId}");
    }
}
