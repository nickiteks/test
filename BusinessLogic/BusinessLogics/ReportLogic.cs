using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IOSLogoc os;
        private readonly IPOLogic po;
        public ReportLogic(IOSLogoc os, IPOLogic po)
        {
            this.os = os;
            this.po = po;
        }
        public List<POViewModel> GetVklads(ReportBindingModel model)
        {
            var POs = po.Read(new POBindingModel
            {
            });
            var list = new List<POViewModel>();
            foreach (var rec in POs)
            {
                var record = new POViewModel
                {
                    dateCreate = rec.dateCreate,
                    company = rec.company,
                    name = rec.name,
                    OSId = rec.OSId,
                    price = rec.price
                };
                list.Add(record);
            }
            return list;
        }
        public async void SaveVkladsToPdfFile(ReportBindingModel model)
        {
            string title = "Вклады банков за период";

            await Task.Run(() =>
            {
                SaveToPdf.CreateDoc(new PdfInfo
                {
                    FileName = model.FileName,
                    Title = title,
                    Vklads = GetVklads(model),
                });
            });
        }
    }
}
