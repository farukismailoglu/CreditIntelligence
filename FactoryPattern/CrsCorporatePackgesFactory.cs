public static class CrsCorporatePackgesFactory
{
    public static CrsCorporateTemplate CreateCrsCorporateTemplate(string sorguTuru)
    {
        return sorguTuru switch
        {
            "Tahsis" => new CreditUnderwritingCrsCorporate(),
            "Rating" => new RatingCrsCorporate(),
            _ => throw new ArgumentException("Geçersiz sorgu türü")
        };
    }
}
