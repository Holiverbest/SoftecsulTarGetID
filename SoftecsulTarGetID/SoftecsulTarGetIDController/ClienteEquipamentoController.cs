using SoftecsulTarGetID.SoftecsulTarGetIDData;
using SoftecsulTarGetID.SoftecsulTarGetIDInterface;
using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using SoftecsulTarGetID.SoftecsulTarGetIDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftecsulTarGetID.SoftecsulTarGetIDController
{
    class ClienteEquipamentoController : IController
    {

        private readonly ClienteEquipamentoService _clienteEquipamentoService;
        private readonly TarGetIDContext _context;

        public ClienteEquipamentoController()
        {
            _context = new TarGetIDContext();
            _clienteEquipamentoService = new ClienteEquipamentoService(_context);
        }

        public List<ClienteEquipamento> ListaClienteEquipamentos(int Id)
        {
            var list = _clienteEquipamentoService.FindAll(Id);
            return list;
        }



        public void Create(object  clienteEquipamento)
        {
            ClienteEquipamento c = (ClienteEquipamento)Convert.ChangeType(clienteEquipamento, typeof(ClienteEquipamento));
            _clienteEquipamentoService.Insert(c);

        }

        public void Delete(int id)
        {
            _clienteEquipamentoService.Remove(id);

        }

        public object Details(int id)
        {
            var obj = _clienteEquipamentoService.FindById(id);
            if (obj == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            return obj;
        }

        public object Edit(int id)
        {
            var obj = _clienteEquipamentoService.FindById(id);
            if (obj == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }          
            return obj;
        }

        public void Update(object objeto)
        {
            if (objeto == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            ClienteEquipamento c = (ClienteEquipamento)Convert.ChangeType(objeto, typeof(ClienteEquipamento));
            _clienteEquipamentoService.Update(c);
        }
    }
}
