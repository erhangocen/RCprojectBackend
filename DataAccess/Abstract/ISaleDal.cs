﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISaleDal: IEntityRepository<Sale>
    {
        List<SaleDto> GetFullSaleDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
