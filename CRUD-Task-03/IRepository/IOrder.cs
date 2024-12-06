﻿using CRUD.DTO;
using CRUD.Helper;
using CRUD_Task_03.DTO;

namespace CRUD.IRepository
{
    public interface IOrder
    {
        Task<MessageHelper> CreateOrderWithItems(CreateOrderDTO create);
        Task<MessageHelper> DeleteOrderWithCorrespondingItems(long orderId);
        Task<GetOrderDetailsDTO> GetOrderDetails(long Id);
        Task<MinMaxDTO> GetMinMax();
    }
}
