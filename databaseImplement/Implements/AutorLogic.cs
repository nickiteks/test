using bussines.BindingModels;
using bussines.Interfaces;
using bussines.ViewModels;
using databaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace databaseImplement.Implements
{
    public class AutorLogic : IAutorLogic
    {
        public void CreateOrUpdate(AutorBindingModel model)
        {
            using (var context = new Database())
            {
                Autor element = context.Autors.FirstOrDefault(rec => rec.FIO == model.FIO && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть автор с таким фио");
                }
                if (model.Id.HasValue)
                {
                    element = context.Autors.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Autor();
                    context.Autors.Add(element);
                }
                element.FIO = model.FIO;
                element.DateOfBirth = model.DateOfBirth;
                element.Email = model.Email;
                element.PaperId = model.PaperId;
                element.PlaceWork = model.PlaceWork;
                context.SaveChanges();
            }
        }

        public void Delete(AutorBindingModel model)
        {
            using (var context = new Database())
            {
                Autor element = context.Autors.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Autors.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<AutorViewModel> Read(AutorBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Autors
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new AutorViewModel
                {
                    Id = rec.Id,
                    FIO = rec.FIO,
                    PlaceWork = rec.PlaceWork,
                    PaperId = rec.PaperId,
                    Email = rec.Email,
                    DateOfBirth = rec.DateOfBirth
                })
                .ToList();
            }
        }
    }
}
