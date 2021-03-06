﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Catalog.BLL;
using Catalog.Models;
using Microsoft.AspNet.Identity;

namespace Catalog.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Student
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var students = from s in db.Students
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstMidName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }
            return View(students.ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,LastName,FirstMidName,EnrollmentDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        //GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }




        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "StudentID,LastName,FirstMidName,EnrollmentDate")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(student).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(student);
        //}

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id) //security methode to prevent overposting
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var studentToUpdate = db.Students.Find(id);
            if (TryUpdateModel(studentToUpdate, "",
               new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
            {
                try
                {
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(studentToUpdate);
        }
        // GET: Student/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        // POST: Student/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Student student = db.Students.Find(id);
        //    db.Students.Remove(student);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Student student = db.Students.Find(id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        //[ActionName("Game")]
         public ActionResult Game()  
         {
            GameBLL gameBLL = new GameBLL();
            List<Tuple<Student, Student>> listOfMatches =  gameBLL.GenerateRandomPairs();
            return View(listOfMatches);
        }

        public ActionResult CoursesList()  /*EnrollmentToCourse()*/
        {
            EnrollmentBLL enrollmentBLL = new EnrollmentBLL();
            var enrollments= enrollmentBLL.CoursesList();
            return View(enrollments);
        }

        public ActionResult EnrollmentAdd(int idCourse, string idUser) 
        {
            var serverMapPath = Server.MapPath("~/App_Data/uploads");
            EnrollmentBLL enrollmentBLL = new EnrollmentBLL();
            enrollmentBLL.EnrollmentAdd( idCourse, idUser, serverMapPath/*, grade*/);
            return RedirectToAction("CoursesList", "Student");
        }
        //public ActionResult EnrollmentUpload(string idUser)
        //{
        //    EnrollmentBLL enrollmentBLL = new EnrollmentBLL();
        //    enrollmentBLL.EnrollmentUpload(idUser/*, grade*/);
        //    return RedirectToAction("CoursesList", "Student");
        //}
        

        public ActionResult EnrollmentDelete(int idCourse, string idUser)
        {
           // string idUser = User.Identity.GetUserId();
            EnrollmentBLL enrollmentBLL = new EnrollmentBLL();
            enrollmentBLL.EnrollmentDelete(idCourse, idUser/*, grade*/);
            return RedirectToAction("CoursesList", "Student");
        }
        [HttpPost]
        public ActionResult EnrollmentUpload(HttpPostedFileBase file, int idStudent)
        {
            var serverMapPath = Server.MapPath("~/App_Data/uploads");
            EnrollmentBLL enrollmentBLL = new EnrollmentBLL();
            enrollmentBLL.EnrollmentUpload(file, serverMapPath, idStudent);
            return RedirectToAction("Index");
        }
        //[HttpPost, ActionName("AddGrade")]
        //[ValidateAntiForgeryToken]
        public ActionResult AddGrade(int idCourse, int idStudent, Grade grade) //security methode to prevent overposting
        {
            bool empty = false;
            //int idStudent = 1;
            //int idCourse = 2021;
            //var grade = Grade.C;
            //if (idCourse == 0 /*idStudent == null || idCourse == null || grade == null*/)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //var result = db.Books.SingleOrDefault(b => b.BookNumber == bookNumber);
            //if (result != null)
            //{
            //    result.SomeValue = "Some new value";
            //    db.SaveChanges();
            //}

            var enrollmentToUpdate = db.Enrollments.SingleOrDefault(b => b.CourseID == idCourse && b.StudentID == idStudent);
            // var enrollmentToUpdate = db.Enrollments.Find(courseID);
            if (enrollmentToUpdate == null)
            {
                db.Enrollments.Add(new Enrollment()
                {
                    StudentID = idStudent,
                    CourseID = idCourse,
                    Grade = grade,
                    //EnrollmentID = 44444

                });
                empty = true;
                db.SaveChanges();
            }
            else
            {
                enrollmentToUpdate.Grade = grade;
            }
            if (!empty && TryUpdateModel(enrollmentToUpdate, "",
               new string[] { "CourseID", "StudentID", "Grade" }))
            {
                try
                {
                    db.SaveChanges();

                    //return RedirectToAction("Details/" + idStudent);
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(enrollmentToUpdate);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
