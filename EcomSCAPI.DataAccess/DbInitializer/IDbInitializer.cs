using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomSCAPI.DataAccess.DbInitializer
{
    public interface IDbInitializer
    {
        /// <summary>
        /// Initialize Database
        /// </summary>
        public void Initialize();
    }
}
