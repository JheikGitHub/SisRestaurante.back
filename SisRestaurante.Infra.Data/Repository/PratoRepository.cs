using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SisRestaurante.Domain.Entities;
using SisRestaurante.Domain.Interfaces;
using SisRestaurante.Infra.Data.Context;

namespace SisRestaurante.Infra.Data.Repository
{
    public class PratoRepository : IPratoRepository
    {
        private DataContext _context;

        public PratoRepository(DataContext context)
        {
            _context = context;
        }
        public void Create(Prato prato)
        {
            _context.Pratos.Add(prato);
            _context.SaveChanges();
        }

        public void Delete(Prato prato)
        {
            _context.Pratos.Remove(prato);
            _context.SaveChanges();
        }

        public IEnumerable<Prato> GetAll()
        {
            return _context.Pratos.ToList();
        }

        public Prato GetOne(int id)
        {
            return _context.Pratos.Find(id);
        }

        public void Update(Prato prato)
        {
            _context.Entry(prato).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
