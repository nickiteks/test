using bussines.BindingModels;
using bussines.ViewModels;
using System.Collections.Generic;

namespace bussines.Interfaces
{
    public interface IAutorLogic
    {
        List<AutorViewModel> Read(AutorBindingModel model);
        void CreateOrUpdate(AutorBindingModel model);
        void Delete(AutorBindingModel model);
    }
}
