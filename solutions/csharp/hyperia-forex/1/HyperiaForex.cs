    public struct CurrencyAmount
    {
        private decimal amount;
        private string currency;

        public CurrencyAmount(decimal amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        // TODO: implement equality operators
        public static bool operator ==(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
        {
            if (firstAmount.currency != SecondAmount.currency)
                throw new ArgumentException();

            return firstAmount.amount == SecondAmount.amount;
        }
        public static bool operator !=(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
        {
            if (firstAmount.currency != SecondAmount.currency)
                throw new ArgumentException();

            return firstAmount.amount != SecondAmount.amount;
        }

        // TODO: implement comparison operators
        public static bool operator <(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
        {
            if (firstAmount.currency != SecondAmount.currency)
                throw new ArgumentException();

            return firstAmount.amount < SecondAmount.amount;
        }
        public static bool operator >(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
        {
            if (firstAmount.currency != SecondAmount.currency)
                throw new ArgumentException();

            return firstAmount.amount > SecondAmount.amount;
        }

        // TODO: implement arithmetic operators
        public static CurrencyAmount operator +(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
        {
            if (firstAmount.currency != SecondAmount.currency)
                throw new ArgumentException();

            return new CurrencyAmount(firstAmount.amount + SecondAmount.amount, firstAmount.currency);
        }
        public static CurrencyAmount operator -(CurrencyAmount firstAmount, CurrencyAmount SecondAmount)
        {
            if (firstAmount.currency != SecondAmount.currency)
                throw new ArgumentException();

            return new CurrencyAmount(firstAmount.amount - SecondAmount.amount, firstAmount.currency);
        }
        public static CurrencyAmount operator *(CurrencyAmount firstAmount, decimal amount)
        {
            return new CurrencyAmount(firstAmount.amount * amount, firstAmount.currency);
        }
        public static CurrencyAmount operator /(CurrencyAmount firstAmount, decimal amount)
        {
            return new CurrencyAmount(firstAmount.amount / amount, firstAmount.currency);
        }

        // TODO: implement type conversion operators

        public static explicit operator double(CurrencyAmount firstAmount)
        {
            return (double)firstAmount.amount;
        }

        public static implicit operator decimal (CurrencyAmount firstAmount)
        {
            return firstAmount.amount;
        }




        //static (explicit|implicit) operator <cast-to-type>(<cast-from-type> <parameter name>);



    }