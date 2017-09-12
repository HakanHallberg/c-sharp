namespace MultiplierLib
{
    public class PurchaseCalculation
    {
        public decimal Execute(int qty, decimal amount, bool withVat)
        {
            if (withVat)
                return qty * amount * 1.25M;
            else
                return qty * amount;
        }
    }
}
