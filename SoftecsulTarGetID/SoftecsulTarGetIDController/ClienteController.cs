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
    class ClienteController : IController
    {
        private readonly ClienteService _clienteService;
        private readonly TipoManutencaoService _tipoManutencaoService;
        private readonly TarGetIDContext _context;


        public ClienteController()
        {

            _context = new TarGetIDContext();
            _clienteService = new ClienteService(_context);
            _tipoManutencaoService = new TipoManutencaoService(_context);
            // _tipoManutencaoService = new TipoManutencaoService(_context);
        }

        public List<Cliente> ListaTodos()
        {
            var list = _clienteService.FindAll().ToList();          
            return list;
        }

        public List<Cliente> FiltraClientes(Cliente c)
        {
            var list = _clienteService.FindAllbyCliente(c);
            return list;
        }

        public void Create(object cliente)
        {
            // var departments = await _departmentService.FindAllAsync();
            ///var viewModel = await SellerFormViewModel { Seller = seller , Depart }
            Cliente c = (Cliente)Convert.ChangeType(cliente, typeof(Cliente));
            _clienteService.Insert(c);
        }

        public object Details(int id)
        {
            var obj = _clienteService.FindById(id);
            if (obj == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            return obj;
        }

        public object Edit(int id)
        {
            var obj = _clienteService.FindById(id);
            if (obj == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            //List<Department> departments = _departmentService.FindAllAsync();
            //SellerFormViewModel viewModel = new SellerFormViewModel { Seller = obj, Departments = departments };
            return obj;
        }

        public void Delete(int id)
        {
            _clienteService.Remove(id);
        }

        public void Update(Object cliente)
        {
            if (cliente == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            Cliente c = (Cliente)Convert.ChangeType(cliente, typeof(Cliente));
            _clienteService.Update(c);
        }


    }
}
