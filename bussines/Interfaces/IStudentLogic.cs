using bussines.BindingModels;
using bussines.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace bussines.Interfaces
{
    public interface IStudentLogic
    {
        List<StudentViewModel> Read(StudentBindingModel model);
        void CreateOrUpdate(StudentBindingModel model);
        void Delete(StudentBindingModel model);
    }
}
