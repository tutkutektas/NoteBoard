using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using NoteBoard.Model;

namespace NoteBoard.DAL.Mapping
{
    class UserMapping:EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            Property(a => a.FirstName).IsRequired().HasMaxLength(20);
            Property(a => a.LastName).IsRequired().HasMaxLength(30);
            Property(a => a.UserName).IsRequired().HasMaxLength(18);
            HasKey(u => u.UserID);
            Property(u => u.UserID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Map(a => a.MapInheritedProperties());//Kalıtım aldıklarımızı yazdırdı
            HasIndex(a => a.UserName).IsUnique();//bir kullacıadından 1 tane olacak.


        }
    }
}
