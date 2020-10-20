using BusinessLogic.BindingModels;
using BusinessLogic.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IOSLogoc
    {
        List<OSViewModel> Read(OSBindingModel model);
        void CreateOrUpdate(OSBindingModel model);
        void Delete(OSBindingModel model);
    }
}
