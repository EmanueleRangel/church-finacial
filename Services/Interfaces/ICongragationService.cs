using ChurchFinanceSystem.Models;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public interface ICongregationService
    {
        IEnumerable<Congregation> GetAllCongregations();
        Congregation GetCongregationById(int id);
        void CreateCongregation(Congregation congregation);
        void UpdateCongregation(Congregation congregation);
        void DeleteCongregation(int id);
    }
}
