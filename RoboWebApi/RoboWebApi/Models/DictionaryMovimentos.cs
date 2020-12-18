using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public static class DictionaryMovimentos
    {
        public static Dictionary<int, string> MovCotovelo = new Dictionary<int, string>()
        {
            {1,"Em Repouso"},
            {2,"Levemente Contraído"},
            {3,"Contraído"},
            {4,"Fortemente Contraído" }
        };

        public static Dictionary<int, string> MovPulso = new Dictionary<int, string>()
        {
            {1,"Rotação em -90º"},
            {2,"Rotação em -45º"},
            {3,"Em Repouso"},
            {4,"Rotação em 45º"},
            {5,"Rotação em 90º"},
            {6,"Rotação para 135º"},
            {7,"Rotação para 180º"}
        };

        public static Dictionary<int, string> MovRotacao = new Dictionary<int, string>()
        {
            {1,"Rotação -90º"},
            {2,"Rotação -45º"},
            {3,"Em Repouso"},
            {4,"Rotação 45º"},
            {5,"Rotação 90º"}
        };

        public static Dictionary<int, string> MovInclinacao = new Dictionary<int, string>()
        {
            {1,"Para Cima"},
            {2,"Em Repouso"},
            {3,"Para Baixo"}
        };

        
    }
}
