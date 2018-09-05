using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Evans.Models.Northwind
{


    public class NorthwindContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<NorthwindContext>
    {
        public NorthwindContext Create()
        {
            return new NorthwindContext();
        }
    }
}

