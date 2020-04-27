using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace SmartFactory.Models.Repository
{
    public class DBlayer : DbContext
    {
        public DbSet<User> Users { get; set; }

    }
}
