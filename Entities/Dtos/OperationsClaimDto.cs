﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    class OperationsClaimDto:IDto
    {
        public string UserName { get; set; }
        public string ClaimName { get; set; }
    }
}
