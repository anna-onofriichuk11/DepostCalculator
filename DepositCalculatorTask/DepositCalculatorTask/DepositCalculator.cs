using System;
using System.Collections.Generic;
using System.Text;

namespace DepositCalculatorTask
{
    public class DepositCalculator
    {
        private decimal _startSum;

        private int _amountOfMonth;

        private const double _depositPercent = 0.15;

        public DepositCalculator(string startsum, string amountOfMonth)
        {
            decimal sum;
            if (!Decimal.TryParse(startsum, out sum) || sum <= 0)
                throw new ArgumentException("Start sum value is invalid");
            _startSum = sum;
            int period;
            if (!Int32.TryParse(amountOfMonth, out period))
                throw new ArgumentException("Amount of month value is not a number");
            if (period <= 0)
                throw new ArgumentException("Amount of month value cannot be less or equal 0");
            _amountOfMonth = period;
         
        }

        public decimal StartSum {
            get => _startSum;
            set => value = _startSum;
        }

        public int AmountOfMonth
        {
            get => _amountOfMonth;
            set => value = _amountOfMonth;
        }

        public decimal CalculateDepositCapitalization()
        {
            return StartSum * (decimal)Math.Pow((1 + _depositPercent / 12), AmountOfMonth);
        }

        public decimal CalculateDepositMonthPayout()
        {
            return StartSum * (decimal)(1 + _depositPercent * AmountOfMonth / 12);
        }

    }
}
