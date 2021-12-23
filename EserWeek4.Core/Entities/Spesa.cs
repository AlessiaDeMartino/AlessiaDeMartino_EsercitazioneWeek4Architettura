using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserWeek4.Core.Entities
{
//    • Id(int, PK, auto-incrementale)
//• Data(datetime)
//• CategoriaId(int, FK)
//• Descrizione(varchar(500))
//• Utente(varchar(100))
//• Importo(decimal)
//• Approvato(bit)

    public class Spesa
    {
        public int Id { get; set; }
        public DateTime DataSpesa { get; set; }
        public string Descrizione { get; set; }
        public decimal Importo { get; set; }
        public bool Approvato { get; set; }       
        public string Utente { get; set; }


        //FK
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public override string ToString()
        {
            return $"Id {Id}, Data: {DataSpesa.ToShortDateString()}, Descrizione: {Descrizione}, Importo: {Importo}, Approvato: {Approvato}";
        }
    }
}
