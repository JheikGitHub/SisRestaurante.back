using SisRestaurante.Domain.Entities;
using System.Collections.Generic;

namespace SisRestaurante.Domain.Interfaces
{
    public interface IPratoRepository
    {
        Prato GetOne(int id);

        IEnumerable<Prato> GetAll();

        void Create(Prato prato);

        void Update(Prato prato);

        void Delete(Prato prato);
    }
}
