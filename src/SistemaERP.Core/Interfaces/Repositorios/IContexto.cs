using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Core.Interfaces.Repositorios
{
    public interface IContexto
    {
        void Migrate();
        void SetarConnectionString(string connectionString);
    }
}
