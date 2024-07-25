using Ventas.Data.Entities;
using Ventas.Data.Interfaces.Repositories;

namespace Ventas.Data.Services
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task AddCliente(Cliente cliente)
        {
            await _clienteRepository.Add(cliente);
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            return await _clienteRepository.GetById(id);
        }

        public async Task<List<Cliente>> GetAllClientes()
        {
            return await _clienteRepository.GetAll();
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            await _clienteRepository.Update(cliente);
        }

        public async Task DeleteCliente(Cliente cliente)
        {
            await _clienteRepository.Remove(cliente);
        }
    }
}
