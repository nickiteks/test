using BankBusinessLogic.BindingModels;
using BankBusinessLogic.Enums;
using BankBusinessLogic.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBusinessLogic.BusnessLogic
{
        public class MainLogic
        {
            private readonly IDealLogic dealLogic;
            private readonly IStorageLogic storageLogic;

            public MainLogic(IDealLogic dealLogic, IStorageLogic storageLogic)
            {
                this.dealLogic = dealLogic;
                this.storageLogic = storageLogic;
            }

            public void CreateOrder(CreateDealBindingModel model)
            {
                dealLogic.CreateOrUpdate(new DealBindingModel
                {
                    Status = DealStatus.Принят
                });
            }

            public void TakeOrderInWork(ChangeStatusBindingModel model)
            {
                var order = dealLogic.Read(new DealBindingModel { Id = model.DealId })?[0];
                if (order == null)
                {
                    throw new Exception("Не найден заказ");
                }
                if (order.Status != DealStatus.Принят)
                {
                    throw new Exception("Заказ не в статусе \"Принят\"");
                }
                //if (storageLogic.RemoveMaterials(order))
                //{
                    if (order.Status != DealStatus.Принят)
                    {
                        throw new Exception("Заказ не в статусе \"Принят\"");
                    }
                    dealLogic.CreateOrUpdate(new DealBindingModel
                    {
                        Id = order.Id,
                        DealName = order.DealName,
                        DealCredits = order.DealCredits,
                        Status = DealStatus.Подписан
                    });
               // }
            }
            public void AddMaterials(StorageAddMoneyBindingModel model)
            {
                storageLogic.AddMaterialToStorage(model);
            }
        }
}
