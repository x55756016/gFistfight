using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.DAL.Database;

namespace Project.UI.Controllers
{
    public class ShopController : Controller
    {
        private tmpmEntities2 db = new tmpmEntities2();

        // GET: /Shop/
        public async Task<ActionResult> Index()
        {
            return View(await db.xy_sp_equipment.ToListAsync());
        }

        // GET: /Shop/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            xy_sp_equipment xy_sp_equipment = await db.xy_sp_equipment.FindAsync(id);
            if (xy_sp_equipment == null)
            {
                return HttpNotFound();
            }
            return View(xy_sp_equipment);
        }

        // GET: /Shop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Shop/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="EquipmentID,EquipmentName,EquipmentType,gainType,gainValue,NeedLevel,Price")] xy_sp_equipment xy_sp_equipment)
        {
            if (ModelState.IsValid)
            {
                db.xy_sp_equipment.Add(xy_sp_equipment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(xy_sp_equipment);
        }

        // GET: /Shop/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            xy_sp_equipment xy_sp_equipment = await db.xy_sp_equipment.FindAsync(id);
            if (xy_sp_equipment == null)
            {
                return HttpNotFound();
            }
            return View(xy_sp_equipment);
        }

        // POST: /Shop/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="EquipmentID,EquipmentName,EquipmentType,gainType,gainValue,NeedLevel,Price")] xy_sp_equipment xy_sp_equipment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(xy_sp_equipment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(xy_sp_equipment);
        }

        // GET: /Shop/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            xy_sp_equipment xy_sp_equipment = await db.xy_sp_equipment.FindAsync(id);
            if (xy_sp_equipment == null)
            {
                return HttpNotFound();
            }
            return View(xy_sp_equipment);
        }

        // POST: /Shop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            xy_sp_equipment xy_sp_equipment = await db.xy_sp_equipment.FindAsync(id);
            db.xy_sp_equipment.Remove(xy_sp_equipment);
            await db.SaveChangesAsync();
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
