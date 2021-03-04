using SchoolOfHardKnocks.Data;
using SchoolOfHardKnocks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Services
{
    public class FacultyService
    {
        private readonly Guid _userId;
        
        public FacultyService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateFaculty(FacultyCreate model)
        {
            var entity = new Faculty()
            {
                FacultyId = _userId,
                LastName = model.LastName,
                FirstName = model.FirstName,
                Dept = model.Dept,
                CreatedUtc = DateTimeOffset.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.FacultyStaff.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<FacultyListItem> GetFaculty()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .FacultyStaff
                    .Where(e => e.FacultyId == _userId)
                    .Select(
                        e =>
                        new FacultyListItem
                        {
                            FacultyId = e.FacultyId,
                            LastName = e.LastName,
                            FirstName = e.FirstName,
                            Dept = e.Dept,
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();
            }
        } 
    }
}
