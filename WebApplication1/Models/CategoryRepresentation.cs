﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CategoryRepresentation
    {

        public CategoryRepresentation(int categoryId, string name)
        {
            this.CategoryID = categoryId;
            this.Name = name;
        }

        [JsonProperty(PropertyName = "categoryId")]
        public int CategoryID { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}

