using System.Globalization;

namespace Kasir_ExampleApp.Helpers
{
    public static class CurrencyHelper
    {
        // Extension method untuk tipe desimal
        public static string ToRupiah(this decimal nominal)
        {
            return nominal.ToString("N2", new CultureInfo("id-ID"));
        }

        // Extension method untuk tipe integer
        public static string ToRupiah(this int nominal)
        {
            return nominal.ToString("N2", new CultureInfo("id-ID"));
        }
    }
}