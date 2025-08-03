using MODELS;
using ProceduresEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIES
{
    public class UserstblRepository : GenericRepository<Userstbl, UserstblProcedures>
    {
        private static GenericProcedure<UserstblProcedures> _procedures = new GenericProcedure<UserstblProcedures>
        {
            GetAll = UserstblProcedures.Userstbl_GetAll,
            GetById = UserstblProcedures.Userstbl_GetById,
            Insert = UserstblProcedures.Userstbl_Insert,
            Update = UserstblProcedures.Userstbl_Update,
            DeleteById = UserstblProcedures.Userstbl_DeleteById,
        };
        public UserstblRepository() : base(_procedures)
        {

        }


    }
}
