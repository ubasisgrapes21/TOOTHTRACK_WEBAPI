using Microsoft.Identity.Client;
using MODELS;
using REPOSITORIES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class UserstblService
    {
        private readonly UserstblRepository _userstblRepository = new UserstblRepository();

        public async Task<Userstbl?> Insert(Userstbl data)
        {
            return await _userstblRepository.Insert(data);
        }

        public async Task<Userstbl?> Update(Userstbl data)
        {
            return await _userstblRepository.Update(data);
        }
        public async Task<Userstbl?> GetById(int id)
        {
            return await _userstblRepository.GetById(id);
        }
        public async Task<IEnumerable<Userstbl>> GetAll()
        {
            return await _userstblRepository.GetAll();
        }
        public async Task<Userstbl?> DeleteById(int id)
        {
            return await _userstblRepository.DeleteById(id);
        }
    }
}
