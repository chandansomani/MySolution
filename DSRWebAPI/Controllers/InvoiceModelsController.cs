using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DSRWebAPI.Data;
using DSRWebAPI.Models;

namespace DSRWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceModelsController : ControllerBase
    {
        private readonly DSRWebAPIContext _context;

        public InvoiceModelsController(DSRWebAPIContext context)
        {
            _context = context;
        }

        // GET: api/InvoiceModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceModel>>> GetInvoiceModel()
        {
          if (_context.InvoiceModel == null)
          {
              return NotFound();
          }
            return await _context.InvoiceModel.ToListAsync();
        }

        // GET: api/InvoiceModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceModel>> GetInvoiceModel(int id)
        {
          if (_context.InvoiceModel == null)
          {
              return NotFound();
          }
            var invoiceModel = await _context.InvoiceModel.FindAsync(id);

            if (invoiceModel == null)
            {
                return NotFound();
            }

            return invoiceModel;
        }

        // PUT: api/InvoiceModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoiceModel(int id, InvoiceModel invoiceModel)
        {
            if (id != invoiceModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoiceModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/InvoiceModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InvoiceModel>> PostInvoiceModel(InvoiceModel invoiceModel)
        {
          if (_context.InvoiceModel == null)
          {
              return Problem("Entity set 'DSRWebAPIContext.InvoiceModel'  is null.");
          }
            _context.InvoiceModel.Add(invoiceModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoiceModel", new { id = invoiceModel.Id }, invoiceModel);
        }

        // DELETE: api/InvoiceModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoiceModel(int id)
        {
            if (_context.InvoiceModel == null)
            {
                return NotFound();
            }
            var invoiceModel = await _context.InvoiceModel.FindAsync(id);
            if (invoiceModel == null)
            {
                return NotFound();
            }

            _context.InvoiceModel.Remove(invoiceModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoiceModelExists(int id)
        {
            return (_context.InvoiceModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
