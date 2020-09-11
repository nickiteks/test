using bussines.BindingModels;
using bussines.HelperModels;
using bussines.Interfaces;
using bussines.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bussines.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IStudentLogic studentLogic;
        private readonly IGroupLogic groupLogic;

        public ReportLogic(IStudentLogic studentLogic, IGroupLogic groupLogic)
        {
            this.studentLogic = studentLogic;
            this.groupLogic = groupLogic;
        }

        public List<ReportViewModel> GetInformation(ReportBindingModel model)
        {
            var group = groupLogic.Read(new GroupBindingModel { DateFrom = model.DateFrom, DateTo = model.DateTo });
            var students = studentLogic.Read(new StudentBindingModel { Groups = group.Select(x => x.Id).ToList() });
            return group.Join(students, g => g.Id, s => s.GroupId, (g, s) => new ReportViewModel { 
                FIOStudent = s.FIO,
                DateCreate = g.DateCreate,
                DateOfCrediting = s.DateOfCrediting,
                NameGroup = g.Name,
                PassingScore = s.PassingScore
            }).ToList();
        }
        public async void SaveOrdersToPdfFile(ReportBindingModel model)
        {
            await Task.Run(() =>
            {
                SaveToPdf.CreateDoc(new PdfInfo
                {
                    FileName = model.FileName,
                    Title = "Групп созданных",
                    DateFrom = model.DateFrom.Value,
                    DateTo = model.DateTo.Value,
                    Reports = GetInformation(model)
                });
            });
        }
    }
}
