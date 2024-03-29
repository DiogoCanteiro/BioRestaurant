﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Services.ShoppingCartAPI.Models
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; } = true;

        public object Result { get; set; }

        public string DisplayMessage { get; set; } = string.Empty;

        public List<string> ErrorMessages { get; set; }
    }
}
