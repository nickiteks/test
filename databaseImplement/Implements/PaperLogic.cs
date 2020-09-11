using bussines.BindingModels;
using bussines.Interfaces;
using bussines.ViewModels;
using databaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace databaseImplement.Implements
{
    public class PaperLogic : IPaperLogic
    {
        public void CreateOrUpdate(PaperBindingModel model)
        {
            using (var context = new Database())
            {
                Paper element = context.Papers.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть статья с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Papers.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Paper();
                    context.Papers.Add(element);
                }
                element.Name = model.Name;
                element.Theme = model.Theme;
                element.DateCreate = model.DateCreate;
                context.SaveChanges();
            }
        }

        public void Delete(PaperBindingModel model)
        {
            using (var context = new Database())
            {
                Paper element = context.Papers.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Papers.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<PaperViewModel> Read(PaperBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Papers
                .Where(rec => model == null 
                || rec.Id == model.Id
                || (rec.DateCreate > model.DateFrom && rec.DateCreate < model.DateTo))
                .Select(rec => new PaperViewModel
                {
                    Id = rec.Id,
                    DateCreate = rec.DateCreate,
                    Theme = rec.Theme,
                    Name = rec.Name
                })
                .ToList();
            }
        }
    }
}
