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
    public class POLogic : IPOLogic
    {
        public void CreateOrUpdate(POBindingModel model)
        {
            using (var context = new Database())
            {
                PO element = context.POs.FirstOrDefault(rec => rec.FIO == model.FIO && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть студент с таким фио");
                }
                if (model.Id.HasValue)
                {
                    element = context.POs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new PO();
                    context.POs.Add(element);
                }
                element.company = model.company;
                element.dateCreate = model.dateCreate;
                element.name = model.name;
                element.OSId = model.OSId;
                element.price = model.price;
                context.SaveChanges();
            }
        }

        public void Delete(POBindingModel model)
        {
            using (var context = new Database())
            {
                PO element = context.POs.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.POs.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        } 
        

        public List<POViewModel> Read(POBindingModel model)
        {
            using (var context = new Database())
            {
                return context.POs
                .Where(rec => model == null || rec.Id == model.Id || (model.dateCreate.HasValue && rec.Po.DateCreate >= model.DateFrom && rec.PO.DateCreate <= model.DateTo))
                .Select(rec => new POViewModel
                 {
                     price = rec.price,
                     Id = rec.Id,
                     OSId = rec.OSId,
                     name = rec.name,
                     company = rec.company,
                     dateCreate =rec.datecreate
                 })
                .ToList();
            }
        }
    }
}
