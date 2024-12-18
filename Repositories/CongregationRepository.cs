using ChurchFinanceSystem.Data;
using ChurchFinanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ChurchFinanceSystem.Repositories
{
    public class CongregationRepository : ICongregationRepository
    {
        private readonly ApplicationDbContext _context;

        public CongregationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Congregation> GetAll()
        {
            return _context.Congregations.ToList();
        }

        public Congregation GetById(int id)
        {
            return _context.Congregations.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Congregation congregation)
        {
            _context.Congregations.Add(congregation);
            _context.SaveChanges();
        }

        public void Update(Congregation congregation)
        {
            _context.Congregations.Update(congregation);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var congregation = _context.Congregations.FirstOrDefault(c => c.Id == id);
            if (congregation != null)
            {
                _context.Congregations.Remove(congregation);
                _context.SaveChanges();
            }
        }
    }
}
