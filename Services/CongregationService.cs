using ChurchFinanceSystem.Models;
using ChurchFinanceSystem.Repositories;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public class CongregationService : ICongregationService
    {
        private readonly ICongregationRepository _congregationRepository;

        public CongregationService(ICongregationRepository congregationRepository)
        {
            _congregationRepository = congregationRepository;
        }

        public IEnumerable<Congregation> GetAllCongregations()
        {
            return _congregationRepository.GetAll();
        }

        public Congregation GetCongregationById(int id)
        {
            return _congregationRepository.GetById(id);
        }

        public void CreateCongregation(Congregation congregation)
        {
            _congregationRepository.Add(congregation);
        }

        public void UpdateCongregation(Congregation congregation)
        {
            _congregationRepository.Update(congregation);
        }

        public void DeleteCongregation(int id)
        {
            _congregationRepository.Delete(id);
        }
    }
}
