﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyorMarket.Domain.DTOs.SaleItam
{
    public record SaleItemForCreateDTOs(
         int Quantity,
         decimal UnitPrice,
         int ProductId,
         int SaleId
         );
}
