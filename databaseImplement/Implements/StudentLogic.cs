using bussines.BindingModels;
using bussines.Interfaces;
using bussines.ViewModels;
using databaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace databaseImplement.Implements
{
    public class StudentLogic : IStudentLogic
    {
        public void CreateOrUpdate(StudentBindingModel model)
        {
            using (var context = new Database())
            {
                Student element = context.Students.FirstOrDefault(rec => rec.FIO == model.FIO && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть студент с таким фио");
                }
                if (model.Id.HasValue)
                {
                    element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Student();
                    context.Students.Add(element);
                }
                element.FIO = model.FIO;
                element.PassingScore = model.PassingScore;
                element.RecordBook = model.RecordBook;
                element.GroupId = model.GroupId;
                element.DateOfCrediting = model.DateOfCrediting;
                context.SaveChanges();
            }
        }

        public void Delete(StudentBindingModel model)
        {
            using (var context = new Database())
            {
                Student element = context.Students.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Students.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<StudentViewModel> Read(StudentBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Students
                .Where(rec => model == null || rec.Id == model.Id || rec.Group.DateCreate))
                .Select(rec => new StudentViewModel
                {
                    Id = rec.Id.Value,
                    GroupId = rec.GroupId,
                    DateOfCrediting = rec.DateOfCrediting,
                    RecordBook = rec.RecordBook,
                    FIO = rec.FIO,
                    PassingScore = rec.PassingScore,
                })
                .ToList();
            }
        }
    }
}
