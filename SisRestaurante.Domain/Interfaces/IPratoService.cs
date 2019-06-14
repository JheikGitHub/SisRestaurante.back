using SisRestaurante.Domain.Entities;
using System.Collections.Generic;

namespace SisRestaurante.Domain.Interfaces
{
    public interface IPratoService
    {
        Prato GetOne(int id);

        IEnumerable<Prato> GetAll();

        void Create(Prato prato);

        void Update(int id,Prato prato);

        void Delete(int id);
    }
}
