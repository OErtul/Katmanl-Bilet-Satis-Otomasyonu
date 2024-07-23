using BiletSatisKatmanli.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.DAL.Configurations
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            /*builder.Property(x=>x.Id).ValueGeneratedOnAdd(); => Id kolonuna otomatik 
            olarak ilgili türde değer verir. Id int tanımlandıysa mesela birer birer arttırır
            */
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);

        }
    }
}
