public class KkbSorguServisi
{
    public void GetCrsCorporatePackages(string sorguTuru, int sorguId, int modulId)
    {
        var sorgu = CrsCorporatePackgesFactory.CreateCrsCorporateTemplate(sorguTuru);
        sorgu.GetCrsCorporatePackages(sorguId, modulId);
    }
}
