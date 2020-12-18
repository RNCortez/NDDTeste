using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Util
{
    public static class Utils
    {
        public static int ValueRepouso(Dictionary<int, string> dictionary)
        {
            int keyRetorno = -1;
            foreach (var item in dictionary)
            {
                if (item.Value.Equals("Em Repouso"))
                {
                    keyRetorno = item.Key;
                }
            }
            return keyRetorno;
        }

        public static int ValueMovimento(Dictionary<int, string> dictionary, string movimento)
        {
            int keyRetorno = -1;
            foreach (var item in dictionary)
            {
                if (item.Value.Equals(movimento))
                {
                    keyRetorno = item.Key;
                }
            }
            return keyRetorno;
        }
    }
}
