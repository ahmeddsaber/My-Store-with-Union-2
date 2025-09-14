using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Models
{
    public abstract class BaseModel<TId>

    {


        public TId Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdateBy { get; set; }
       public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
