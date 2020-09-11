using bussines.Interfaces;
using bussines.ViewModels;
using databaseImplement.Implements;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using bussines.Attributes;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IGroupLogic, GroupLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IStudentLogic, StudentLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IBackUp, BackUpLogic>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }

        public static void ConfigGrid<T>(List<T> data, DataGridView grid)
        {
            var type = typeof(T);
            if (type.BaseType == typeof(BaseViewModel))
            {
                // создаем объект от типа
                object obj = Activator.CreateInstance(type);
                // вытаскиваем метод получения списка заголовков
                var method = type.GetMethod("Properties");
                // вызываем метод
                var config = (List<string>)method.Invoke(obj, null);
                grid.Columns.Clear();
                foreach (var conf in config)
                {
                    // вытаскиваем нужное свойство из класса
                    var prop = type.GetProperty(conf);
                    if (prop != null)
                    {
                    // получаем список атрибутов
                        var attributes = prop.GetCustomAttributes(typeof(ColumnAttribute), true);
                        if (attributes != null && attributes.Length > 0)
                        {
                            foreach (var attr in attributes)
                            {
                                // ищем нужный нам атрибут
                                if (attr is ColumnAttribute columnAttr)
                                {
                                    var column = new DataGridViewTextBoxColumn
                                    {
                                        Name = conf,
                                        ReadOnly = true,
                                        HeaderText = columnAttr.Title,
                                        Visible = columnAttr.Visible,
                                        Width = columnAttr.Width
                                    };
                                    if (columnAttr.GridViewAutoSize != GridViewAutoSize.None)
                                    {
                                        column.AutoSizeMode =
                                       (DataGridViewAutoSizeColumnMode)Enum.Parse(typeof(DataGridViewAutoSizeColumnMode), columnAttr.GridViewAutoSize.ToString());
                                    }
                                    grid.Columns.Add(column);
                                }
                            }
                        }
                    }
                }
                // добавляем строки
                foreach (var elem in data)
                {
                    List<object> objs = new List<object>();
                    foreach (var conf in config)
                    {
                        var value = elem.GetType().GetProperty(conf).GetValue(elem);
                        objs.Add(value);
                    }
                    grid.Rows.Add(objs.ToArray());
                }
            }
        }

    }
}
