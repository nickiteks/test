using bussines.BindingModels;
using bussines.Interfaces;
using bussines.ViewModels;
using databaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace databaseImplement.Implements
{
    public class GroupLogic : IGroupLogic
    {
        public void CreateOrUpdate(GroupBindingModel model)
        {
            using (var context = new Database())
            {
                Group element = context.Groups.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть статья с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Groups.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Group();
                    context.Groups.Add(element);
                }
                element.Name = model.Name;
                element.Direct = model.Direct;
                element.DateCreate = model.DateCreate;
                context.SaveChanges();
            }
        }

        public void Delete(GroupBindingModel model)
        {
            using (var context = new Database())
            {
                Group element = context.Groups.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Groups.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<GroupViewModel> Read(GroupBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Groups
                .Where(rec => model == null
                || rec.Id == model.Id
                || (rec.DateCreate > model.DateFrom && rec.DateCreate < model.DateTo))
                .Select(rec => new GroupViewModel
                {
                    Id = rec.Id.Value,
                    DateCreate = rec.DateCreate,
                    Direct = rec.Direct,
                    Name = rec.Name
                })
                .ToList();
            }
        }
    }
}
