﻿using Ecommerce.Common.Infrastructure.ViewModel.Admin;
using Ecommerce.Domain.Models;
using Ecommerce.Repository.Interfaces;
using Ecommerce.Service.Interface;
using Ecommerce.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service
{
    public class SupplierService : EcommerceServices<Supplier>, ISupplierServices
    {
        private readonly ISupplierRepository _supplierReponsitory;

        public SupplierService(ISupplierRepository supplierReponsitory) : base(supplierReponsitory)
        {
            _supplierReponsitory = supplierReponsitory;
        }

    }
}
