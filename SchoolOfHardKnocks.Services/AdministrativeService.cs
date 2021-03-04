using SchoolOfHardKnocks.Data;
using SchoolOfHardKnocks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Services
{
    public class AdministrativeService
    {
        private readonly Guid _userId;
        public AdministrativeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateAdministrative(AdministrativeCreate model)
        {
            var entity = new Administrative()
            {
                AdminId = _userId,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Title = model.Title,
                CreatedUtc = DateTimeOffset.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.AdministrativeStaff.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<AdministrativeListItem> GetAdmin()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .AdministrativeStaff
                    .Where(e => e.AdminId == _userId)
                    .Select(
                        e =>
                        new AdministrativeListItem
                        {
                            AdminId = e.AdminId,
                            LastName = e.LastName,
                            FirstName = e.FirstName,
                            Title = e.Title,
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();
            }
        }
    }
}
