using SoftecsulTarGetID.SoftecsulTarGetIDData;
using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using SoftecsulTarGetID.SoftecsulTarGetIDService.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SoftecsulTarGetID.SoftecsulTarGetIDService
{
    class ClienteService
    {
        private readonly TarGetIDContext _context;

        public ClienteService(TarGetIDContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lista todos os clientes
        /// </summary>
        /// <returns></returns>
        public List<Cliente> FindAll()
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

            try
            {
                return _context.Clientes.Include(X => X.TipoManutencao).AsNoTracking().ToList();
            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new DbConcurrencyException(e.Message);
            }

        }

        public List<Cliente> FindAllbyCliente(Cliente cliente)
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

            //if (c.ClienteId)
            //{

            //}
            try
            {
                var query = _context.Clientes.Where(c => c.NomeFantasia.Contains(cliente.NomeFantasia) || c.Versao == cliente.Versao || c.CNPJ == cliente.CNPJ).ToList();

                if (query.Count == 0)
                {
                    query = FindAll();
                }
                return query;
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        /// <summary>
        /// Insere um objet do tipo cliente ao banco
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Cliente obj)
        {
            try
            {
                _context.Clientes.Add(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }
        /// <summary>
        /// Busca um cliente pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente FindById(int id)
        {
            ///Eager Loading, carregar objetos relacionados, neste caso o tipo de manutenção
            return _context.Clientes.Include(obj => obj.ClienteEquipamentos).AsNoTracking().FirstOrDefault(obj => obj.ClienteId == id);
        }

        /// <summary>
        /// Remove um cliente
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            try
            {
                var obj = _context.Clientes.Find(id);
                _context.Clientes.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro ao Remover o ID " + id + "\n" + e.Message);
            }
        }

        public void Update(Cliente obj)
        {
            bool hasAny = _context.Clientes.Any(x => x.ClienteId == obj.ClienteId);
            if (!hasAny)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            try
            {
                //TarGetIDContext _context = new TarGetIDContext();
                _context.Clientes.Add(obj);
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
