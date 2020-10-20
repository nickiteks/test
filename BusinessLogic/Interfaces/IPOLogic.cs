using BusinessLogic.BindingModels;
using BusinessLogic.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IPOLogic
    {
        List<POViewModel> Read(POBindingModel model);
        void CreateOrUpdate(POBindingModel model);
        void Delete(POBindingModel model);
    }
}
