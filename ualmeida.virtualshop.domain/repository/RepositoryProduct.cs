using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ualmeida.virtualshop.domain.entity;

namespace ualmeida.virtualshop.domain.repository
{
    public class RepositoryProduct
    {
        private readonly EfdbContext _context = new EfdbContext();


        //As queryes do contex são realizadas aqui !  
        public IEnumerable<Product> Products
        {
            get { return _context.Product; }
        }


        


    }
}
