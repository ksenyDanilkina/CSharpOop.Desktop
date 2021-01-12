using System;

public class TemperatureConverter
{

    private static Func<double, double> GetMethodForConvert(string fromScale, string toScale)
    {
        if (fromScale == "Цельсий")
        {
            if (toScale == "Кельвин")
            {
                return x => x + 273;
            }

            if (toScale == "Фаренгейт")
            {
                return x => x * 1.8 + 32;
            }

            return x => x;
        }

        if (fromScale == "Фаренгейт")
        {
            if (toScale == "Кельвин")
            {
                return x => (x - 32) * 5 / 9 + 273.15;
            }

            if (toScale == "Цельсий")
            {
                return x => (x - 32) * 5 / 9;
            }

            return x => x;
        }

        if (toScale == "Фаренгейт")
        {
            return x => (x - 273.15) * 9 / 5 + 32; ;
        }

        if (toScale == "Цельсий")
        {
            return x => x - 273; ;
        }

        return x => x;

    }
    public double Convert(string fromScale, string toScale, double value)
    {
        var methodForConvert = GetMethodForConvert(fromScale, toScale);

        return methodForConvert(value);
    }

}
