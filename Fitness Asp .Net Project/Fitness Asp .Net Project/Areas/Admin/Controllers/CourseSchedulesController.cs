using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fitness_Asp.Net_Project.Areas.Admin.Models;
using Fitness_Asp.Net_Project.DAL;

namespace Fitness_Asp.Net_Project.Areas.Admin.Controllers
{
    public class CourseSchedulesController : Controller
    {
        private Fitness db = new Fitness();

        // GET: Admin/CourseSchedules
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: Admin/CourseSchedules/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSchedules courseSchedules = db.courseSchedules.Find(id);
            if (courseSchedules == null)
            {
                return HttpNotFound();
            }
            return View(courseSchedules);
        }

        // GET: Admin/CourseSchedules/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.courses, "Id", "CourseName");
            ViewBag.DayId = new SelectList(db.days, "Id", "Name");
            ViewBag.RoomId = new SelectList(db.rooms, "Id", "RoomName");
            ViewBag.TrainerId = new SelectList(db.trainers, "Id", "TrainerName");
            var courseSchedules = db.courseSchedules.Include(c => c.Course).Include(c => c.Day).Include(c => c.Room).Include(c => c.Trainer).ToList();
            ViewBag.Schedule = courseSchedules;
            return View();
        }

        // POST: Admin/CourseSchedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CourseId,TrainerId,RoomId,From,To,DayId")] CourseSchedules courseSchedules)
        {
            if (ModelState.IsValid)
            {
                db.courseSchedules.Add(courseSchedules);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            ViewBag.CourseId = new SelectList(db.courses, "Id", "CourseName", courseSchedules.CourseId);
            ViewBag.DayId = new SelectList(db.days, "Id", "Name", courseSchedules.DayId);
            ViewBag.RoomId = new SelectList(db.rooms, "Id", "RoomName", courseSchedules.RoomId);
            ViewBag.TrainerId = new SelectList(db.trainers, "Id", "TrainerName", courseSchedules.TrainerId);
            return View(courseSchedules);
        }

        // GET: Admin/CourseSchedules/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSchedules courseSchedules = db.courseSchedules.Find(id);
            if (courseSchedules == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.courses, "Id", "CourseName", courseSchedules.CourseId);
            ViewBag.DayId = new SelectList(db.days, "Id", "Name", courseSchedules.DayId);
            ViewBag.RoomId = new SelectList(db.rooms, "Id", "RoomName", courseSchedules.RoomId);
            ViewBag.TrainerId = new SelectList(db.trainers, "Id", "TrainerName", courseSchedules.TrainerId);
            return View(courseSchedules);
        }

        // POST: Admin/CourseSchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CourseId,TrainerId,RoomId,From,To,DayId")] CourseSchedules courseSchedules)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseSchedules).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.courses, "Id", "CourseName", courseSchedules.CourseId);
            ViewBag.DayId = new SelectList(db.days, "Id", "Name", courseSchedules.DayId);
            ViewBag.RoomId = new SelectList(db.rooms, "Id", "RoomName", courseSchedules.RoomId);
            ViewBag.TrainerId = new SelectList(db.trainers, "Id", "TrainerName", courseSchedules.TrainerId);
            return View(courseSchedules);
        }

        // GET: Admin/CourseSchedules/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseSchedules courseSchedules = db.courseSchedules.Find(id);
            if (courseSchedules == null)
            {
                return HttpNotFound();
            }
            return View(courseSchedules);
        }

        // POST: Admin/CourseSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseSchedules courseSchedules = db.courseSchedules.Find(id);
            db.courseSchedules.Remove(courseSchedules);
            db.SaveChanges();
            return RedirectToAction("Index");
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
