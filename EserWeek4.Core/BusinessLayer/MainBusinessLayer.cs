using EserWeek4.Core.Entities;
using EserWeek4.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserWeek4.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositrySpese speseRepo;
       
        public MainBusinessLayer(IRepositrySpese spese)
        {
            speseRepo = spese;
        }
        public bool AggiungiSpesa(Spesa s)
        {
            throw new NotImplementedException();
        }

        public bool EliminaSpesa(int id)
        {
            throw new NotImplementedException();
        }

        public List<Spesa> GetAllSpese()
        {
            throw new NotImplementedException();
        }

        public bool ModificaSpesa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
