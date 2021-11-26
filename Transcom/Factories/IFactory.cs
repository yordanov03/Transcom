using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transcom.Factories
{
    public interface IFactory
    {
       object Build();
    }
}
