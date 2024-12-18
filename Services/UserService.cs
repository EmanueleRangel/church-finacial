using ChurchFinanceSystem.Models;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public interface IUserService
    {
        // Retorna todos os usuários
        IEnumerable<User> GetAllUsers();

        // Retorna um usuário por Id
        User GetUserById(int id);

        // Cria um novo usuário
        void CreateUser(User user);

        // Atualiza um usuário existente
        void UpdateUser(User user);

        // Deleta um usuário
        void DeleteUser(int id);
    }
}
