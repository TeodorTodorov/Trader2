using System;


static class Rounders

{
    public static double RoundTedo(double d)
    {
        var absoluteValue = Math.Abs(d);
        var integralPart = (long)absoluteValue;
        var decimalPart = absoluteValue - integralPart;
        var sign = Math.Sign(d);

        double roundedNumber;
        if (decimalPart > 0.0 && decimalPart < 0.25)
        {
            roundedNumber = integralPart;
        }
        else if (decimalPart >= 0.25 && decimalPart <= 0.5)
        {
            roundedNumber = integralPart + 0.5;
        }
        else if (decimalPart > 0.5 && decimalPart < 0.75)
        {
            roundedNumber = integralPart + 0.5;
        }
        else if (decimalPart > 0.5 && decimalPart >= 0.75)
        {
            roundedNumber = integralPart + 1.0;
        }


        else if (decimalPart == 0)
        {
            roundedNumber = absoluteValue;
        }
        else
        {
            roundedNumber = integralPart + 0.5;
        }

        return sign * roundedNumber;
    }
    public static double RoundTedoEtherium(double d)
    {
        d = d * 10;
        var absoluteValue = Math.Abs(d);
        var integralPart = (long)absoluteValue;
        var decimalPart = absoluteValue - integralPart;
        var sign = Math.Sign(d);

        double roundedNumber;
        if (decimalPart > 0.0 && decimalPart < 0.25)
        {
            roundedNumber = integralPart;
        }
        else if (decimalPart >= 0.25 && decimalPart <= 0.5)
        {
            roundedNumber = integralPart + 0.5;
        }
        else if (decimalPart > 0.5 && decimalPart < 0.75)
        {
            roundedNumber = integralPart + 0.5;
        }
        else if (decimalPart > 0.5 && decimalPart >= 0.75)
        {
            roundedNumber = integralPart + 1.0;
        }

        else if (decimalPart == 0)
        {
            roundedNumber = absoluteValue;
        }
        else
        {
            roundedNumber = integralPart + 0.5;
        }

        return sign * (roundedNumber / 10);
    }
}

