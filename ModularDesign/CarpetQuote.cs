using System;

namespace ModularDesign
{
    public class CarpetQuote
    {
        private readonly double _roomLength;
        private readonly double _roomWidth;
        private readonly double _pricePerSqMtr;
        private readonly bool _roundUp;

        public CarpetQuote(double roomLength, double roomWidth, double pricePerSqMtr, bool roundUp)
        {
            _roomLength = roomLength;
            _roomWidth = roomWidth;
            _pricePerSqMtr = pricePerSqMtr;
            _roundUp = roundUp;
        }
        
        public double FittedPrice()
        {
            double area = _roomLength * _roomWidth;

            if (_roundUp)
                area = Math.Ceiling(area);
            
            return area * _pricePerSqMtr;
        }
    }
}