using SoftecsulTarGetID.SoftecsulTarGetIDData;
using SoftecsulTarGetID.SoftecsulTarGetIDInterface;
using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using SoftecsulTarGetID.SoftecsulTarGetIDService.Exception;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftecsulTarGetID.SoftecsulTarGetIDService
{
    class StatusRegistroService
    {

        private readonly TarGetIDContext _context;

        public StatusRegistroService(TarGetIDContext context)
        {
            _context = context;
        }        

        public StatusRegistro FindAll(StatusRegistro statusRegistro)
        {           
            return _context.StatusRegistroes.AsNoTracking().FirstOrDefault(obj => obj.Tabela == statusRegistro.Tabela  && obj.IDTabela == statusRegistro.IDTabela  && obj.Funcionario != statusRegistro.Funcionario);
                        
        }

        public void Insert(StatusRegistro obj)
        {
            _context.StatusRegistroes.Add(obj);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            try
            {
                var obj = _context.StatusRegistroes.Find(id);
                _context.StatusRegistroes.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
