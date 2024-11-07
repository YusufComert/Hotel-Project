﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusunessLayer.Abstract
{
    public interface ICustomerService:IGenericService<Customer>
    {
        public Customer AddCustomer(Customer c);
    }
}