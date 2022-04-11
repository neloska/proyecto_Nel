using proyecto_Nel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace proyecto_Nel.Data.Services
{
    public interface IPropietariosService
    {
        //Extraer la informacion de propietarios de la base de datos
        Task<IEnumerable<propietario>> GetAll();
        propietario GetById(int id);//devolver un propietario expecifico
        void Add(propietario propietario);
        propietario Update(int id, propietario newpropietario);
        void Delete(int id);

    }
}
