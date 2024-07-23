using BiletSatisKatmanli.ENTITY.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.DAL.Configurations
{
    public class AuditableConfiguration<T> : BaseConfiguration<T> where T : AuditableEntity
    {
      public override void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.DeletedDate).IsRequired(false);
            base.Configure(builder);
        }

    }
}
