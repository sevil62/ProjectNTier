using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
   public class AppUserProfileMap:BaseMap<AppUserProfile>
    {
        public AppUserProfileMap()
        {
            ToTable("Kullanıcı profili");
            Property(x => x.FirstName).HasColumnName("Kullanıcı İsmi").IsRequired();
            Property(x => x.LastName).HasColumnName("Kullanıcı Soyad").IsRequired();
            Property(x => x.Phone).HasColumnName("Kullanıcı telefon numarası");

        }
    }
}
