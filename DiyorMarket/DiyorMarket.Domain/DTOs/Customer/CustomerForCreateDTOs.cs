﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyorMarket.Domain.DTOs.Customer
{
    public record CustomerForCereateDTOs(
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber
        );
}