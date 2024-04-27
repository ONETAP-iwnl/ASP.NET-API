using LombardApi.Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace LombardApi.Services
{
    public class LombardService //CRUD 
    {
        private LombardContext _context;

        public LombardService()
        {
            _context = new LombardContext();
        }

        internal async Task AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        internal async Task<IEnumerable<Client>> GetClients() => await _context.Clients.ToListAsync();

        internal async Task<IEnumerable<Employees>> GetEmployees() => await _context.Employees.ToListAsync();

        internal async Task UpdateClient(Guid clientId, Client newData)
        {
            var existingClient = await _context.Clients.FindAsync(clientId);
            if (existingClient != null)
            {
                existingClient.FirstName = newData.FirstName;
                existingClient.LastName = newData.LastName;
                existingClient.PhoneNumber = newData.PhoneNumber;
                existingClient.Email = newData.Email;
                existingClient.DateOfBirth = newData.DateOfBirth;
                await _context.SaveChangesAsync();
            }
        }

        internal async Task UpdateEmployee(Guid employeesId, Employees newData)
        {
            var existingEmployee = await _context.Employees.FindAsync(employeesId);
            if (existingEmployee != null)
            {
                existingEmployee.EmployeeName = newData.EmployeeName;
                existingEmployee.Position = newData.Position;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteClient(Guid clientId)
        {
            var clientToDelete = await _context.Clients.FindAsync(clientId);
            if (clientToDelete != null)
            {
                _context.Clients.Remove(clientToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteEmployee(Guid employeesId)
        {
            var employeeToDelete = await _context.Employees.FindAsync(employeesId);
            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
