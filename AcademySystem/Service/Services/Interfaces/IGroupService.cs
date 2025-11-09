using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    internal interface IGroupService
    {

            Group Create(Group group);
            Group Update(int id, Group group);
            void Delete(int id);
            Group GetById(int id);
            List<Group> GetAll();
            List<Group> GetByTeacher(string teacher);
            List<Group> GetByRoom(string room);
            List<Group> Search(string name);

        
    }
}
