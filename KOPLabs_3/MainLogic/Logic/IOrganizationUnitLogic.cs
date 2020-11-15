using MainLogic.BindingModel;
using MainLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Logic
{
    public interface IOrganizationUnitLogic
    {
        void CreateOrUpdate(OrganizationUnitBindingModel model);

        List<OrganizanionUnitViewModel> Read(OrganizationUnitBindingModel filter);

        void Delete(OrganizationUnitBindingModel model);
    }
}
