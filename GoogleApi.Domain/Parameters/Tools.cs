using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Domain.Parameters
{
    public static class Tools
    {
        public static string messageError { get; set; }
        public static async Task ForEachAsync<T>(this IEnumerable<T> enumerable, Func<T, Task> action)
        {
            await ForEachAsync<T>(enumerable, action, true);
        }
        public static async Task ForEachAsync<T>(this IEnumerable<T> enumerable, Func<T, Task> action, bool boll = true)
        {
            foreach (var item in enumerable)
            {
                if (boll == true)
                {
                    await action(item);
                }
                else
                {
                    break;
                }

            }
        }
    }
}
