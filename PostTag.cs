﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
