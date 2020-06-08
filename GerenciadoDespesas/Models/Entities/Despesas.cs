using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadoDespesas.Models.Entities
{
    public class Despesas
    {
        public int DepesasId { get; set; }
        public int MesId { get; set; }
        public Meses Meses { get; set; }
        public int TipoDespesaId { get; set; }
        public TipoDespesas TipoDespesas { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor invalido")]
        public double Valor { get; set; }
    }
}
