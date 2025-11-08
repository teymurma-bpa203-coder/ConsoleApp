using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repostories.Interfaces
{
    internal interface IRepository
    {
        public interface IRepostory<T> where T : BaseEntity
        {
        }
    }
}

