using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mef_mappers_synd
{
    public interface IMap
    {
        /// <summary>
        /// Take t1 inSchema and t2 outSchema?
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        void Map<T1, T2>(T1 t1, T2 t2);

        /// <summary>
        /// Map input (json,xml) to output based on schema names
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputSchema"></param>
        /// <param name="outputSchema"></param>
        /// <returns></returns>
        string Map(string input,string inputSchema,string outputSchema);
    }
}
