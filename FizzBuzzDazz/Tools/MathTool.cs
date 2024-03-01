using System.Numerics;

namespace FizzBuzzDazz.Tools
{
    public abstract class MathTool
    {
        private static readonly string _valuesArgEmpty = "values argument must not be empty";
        public static T GetGCD<T>(T a, T b) where T : INumber<T>
            => b == T.Zero ? a : GetGCD(b, a % b);

        public static T GetLCD<T>(T a, T b) where T : INumber<T>
            => (a * b) / GetGCD(a, b);

        public static T GetLCD<T>(IEnumerable<T> values) where T : INumber<T> =>
            values.ToList() switch
            {
                List<T> lValues when lValues.Count == 0 => throw new ArgumentException(_valuesArgEmpty),
                List<T> lValues => lValues.Aggregate(values.FirstOrDefault() ?? T.Zero, GetGCD)
            };
    }
}
