using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.Viewmodels;
using DataBaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseImplement.Implements
{
    public class OSLogic : IOSLogoc
    {
        public void CreateOrUpdate(OSBindingModel model)
        {
            using (var context = new Database())
            {
                OS element = context.OSs.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть статья с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.OSs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new OS();
                    context.OSs.Add(element);
                }
                element.name = model.name;
                element.version = model.version;
                element.dateCreate = model.dateCreate;
                context.SaveChanges();
            }
        }

        public void Delete(OSBindingModel model)
        {
            using (var context = new Database())
            {
                OS element = context.OSs.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.OSs.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<OSViewModel> Read(OSBindingModel model)
        {
            using (var context = new Database())
            {
                return context.OSs
                .Where(rec => model == null
                || rec.Id == model.Id
                || (rec.DateCreate > model.DateFrom && rec.DateCreate < model.DateTo))
                .Select(rec => new OSViewModel
                {
                    Id = rec.Id.Value,
                    dateCreate = rec.dateCreate,
                    version = rec.version,
                    name = rec.name
                })
                .ToList();
            }
        }
    }
}
