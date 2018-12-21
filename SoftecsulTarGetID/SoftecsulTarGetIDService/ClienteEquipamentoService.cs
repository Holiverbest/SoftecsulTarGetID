using SoftecsulTarGetID.SoftecsulTarGetIDData;
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

    class ClienteEquipamentoService
    {
        private readonly TarGetIDContext _context;
        public ClienteEquipamentoService(TarGetIDContext context)
        {
            _context = context;
        }

        public List<ClienteEquipamento> FindAll(int Id)
        {
            ///.ToList e sincrona
            ///tem que usar outra função
            ///using Microsoft.EntityFrameworkCore; 
            ///Utilize o Eager Loading através do método Include
            ///Use o método AsNoTracking para consultas que são somente leitura.
            ///var _cliente =  (from cli in db.Clientes
            /// select new
            //{
            // cliente.Codigo,
            // cliente.Nome
            // }). ToList();
            //  ao invés de:
            //  var _cliente = (from cli in db.Clientes
            //                select cli).ToList();
            return _context.ClienteEquipamentos.AsNoTracking().Where(obj => obj.ClienteId == Id).ToList();

            //return _context.Clientes.Include(obj => obj.TipoManutencao).AsNoTracking().ToList();
        }
        /// <summary>
        /// Insere um objet do tipo cliente ao banco
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(ClienteEquipamento obj)
        {
            _context.ClienteEquipamentos.Add(obj);
            _context.SaveChanges();
        }
        /// <summary>
        /// Busca um cliente pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ClienteEquipamento FindById(int id)
        {
            ///Eager Loading, carregar objetos relacionados, neste caso o tipo de manutenção
            return _context.ClienteEquipamentos.AsNoTracking().FirstOrDefault(obj => obj.ClienteId == id);

        }

        /// <summary>
        /// Remove um cliente
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int? id)
        {
            var obj = _context.ClienteEquipamentos.Find(id);
            _context.ClienteEquipamentos.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(ClienteEquipamento obj)
        {
            bool hasAny = _context.ClienteEquipamentos.Any(x => x.ClienteId == obj.ClienteId);
            if (!hasAny)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            try
            {
                //TarGetIDContext _context = new TarGetIDContext();
                _context.ClienteEquipamentos.Add(obj);
                _context.SaveChanges();

            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
