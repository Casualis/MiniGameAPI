using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameAPIBase.Extensions
{
    public static class StringExtentions
    {
        /// <summary>
        /// Проверка на пустую строку. Здесь можно добавит проверку на невалидные символы.
        /// </summary>
        public static bool IsEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }
    }
}
