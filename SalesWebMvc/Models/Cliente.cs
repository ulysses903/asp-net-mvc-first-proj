using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid phone number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        public ICollection<HistoricoDeVendas> Venda { get; set; }

        public Cliente()
        {
        }

        public Cliente(int id, string name, string phoneNumber, DateTime birthDate)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }

        public void AddVenda(HistoricoDeVendas venda)
        {
            Venda.Add(venda);
        }

        public void RemoveVenda(HistoricoDeVendas venda)
        {
            Venda.Remove(venda);
        }
    }
}
