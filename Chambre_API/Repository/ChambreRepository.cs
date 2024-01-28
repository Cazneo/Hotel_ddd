using Chambre_API.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chambre_API.Repository
{
    public class ChambreRepository : IChambreRepository
    {
        private readonly ChambreContext _context;

        public ChambreRepository(ChambreContext context)
        {
            _context = context;
        }

        public async Task Add(Chambre chambre)
        {
            _context.Chambres.Add(chambre);
            await _context.SaveChangesAsync();
        }

        public async Task<Chambre> GetById(int id)
        {
            return await _context.Chambres
                .Include(c => c.TypeChambre)
                    .ThenInclude(t => t.Equipements)
                .FirstOrDefaultAsync(c => c.ChambreID == id);
        }

        public async Task<List<Chambre>> GetAll()
        {
            return await _context.Chambres
                .Include(c => c.TypeChambre)
                    .ThenInclude(t => t.Equipements)
                .ToListAsync();
        }


        public async Task Update(Chambre chambre)
        {
            _context.Entry(chambre).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var chambre = await _context.Chambres.FindAsync(id);
            if (chambre != null)
            {
                _context.Chambres.Remove(chambre);
                await _context.SaveChangesAsync();
            }
        }
    }
}
