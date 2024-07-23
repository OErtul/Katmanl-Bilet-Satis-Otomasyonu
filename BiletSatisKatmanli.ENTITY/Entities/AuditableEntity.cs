using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.ENTITY.Entities
{
    // soft delete tabii olan entityler denetlenebilir entitylerdir.
    // denetlenebilirler burada tutulacak 
    // Bu entityde base entityden kalıtım alıyor normal bir entity aslında tek farkı denetlenebilir olması
    // denetlenebiliyorsan deleted date propertysine ihtiyacı vardir ihtiyacı var
    // yine dbcontexten gelen savechange metodunu override ettiğimizde
    // set if deleted metosuna girdiğinde tipine bakacak.Auditabledan geliyorsa bunudeleted değil modifiate olacak.
    // Auditable ise denetlenebilir olduğundan direkt uçuracak.
    public abstract class AuditableEntity : BaseEntity
    {

        public DateTime DeletedDate { get; set; }
    }
}
