using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook.Common
{
    public class ListResponse<TObject> : Response
    {
        public List<TObject> Items { get; set; }
    }
}
