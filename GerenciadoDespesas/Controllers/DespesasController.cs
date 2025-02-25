﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadoDespesas.Models.Data;
using GerenciadoDespesas.Models.Entities;
using X.PagedList;
using GerenciadoDespesas.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GerenciadoDespesas.Controllers
{
    public class DespesasController : Controller
    {
        private readonly Context _context;

        public DespesasController(Context context)
        {
            _context = context;
        }

        // GET: Despesas
        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPagina = 10;
            int numeroPagina = pagina ?? 1;

            ViewData["Meses"] = new SelectList(_context.Meses.Where(x => x.MesId == x.Salario.MesId), "MesId", "Nome");

            var context = _context.Despesas.Include(d => d.Meses).Include(d => d.TipoDespesas).OrderBy(x => x.Meses.MesId);
            return View(await context.ToPagedListAsync(numeroPagina,itensPagina));
        }


        // GET: Despesas/Create
        public IActionResult Create()
        {
            ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome");
            ViewData["TipoDespesaId"] = new SelectList(_context.TipoDespesas, "TipoDespesasID", "Nome");
            return View();
        }

        // POST: Despesas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DepesasId,MesId,TipoDespesaId,Valor")] Despesas despesas)
        {
            if (ModelState.IsValid)
            {
                TempData["Confirmacao"] = " Despesa Cadastrada com sucesso!";
                _context.Add(despesas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome", despesas.MesId);
            ViewData["TipoDespesaId"] = new SelectList(_context.TipoDespesas, "TipoDespesasID", "Nome", despesas.TipoDespesaId);
            return View(despesas);
        }

        // GET: Despesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var despesas = await _context.Despesas.FindAsync(id);
            if (despesas == null)
            {
                return NotFound();
            }
            ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome", despesas.MesId);
            ViewData["TipoDespesaId"] = new SelectList(_context.TipoDespesas, "TipoDespesasID", "Nome", despesas.TipoDespesaId);
            return View(despesas);
        }

        // POST: Despesas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DepesasId,MesId,TipoDespesaId,Valor")] Despesas despesas)
        {
            if (id != despesas.DepesasId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    TempData["Confirmacao"] = " Despesa atualizada com sucesso!";
                    _context.Update(despesas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DespesasExists(despesas.DepesasId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MesId"] = new SelectList(_context.Meses, "MesId", "Nome", despesas.MesId);
            ViewData["TipoDespesaId"] = new SelectList(_context.TipoDespesas, "TipoDespesasID", "Nome", despesas.TipoDespesaId);
            return View(despesas);
        }

        // POST: Despesas/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var despesas = await _context.Despesas.FindAsync(id);
            _context.Despesas.Remove(despesas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async Task<JsonResult> GastosTotalMes(int mesId)
        {
            GastosTotaisMesViewModel gastosTotais = new GastosTotaisMesViewModel()
            {
                ValorTotalGasto = await _context.Despesas.Where(d => d.Meses.MesId == mesId).Select(d => d.Valor).SumAsync(),
                Salario =await _context.Salarios.Where(s => s.Meses.MesId == mesId).Select(s => s.Valor).FirstOrDefaultAsync()

            };
            return Json(gastosTotais);
            
        }

        public JsonResult GastoMes(int mesId)
        {
            var query = from despesas in _context.Despesas
                        where despesas.Meses.MesId == mesId
                        group despesas by despesas.TipoDespesas.Nome into g
                        select new
                        {
                            TiposDespesas = g.Key,
                            Valores = g.Sum(d => d.Valor)
                        };

            return Json(query);
        }

        public JsonResult GastosTotais()
        {
            var query = _context.Despesas
                .OrderBy(m => m.Meses.MesId)
                .GroupBy(m => m.Meses.MesId)
                .Select(d => new { NomeMeses = d.Select(x => x.Meses.Nome).Distinct(), Valores = d.Sum(x => x.Valor) });

            return Json(query);
        }
        private bool DespesasExists(int id)
        {
            return _context.Despesas.Any(e => e.DepesasId == id);
        }
    }
}
