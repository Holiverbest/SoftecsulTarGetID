using SoftecsulTarGetID.SoftecsulTarGetIDData;
using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SoftecsulTarGetID.SoftecsulTarGetIDService.Exception;

namespace SoftecsulTarGetID.SoftecsulTarGetIDService
{
    class TipoManutencaoService
    {
        private TarGetIDContext _context;

        public TipoManutencaoService(TarGetIDContext context)
        {
            _context = context;
        }

        public List<TipoManutencao> FindAll()
        {
            return _context.TipoManutencoes.OrderBy(x => x.Tipo).ToList();

        }

        public List<TipoManutencao> FindAllTipo()
        {

            //var list = (from c in _context.TipoManutencoes select c.Tipo).ToList();

            //return list;
            //var resultado = from c in contas> select c.Numero;
            return _context.TipoManutencoes.OrderBy(x => x.Tipo).ToList();

        }

        /// <summary>
        /// Busca um TipoManutencao pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TipoManutencao FindById(int id)
        {
            return _context.TipoManutencoes.FirstOrDefault(obj => obj.TipoManutencaoId == id);
        }


        /// <summary>
        /// Insere um objet do tipo cliente ao banco
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(TipoManutencao obj)
        {
            _context.TipoManutencoes.Add(obj);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            try
            {
                var obj = _context.TipoManutencoes.Find(id);
                _context.TipoManutencoes.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public void Update(TipoManutencao obj)
        {
            bool hasAny = _context.TipoManutencoes.Any(x => x.TipoManutencaoId == obj.TipoManutencaoId);
            if (!hasAny)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            try
            {
                //TarGetIDContext _context = new TarGetIDContext();
                _context.TipoManutencoes.Add(obj);
                _context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();

            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
