using ChurchFinanceSystem.Data;
using ChurchFinanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ChurchFinanceSystem.Repositories
{
    public class UserRepository(ApplicationDbContext context) : IUserRepository
    {
        private readonly ApplicationDbContext _context = context;

        public UserRepository()
        {
        }

        // Retorna todos os usuários
        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        // Retorna um usuário por ID
        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        // Adiciona um novo usuário
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges(); // Salva as mudanças no banco de dados
        }

        // Atualiza um usuário existente
        public void Update(User user)
        {
            _context.Users.Update(user);  // Marca o usuário para atualização
            _context.SaveChanges(); // Salva as mudanças no banco de dados
        }

        // Deleta um usuário por ID
        public void Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges(); // Salva as mudanças no banco de dados
            }
        }
    }

    internal class ApplicationDbContext
    {
    }
}
