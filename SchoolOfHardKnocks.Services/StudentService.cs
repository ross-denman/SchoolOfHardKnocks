using SchoolOfHardKnocks.Data;
using SchoolOfHardKnocks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOfHardKnocks.Services
{
    public class StudentService
    {
        private readonly Guid _userId;
        
        public StudentService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateStudent(StudentCreate model)
        {
            var entity = new Student()
            {
                StudentId = _userId,
                LastName = model.LastName,
                FirstName = model.FirstName,
                GradeLevel = model.GradeLevel,
                CreatedUtc = DateTimeOffset.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Students.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<StudentListItem> GetNotes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Students
                    .Where(e => e.StudentId == _userId)
                    .Select(
                        e =>
                        new StudentListItem
                        {
                            StudentId = e.StudentId,
                            LastName = e.LastName,
                            FirstName = e.FirstName,
                            GradeLevel = e.GradeLevel,
                            CreatedUtc = e.CreatedUtc
                        }
                        );
                return query.ToArray();
            }
        } 
    }
}
