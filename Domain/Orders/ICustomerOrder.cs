﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Customers.Details;

namespace Domain.Orders
{
    public interface ICustomerOrder : IOrder, IBillable, IShippable
    {
    }
}
