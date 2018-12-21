using System.Collections.Generic;

namespace SoftecsulTarGetID.SoftecsulTarGetIDInterface
{
    interface IController
    {
        void Delete(int id);
        void Update(object obj);
        object Edit(int id);
        object Details(int id);
        void Create(object obj);
    }
}
