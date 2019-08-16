using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class HistoricoDeVendas
    {
        public int Id { get; set; }
        public Procedimentos Procedimento { get; set; }
        public double Price { get; set; }

        public HistoricoDeVendas()
        {
        }

        public HistoricoDeVendas(int id, Procedimentos procedimento, double price)
        {
            Id = id;
            Procedimento = procedimento;
            Price = price;
        }
    }
}
