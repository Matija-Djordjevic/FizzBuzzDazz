using System.Text;

namespace FizzBuzzEnterprizz.Extensions
{
    public static class StringBuilderExtensions
    {
        public static StringBuilder? NullIfEmpty(this StringBuilder sb) => sb.Equals(string.Empty) ? null : sb;
    }
}
