using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatisKatmanli.ENTITY.Entities
{

    //Bu entity denetlenebilir olmasın soft delete işlemine maruz kalmasın.
    //Yani Customerı silince veritabanından her yerdden silinsin istiyorum.
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string TcNo { get; set; }
    }
}
