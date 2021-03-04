using SchoolOfHardKnocks.Data;
using SchoolOfHardKnocks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Services
{
    public class SupportStaffService
    {
        private readonly Guid _userId;

        public SupportStaffService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateStudent(SupportStaffCreate model)
        {
            var entity = new Support()
            {
                SupportId = _userId,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Role = model.Role,
                CreatedUtc = DateTimeOffset.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.SupportStaff.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<SupportStaffListItem> GetStaff()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .SupportStaff
                    .Where(e => e.SupportId == _userId)
                    .Select(
                        e =>
                        new SupportStaffListItem
                        {
                            SupportId = e.SupportId,
                            LastName = e.LastName,
                            FirstName = e.FirstName,
                            Role = e.Role,
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();
            }
        }
    }
}

