
public class CreditUnderwritingCrsCorporate : CrsCorporateTemplate
{
    protected override void DeterminaServiceCallType(int sorguId, int modulId)
    {
        throw new NotImplementedException();
    }

    protected override CrsCorporateParameterPackage GetCrsCorporateParameterPackage()
    {
        throw new NotImplementedException();
    }

    protected override List<DateTime> GetCurrentPeriods()
    {
        return new List<DateTime>();
    }
}