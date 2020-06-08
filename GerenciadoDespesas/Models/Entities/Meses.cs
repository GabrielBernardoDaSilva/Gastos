using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadoDespesas.Models.Entities
{
    public class Meses
    {
        public int MesId { get; set; }
        [Required(ErrorMessage ="Campo Obrigatorio")]
        public string Nome { get; set; }
        public ICollection<Despesas> Despesas{ get; set; }
        [Required(ErrorMessage ="Caampo obrigatorio")]
        public Salario Salario { get; set; }

    }
}
