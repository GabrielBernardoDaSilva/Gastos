using GerenciadoDespesas.Models.Data;
using GerenciadoDespesas.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadoDespesas.ViewComponents
{
    public class EstatisticasViewComponent : ViewComponent
    {
        private readonly Context _contexto;

        public EstatisticasViewComponent(Context contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            EstatisticasViewModel estatisticasViewModel = new EstatisticasViewModel()
            {
                MenorDespesa =await _contexto.Despesas.MinAsync(x => x.Valor),
                MaiorDespesa =await _contexto.Despesas.MaxAsync(x => x.Valor),
                QuantidadeDespesas =await _contexto.Despesas.CountAsync()

            };

            return View(estatisticasViewModel);

        }
    }
}
