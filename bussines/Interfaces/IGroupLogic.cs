using bussines.BindingModels;
using bussines.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace bussines.Interfaces
{
    public interface IGroupLogic
    {
        List<GroupViewModel> Read(GroupBindingModel model);
        void CreateOrUpdate(GroupBindingModel model);
        void Delete(GroupBindingModel model);
    }
}
