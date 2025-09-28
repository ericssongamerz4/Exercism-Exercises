
public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    private static void checkCurrency(CurrencyAmount firstAmount, CurrencyAmount secondAmount)
    {
        if (firstAmount.currency != secondAmount.currency)
            throw new ArgumentException($"Invalid currencies {firstAmount.currency} , {secondAmount.currency}");
    }

    #region Equality
    public static bool operator ==(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
    {
        checkCurrency(firstAmount, SecondAmount);
        return firstAmount.amount == SecondAmount.amount;
    }
    public static bool operator !=(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
    {
        checkCurrency(firstAmount, SecondAmount);
        return firstAmount.amount != SecondAmount.amount;
    }
    #endregion

    #region Comparison
    public static bool operator <(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
    {
        checkCurrency(firstAmount, SecondAmount);
        return firstAmount.amount < SecondAmount.amount;
    }
    public static bool operator >(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
    {
        checkCurrency(firstAmount, SecondAmount);
        return firstAmount.amount > SecondAmount.amount;
    }
    #endregion

    #region Arithmetic
    public static CurrencyAmount operator +(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
    {
        checkCurrency(firstAmount, SecondAmount);
        return new CurrencyAmount(firstAmount.amount + SecondAmount.amount, firstAmount.currency);
    }
    public static CurrencyAmount operator -(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
    {
        checkCurrency(firstAmount, SecondAmount);
        return new CurrencyAmount(firstAmount.amount - SecondAmount.amount, firstAmount.currency);
    }
    public static CurrencyAmount operator *(CurrencyAmount firstAmount, decimal amount) => new CurrencyAmount(firstAmount.amount * amount, firstAmount.currency);
    public static CurrencyAmount operator /(CurrencyAmount firstAmount, decimal amount) => new CurrencyAmount(firstAmount.amount / amount, firstAmount.currency);
    #endregion

    #region Type Conversion
    public static explicit operator double(CurrencyAmount firstAmount) => (double)firstAmount.amount;
    public static implicit operator decimal(CurrencyAmount firstAmount) => firstAmount.amount;
    #endregion
}