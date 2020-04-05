using System.Collections.Generic;

namespace ConsumirAPIs.Models
{
    public class DistritosIBGE
    {
        public class Distritos
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<Municipio> Municipio { get; set; }
        }

        public class Municipio
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<Microregiao> Microrregiao { get; set; }

        }

        public class Microregiao
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<Mesorregiao> Mesorregiao { get; set; }

        }

        public class Mesorregiao
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string UF { get; set; }

        }
    }
}