using MyMart.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMart.Core.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        // Add category-specific methods if needed
    }
}
