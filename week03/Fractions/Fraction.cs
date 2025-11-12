using System;

namespace Fractions
{
    public class Fraction
    {
        private int _topNumber;
        private int _bottomNumber;

        public Fraction()
        {
            _topNumber = 1;
            _bottomNumber = 1;
        }

        public Fraction(int wholeNumber)
        {
            _topNumber = wholeNumber;
            _bottomNumber = 1;
        }

        public Fraction(int top, int bottom)
        {
            if (bottom == 0)
            {
                throw new ArgumentException("The bottom number cannot be zero.");
            }

            _topNumber = top;
            _bottomNumber = bottom;

        }


        public int GetTop()
        {
            return _topNumber;
        }

        public void SetTop(int top)
        {
            _topNumber = top;
        }

        public int GetBottom()
        {
            return _bottomNumber;
        }
        public void SetBottom(int bottom)
        {
            if (bottom == 0)
            {
                throw new ArgumentException("The bottom number cannot be zero.");
            }

            _bottomNumber = bottom;
        }



        public string GetFractionString()
        {
            return $"{_topNumber}/{_bottomNumber}";
        }

        public double GetDecimalValue()
        {
            return (double)_topNumber / _bottomNumber;
        }

    }
    
}