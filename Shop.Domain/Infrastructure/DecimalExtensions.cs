namespace MotoShop.Domain.Infrastructure
{
    public static class DecimalExtensions
    {
        public static string GetValueString(this decimal value) =>
            $" {value.ToString("N2")} zł";
    }
}
