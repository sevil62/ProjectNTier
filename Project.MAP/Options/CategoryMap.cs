﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Kategoriler");
            Property(x => x.CategoryName).HasColumnName("Kategori Adı").IsRequired();
            Property(x => x.Description).HasColumnName("Kategori Açıklaması");
        }
    }
}
