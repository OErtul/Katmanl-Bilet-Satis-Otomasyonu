using BiletSatisKatmanli.ENTITY.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.ENTITY.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }   = Guid.NewGuid();
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; }
    }
}
