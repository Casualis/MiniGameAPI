using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGameAPIBase.Extensions
{
    public static class RandomExtentions
    {
        /// <summary>
        /// Расширение. Получаем интервал первого и последнего индекса из заданного диапозона.
        /// </summary>
        public static (int first, int last) GetRandomInterval(this Random rnd, int maxLenth)
        {
            int index1 = rnd.Next(0, maxLenth - 1);
            int index2 = rnd.Next(0, maxLenth - 1);

            return index1 < index2 ? (index1, index2) : (index2, index1);
        }
    }
}
