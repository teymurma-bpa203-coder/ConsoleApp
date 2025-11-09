using Repository.Data;
using Repository.Exceptions;
using Repository.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repository.Repostories.Implementations
{
    public class GroupRepository : IRepository<Group>
    {
        public void Create(Group data)
        {
            try
            {
                if (data == null) throw new NotFoundException("Data Not Found! ");
                AppDbContext<Group>.datas.Add(data);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Create(global::Service.Service.Inplementations.Group group)
        {
            throw new NotImplementedException();
        }

        public void Delete(Group data)
        {
            throw new NotImplementedException();
        }

        public Group Get(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll(Predicate<Group> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Group data)
        {
            throw new NotImplementedException();
        }
    }
}
    

