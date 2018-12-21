using SoftecsulTarGetID.SoftecsulTarGetIDData;
using SoftecsulTarGetID.SoftecsulTarGetIDInterface;
using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using SoftecsulTarGetID.SoftecsulTarGetIDService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftecsulTarGetID.SoftecsulTarGetIDController
{
    class StatusRegistroController : IController
    {
        private readonly StatusRegistroService _statusRegistroService;

        private readonly TarGetIDContext _context;

        public StatusRegistroController()
        {
            _context = new TarGetIDContext();
            _statusRegistroService = new StatusRegistroService(_context);
        }

        public void Create(object obj)
        {
            StatusRegistro c = (StatusRegistro)Convert.ChangeType(obj, typeof(StatusRegistro));
            _statusRegistroService.Insert(c);
        }

        public void Delete(int id)
        {
            _statusRegistroService.Remove(id);
        }

        public bool Busca(StatusRegistro statusRegistro)
        {
            var obj = _statusRegistroService.FindAll(statusRegistro);
            if (obj != null)
            {
                MessageBox.Show("Registro em alteração pelo usuário pelo usuário.:" + statusRegistro.Funcionario);
            }
            return false;
        }

        public object Details(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// No implement
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object Edit(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// No implement
        /// </summary>
        /// <param name="obj"></param>
        public void Update(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
