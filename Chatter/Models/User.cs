﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatter.Models
{
    public class User
    {
        public int Id { get; set; }
        public string userName { get; set; }

        public Blog BlogId { get; set; }
    }
}
