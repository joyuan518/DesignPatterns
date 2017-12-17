namespace DesignPatterns.TemplateMethod
{
    using System.Text;

    public static class StringExtension
    {
        public static string Range(this string element, int count)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(element);
            }

            return sb.ToString();
        }
    }
}