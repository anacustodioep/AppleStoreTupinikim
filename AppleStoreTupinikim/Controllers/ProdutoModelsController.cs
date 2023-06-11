using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppleStoreTupinikim.Data;
using AppleStoreTupinikim.Models;

namespace AppleStoreTupinikim.Controllers
{
    public class ProdutoModelsController : Controller
    {
        private readonly Context _context;

        public ProdutoModelsController(Context context)
        {
            _context = context;
        }

        // GET: ProdutoModels
        public async Task<IActionResult> Index()
        {
              return _context.Produto != null ? 
                          View(await _context.Produto.ToListAsync()) :
                          Problem("Entity set 'Context.Produto'  is null.");
        }

        // GET: ProdutoModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.Produto
                .FirstOrDefaultAsync(m => m.Nome == id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            return View(produtoModel);
        }

        // GET: ProdutoModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProdutoModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Valor,Estoque")] ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtoModel);
        }

        // GET: ProdutoModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.Produto.FindAsync(id);
            if (produtoModel == null)
            {
                return NotFound();
            }
            return View(produtoModel);
        }

        // POST: ProdutoModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Nome,Valor,Estoque")] ProdutoModel produtoModel)
        {
            if (id != produtoModel.Nome)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoModelExists(produtoModel.Nome))
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
            return View(produtoModel);
        }

        // GET: ProdutoModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Produto == null)
            {
                return NotFound();
            }

            var produtoModel = await _context.Produto
                .FirstOrDefaultAsync(m => m.Nome == id);
            if (produtoModel == null)
            {
                return NotFound();
            }

            return View(produtoModel);
        }

        // POST: ProdutoModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Produto == null)
            {
                return Problem("Entity set 'Context.Produto'  is null.");
            }
            var produtoModel = await _context.Produto.FindAsync(id);
            if (produtoModel != null)
            {
                _context.Produto.Remove(produtoModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoModelExists(string id)
        {
          return (_context.Produto?.Any(e => e.Nome == id)).GetValueOrDefault();
        }
    }
}
