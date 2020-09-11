using bussines.BindingModels;
using bussines.ViewModels;
using System.Collections.Generic;

namespace bussines.Interfaces
{
    public interface IPaperLogic
    {
        List<PaperViewModel> Read(PaperBindingModel model);
        void CreateOrUpdate(PaperBindingModel model);
        void Delete(PaperBindingModel model);
    }
}
