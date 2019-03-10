using Catalog.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Catalog.BLL
{
    public class EnrollmentBLL
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public /*dynamic*/  List<Course> CoursesList()
        {
            var courses = from s in db.Courses
                              select s;
            return courses.ToList();
        }

        public void EnrollmentAdd(int idCourse, string idUser, string serverMapPath/*, Grade? grade*/)
        {
            int idStudent = (from stud in db.Students
                             where stud.ApplicationUser.Id == idUser
                             select stud).ToList().First().StudentID/*.ApplicationUser.Id*/;
            if (CheckFileExist(idStudent, serverMapPath))
            {
                var enrollmentToUpdate = db.Enrollments.SingleOrDefault(b => b.CourseID == idCourse && b.StudentID == idStudent);
                if (enrollmentToUpdate == null)
                {
                    db.Enrollments.Add(new Enrollment
                    {
                        CourseID = idCourse,
                        StudentID = idStudent,
                        //Grade = grade
                    });
                }
                db.SaveChanges();
            }

        }
        //public bool CheckFileAndEdit(int id, string action)
        //{
        //    string path = "~/App_Data/uploads/id_photo_students.txt";
        //    if (!File.Exists(path))
        //    {
        //        File.Create(path);
        //        TextWriter tw = new StreamWriter(path);
        //        if (action.Equals("add"))
        //        {
        //            tw.WriteLine(id.ToString());
        //        }else if (action.Equals("delete"))
        //        {

        //        }

        //        tw.Close();
        //    }
        //    else if (File.Exists(path))
        //    {
        //        using (var tw = new StreamWriter(path, true))
        //        {
        //            tw.WriteLine(id.ToString());
        //            tw.Close();
        //        }
        //    }
        //    //string[] pdfFiles = Directory.GetFiles("~/App_Data/Uploads")
        //    //                         .Select(Path.GetFileName)
        //    //                         .ToArray();
        //    return false;
        //}
        public bool CheckFileExist(int id, string serverMapPath)
        {
            string[] pdfFiles = Directory.GetFiles(serverMapPath, "*.*")
                                    .Select(Path.GetFileName)
                                    .ToArray();
            for(int i = 0; i < pdfFiles.Length; i++)
            {
                string [] nameOfFile = pdfFiles[i].Split('.');
                if (nameOfFile[0].Contains(id.ToString()/* + ".jpg"*/))
                {
                    return true;
                }
            }

            return false;
        }
        public void EnrollmentDelete(int idCourse, string idUser)
        {
            int idStudent = (from stud in db.Students
                             where stud.ApplicationUser.Id == idUser
                             select stud).ToList().First().StudentID/*.ApplicationUser.Id*/;

            var enrollmentToUpdate = db.Enrollments.SingleOrDefault(b => b.CourseID == idCourse && b.StudentID == idStudent);
            if (enrollmentToUpdate != null)
            {
                db.Enrollments.Remove(enrollmentToUpdate);
            }
            db.SaveChanges();
        }

        public void EnrollmentUpload( HttpPostedFileBase file, string serverMapPath, int idStudent)
        {
            if (file != null && file.ContentLength > 0)
            {
                // extract only the filename
                var fileName = Path.GetExtension(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                //var path = Path.Combine(serverMapPath, idStudent + "_" + fileName);
                var path = Path.Combine(serverMapPath, idStudent + "" + fileName);
                file.SaveAs(path);
            }
        }
    }
}