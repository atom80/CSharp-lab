using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorab {
   public class RandomExtension:Random {
       public RandomExtension()
           : base(Guid.NewGuid().GetHashCode()) {
      }

    }
}
