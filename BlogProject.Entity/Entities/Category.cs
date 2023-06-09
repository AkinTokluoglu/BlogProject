﻿using BlogProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Entities
{
    public class Category : EntityBase
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
