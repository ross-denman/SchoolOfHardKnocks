using Microsoft.AspNet.Identity;
using SchoolOfHardKnocks.Models;
using SchoolOfHardKnocks.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolOfHardKnocks___Mail_and_messenger_API.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {
        public IHttpActionResult Get()
        {
            StudentService studentService = CreateStudentService();
            var students = studentService.GetStudents();
            return Ok(students);
        }

        //public IHttpActionResult Get(int id)
        //{
        //    StudentService studentService = CreateStudentService();
        //    var student = studentService.GetStudentById(id);
        //    return Ok(student);
        //}

        public IHttpActionResult Post(StudentCreate student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateStudentService();

            if (!service.CreateStudent(student))
                return InternalServerError();

            return Ok();
        }
        private StudentService CreateStudentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var studentService = new StudentService(userId);
            return studentService;
        }

        //public IHttpActionResult Put(StudentEdit note)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var service = CreateStudentService();

        //    if (!service.UpdateStudent(student))
        //        return InternalServerError();

        //    return Ok();
        //}


    }

}
