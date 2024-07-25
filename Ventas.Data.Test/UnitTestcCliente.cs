using Moq;
using Ventas.Data.Entities;
using Ventas.Data.Interfaces.Repositories;
using Ventas.Data.Services;

namespace Ventas.Data.Test
{
    public class UnitTestcCliente
    {

        //AQUI VAN LOS TESTS

        [Fact]
        public async Task Test1 ()
        {
            // Arrange //

            var repository = new Mock<IClienteRepository> ();
            var service = new ClienteService(repository.Object);
            var cliente = new Cliente { IdCliente = 1, Nombre = "John Doe", Email = "john.doe@example.com",
                Direccion = " CancinoA", Telefono= "839933883" ,  FechaRegistro = new DateOnly(2024, 7, 8) };

            // Act //

            await service.AddCliente(cliente);

            // Assert // 

            repository.Verify(repo => repo.Add(It.Is<Cliente>(c => c.IdCliente == cliente.IdCliente && 
            c.Nombre == cliente.Nombre && c.Email == cliente.Email)), Times.Once);

        }

        [Fact]

        public async Task GetAllClientes_ShouldReturnListOfClientes()
        {
            // Arrange
            var repository = new Mock<IClienteRepository>();
            var clientesMock = new List<Cliente>
                {
                    new Cliente { IdCliente = 1, Nombre = "John Doe", Email = "john.doe@example.com",
                        FechaRegistro = new DateOnly(2024, 7, 8) },
                    new Cliente { IdCliente = 2, Nombre = "Jane Doe", Email = "jane.doe@example.com", 
                        FechaRegistro = new DateOnly(2024, 7, 8) }
                    };
            repository.Setup(repo => repo.GetAll()).ReturnsAsync(clientesMock);

            var clienteService = new ClienteService(repository.Object);

            // Act
            var result = await clienteService.GetAllClientes();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal(clientesMock[0].IdCliente, result[0].IdCliente);
            Assert.Equal(clientesMock[1].Nombre, result[1].Nombre);



            repository.Verify(repo => repo.GetAll(), Times.Once);
        }

        [Fact]
        public async Task GetClienteById_ShouldReturnCorrectCliente()
        {
            // Arrange
            var repository = new Mock<IClienteRepository>();
            var clienteMock = new Cliente { IdCliente = 1, Nombre = "John Doe", Email = "john.doe@example.com",
                FechaRegistro = new DateOnly(2024, 7, 8) };
            repository.Setup(repo => repo.GetById(It.IsAny<int>())).ReturnsAsync(clienteMock);

            var clienteService = new ClienteService(repository.Object);
            int clienteId = 1;

            // Act
            var result = await clienteService.GetClienteById(clienteId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(clienteMock.IdCliente, result.IdCliente);
            Assert.Equal(clienteMock.Nombre, result.Nombre);
         
            repository.Verify(repo => repo.GetById(clienteId), Times.Once);
        }

        [Fact]
        public async Task UpdateCliente_ShouldUpdateCliente()
        {
            // Arrange
            var repository = new Mock<IClienteRepository>();
            var clienteToUpdate = new Cliente { IdCliente = 1, Nombre = "John Doe", Email = "john.doe@example.com", FechaRegistro = new DateOnly(2024, 7, 8) };

            repository.Setup(repo => repo.Update(It.IsAny<Cliente>())).Returns(Task.CompletedTask);

            var clienteService = new ClienteService(repository.Object);

            // Act
            await clienteService.UpdateCliente(clienteToUpdate);

            // Assert
            repository.Verify(repo => repo.Update(clienteToUpdate), Times.Once);
        }

        [Fact]
        public async Task DeleteCliente_ShouldDeleteCliente()
        {
            // Arrange
            var repository = new Mock<IClienteRepository>();
            var clienteToDelete = new Cliente { IdCliente = 1, Nombre = "John Doe", Email = "john.doe@example.com", 
                FechaRegistro = new DateOnly(2024, 7, 8) };

            repository.Setup(repo => repo.Remove(It.IsAny<Cliente>())).Returns(Task.CompletedTask);

            var clienteService = new ClienteService(repository.Object);

            // Act
            await clienteService.DeleteCliente(clienteToDelete);

            // Assert
            repository.Verify(repo => repo.Remove(clienteToDelete), Times.Once);
        }

    }
}
