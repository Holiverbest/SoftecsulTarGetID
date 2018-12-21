using SoftecsulTarGetID.SoftecsulTarGetIDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftecsulTarGetID.SoftecsulTarGetIDService;
using SoftecsulTarGetID.SoftecsulTarGetIDData;
using SoftecsulTarGetID.SoftecsulTarGetIDInterface;

namespace SoftecsulTarGetID.SoftecsulTarGetIDController
{
    class TipoManutencaoController : IController
    {

        private readonly TipoManutencaoService _tipoManutencaoService;
        private readonly TarGetIDContext _context;

        public TipoManutencaoController()
        {
            _context = new TarGetIDContext();
            _tipoManutencaoService = new TipoManutencaoService(_context);
        }

        public List<TipoManutencao> ListaTipoManutencao()
        {
            var list = _tipoManutencaoService.FindAll();
            return list;
        }
      
        public void Delete(int id)
        {
            _tipoManutencaoService.Remove(id);
        }

        public void Update(Object tipoManutencao)
        {
            if (tipoManutencao == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            TipoManutencao c = (TipoManutencao)Convert.ChangeType(tipoManutencao, typeof(TipoManutencao));
            _tipoManutencaoService.Update(c);
        }

        public object Edit(int id)
        {
            var obj = _tipoManutencaoService.FindById(id);
            if (obj == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }          
            return obj;
        }

        public object Details(int id)
        {
            var obj = _tipoManutencaoService.FindById(id);
            if (obj == null)
            {
                throw new DllNotFoundException("Id não encontrado");
            }
            return obj;
        }

        public void Create(object tipoManutencao)
        {           
            TipoManutencao c = (TipoManutencao)Convert.ChangeType(tipoManutencao, typeof(TipoManutencao));
            _tipoManutencaoService.Insert(c);
        }
    }
}
