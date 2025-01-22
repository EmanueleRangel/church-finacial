using ChurchFinanceSystem.Models;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Repositories
{
    public interface ICongregationRepository
    {
        IEnumerable<Congregation> GetAll();
        Congregation GetById(int id);
        void Add(Congregation congregation);
        void Update(Congregation congregation);
        void Delete(int id);
    }
}
