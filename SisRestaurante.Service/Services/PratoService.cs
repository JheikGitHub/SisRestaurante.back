using SisRestaurante.Domain.Entities;
using SisRestaurante.Domain.Interfaces;
using SisRestaurante.Infra.Data.Repository;
using System;
using System.Collections.Generic;

namespace SisRestaurante.Service.Services
{
    public class PratoService : IPratoService
    {
        private IPratoRepository _repository;
        public PratoService(IPratoRepository repository)
        {
            _repository = repository;
        }
        public void Create(Prato prato)
        {
           
            prato.ValidaDados();

            _repository.Create(prato);
        }

        public void Delete(int id)
        {
            var model = _repository.GetOne(id);
            if (model == null)
                throw new Exception("Prato não encontrado");

            _repository.Delete(model);
        }

        public IEnumerable<Prato> GetAll()
        {
            return _repository.GetAll();
        }

        public Prato GetOne(int id)
        {
            var model = _repository.GetOne(id);

            if (model == null)
                throw new Exception("Prato não encontrado");

            return model;
        }

        public void Update(int id, Prato prato)
        {
            var model = _repository.GetOne(id);

            if (model == null)
                throw new Exception("Prato não encontrado");

            model.Nome = prato.Nome;
            model.Preco = prato.Preco;
            model.ValidaDados();

            _repository.Update(model);
        }
    }
}
