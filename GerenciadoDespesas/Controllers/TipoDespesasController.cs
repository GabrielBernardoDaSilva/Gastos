﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadoDespesas.Models.Data;
using GerenciadoDespesas.Models.Entities;

namespace GerenciadoDespesas.Controllers
{
    public class TipoDespesasController : Controller
    {
        private readonly Context _context;

        public TipoDespesasController(Context context)
        {
            _context = context;
        }

        // GET: TipoDespesas
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoDespesas.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string txtProcurar)
        {
            if (!string.IsNullOrEmpty(txtProcurar))
                return View(await _context.TipoDespesas.Where(td => td.Nome.ToUpper() == txtProcurar.ToUpper()).ToListAsync());
            return View(await _context.TipoDespesas.ToListAsync());
        }


        public async Task<JsonResult> TipoDespesaExiste(string Nome)
        {
            if (await _context.TipoDespesas.AnyAsync(td => td.Nome.ToUpper() == Nome.ToUpper()))
                return Json("Esse tipo de despesa já existe !");

            return Json(true);
        }

        public async Task<JsonResult> AdcionarTipoDespesa(string txtDespesa)
        {
            if (!string.IsNullOrEmpty(txtDespesa))
            {
                if (!await _context.TipoDespesas.AnyAsync(tp => tp.Nome.ToUpper() == txtDespesa.ToUpper()))
                {
                    TipoDespesas tipoDespesas = new TipoDespesas()
                    {
                        Nome = txtDespesa
                    };
                    await _context.TipoDespesas.AddAsync(tipoDespesas);
                    await _context.SaveChangesAsync();
                    return Json(true);
                }
                
            }

            return Json(false);
            
        }

        // GET: TipoDespesas/Details/5

        // GET: TipoDespesas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoDespesas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoDespesasID,Nome")] TipoDespesas tipoDespesas)
        {
            if (ModelState.IsValid)
            {
                TempData["Confirmacao"] = $"{tipoDespesas.Nome} cadastrado com sucesso!";
                _context.Add(tipoDespesas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDespesas);
        }

        // GET: TipoDespesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDespesas = await _context.TipoDespesas.FindAsync(id);
            if (tipoDespesas == null)
            {
                return NotFound();
            }
            return View(tipoDespesas);
        }

        // POST: TipoDespesas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoDespesasID,Nome")] TipoDespesas tipoDespesas)
        {
            if (id != tipoDespesas.TipoDespesasID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    TempData["Confirmacao"] = $"{tipoDespesas.Nome} atualizado com sucesso!";
                    _context.Update(tipoDespesas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDespesasExists(tipoDespesas.TipoDespesasID))
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
            return View(tipoDespesas);
        }


        // POST: TipoDespesas/Delete/5
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            
            var tipoDespesas = await _context.TipoDespesas.FindAsync(id);
            TempData["Confirmacao"] = $"{tipoDespesas.Nome} excluido com sucesso!";
            _context.TipoDespesas.Remove(tipoDespesas);
            await _context.SaveChangesAsync();
            return Json($"{tipoDespesas.Nome} excluido com sucesso");
        }



        private bool TipoDespesasExists(int id)
        {
            return _context.TipoDespesas.Any(e => e.TipoDespesasID == id);
        }
    }
}
