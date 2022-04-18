using proyecto_Nel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proyecto_Nel.Data.Services
{
    public interface IPropietariosService
    {
        //Extraer la informacion de propietarios de la base de datos
        Task<IEnumerable<propietario>> GetAllAsync();
        Task <propietario> GetByIdAsync(int id);//devolver un propietario expecifico
        Task AddAsync(propietario propietario);
        Task <propietario> UpdateAsync(int id, propietario newpropietario);
        Task DeleteAsync(int id);

    }
}
