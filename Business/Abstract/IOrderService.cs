﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int orderId);
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(int id);
        IResult RulesForAdding(Order order);
    }
}
