using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicahCustomerManager.Models
{
    public class Procedure
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Decimal Price { get; set; }
        public Boolean ConsentRequired { get; set; }
    }
}
