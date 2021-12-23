using EserWeek4.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserWeek4.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        public List<Spesa> GetAllSpese();
        public bool AggiungiSpesa(Spesa s);
        public bool ModificaSpesa(int id);
        public bool EliminaSpesa(int id);
    }
}
