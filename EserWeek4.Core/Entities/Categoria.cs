using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserWeek4.Core.Entities
{
// Id(int, PK, auto-incrementale)
//• Categoria(varchar(100)
    public class Categoria
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }



        public List<Spesa> spese= new List<Spesa>();
    }
}
