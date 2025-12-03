using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Entities.Models;

namespace Project.Configuration.Options
{
    public class BookTagConfiguration : BaseConfiguration<BookTag>
    {
        public override void Configure(EntityTypeBuilder<BookTag> builder)
        {
            base.Configure(builder);

            builder.Ignore(bt => bt.Id);

            builder.HasKey(x => new
            {
                x.TagId,
                x.BookId
            });
        }
    }
}
