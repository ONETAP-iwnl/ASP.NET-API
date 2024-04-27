using LombardApi.Context;

namespace LombardApi.Services
{
    public interface ILombardService
    {
        Task AddClient(Client client);
        Task AddEmployee(Employees employees);
        Task<IEnumerable<Client>> GetClients();
        Task<IEnumerable<Employees>> GetEmployees();
        Task UpdateClient(Guid clientId, Client newData);
        Task UpdateEmployee(Guid employeesId, Employees newData);
        Task DeleteClient(Guid clientId);
        Task DeleteEmployee(Guid employeesId);
    }
}