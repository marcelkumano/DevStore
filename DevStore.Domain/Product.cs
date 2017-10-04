﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevStore.Domain
{
    public class Product    
    {
        public Product()
        {
            this.AcquireDate = DateTime.Now.Date;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public DateTime AcquireDate { get; set; }

        public bool IsActive { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
