using BiletSatisKatmanli.ENTITY.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.DAL.Configurations
{
    // Auditable da base entityden kalıtım aldığı için aşağıdakş yazım doğrudur
    // fakat Auditabledan kalıtım alan bir base veridiğimizde çalışmayacaktır.
    public class EventConfiguration : BaseConfiguration<Eventt>
    {
        public override void Configure(EntityTypeBuilder<Eventt> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(128);
            base.Configure(builder);
        }
    }
}
