﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyorMarket.Domain.DTOs.Sale
{
    public record SaleForUpdateDTOs(
        int Id,
        DateTime SaleDate,
        int CustomerId
        );
}