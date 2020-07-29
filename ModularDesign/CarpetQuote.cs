using System;

namespace ModularDesign
{
    public class CarpetQuote
    {
        public double FittedPrice(double roomLength, double roomWidth, double pricePerSqMtr, bool roundUp)
        {
            double area = roomLength * roomWidth;

            if (roundUp)
                area = Math.Ceiling(area);
            
            return area * pricePerSqMtr;
        }
    }
}