using ChurchFinanceSystem.Models;
using ChurchFinanceSystem.Repositories;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        // Injeção de dependência para o repositório de User
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Retorna todos os usuários
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        // Retorna um usuário por ID
        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        // Cria um novo usuário
        public void CreateUser(User user)
        {
            // Aqui, você poderia adicionar validações ou regras de negócio,
            // como verificar se o e-mail já existe ou se a senha é forte o suficiente.
            _userRepository.Add(user);
        }

        // Atualiza um usuário existente
        public void UpdateUser(User user)
        {
            // Você poderia adicionar validações de alteração de dados
            _userRepository.Update(user);
        }

        // Deleta um usuário por ID
        public void DeleteUser(int id)
        {
            // Talvez aqui você queira fazer verificações, como garantir que o usuário existe antes de deletar
            _userRepository.Delete(id);
        }
    }
}
