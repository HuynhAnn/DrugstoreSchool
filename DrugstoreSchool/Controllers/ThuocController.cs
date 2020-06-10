using DrugstoreSchool.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugstoreSchool.Controllers
{
    public class ThuocController : Controller
    {
        // GET: Thuoc
        public ActionResult ListThuoc()
        {
            var thuocs = new List<string>();
            thuocs.Add("Thuốc đau dạ dày ");
            thuocs.Add("Thuốc đau đầu ");
            thuocs.Add("Thuốc mát gan ");
            ViewBag.Thuocs = thuocs;
            return View();
        }
        public ActionResult ListThuocModel()
        {
            var thuocs = new List<Thuoc>();
            thuocs.Add(new Thuoc(1, "Thuốc đau dạ dày", "Nhóm A","Vỉ x 12 Viên","Việt Nam","19/2/2020","/Content/Images/ThuocDauDaDay.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc đau đầu", "Nhóm B", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocDauDau.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc mát gan", "Nhóm C", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocMatGan.png"));

            return View(thuocs);
        }

        //Get Thuoc/EditThuoc/Id
        
        public ActionResult EditThuoc(int id)
        {
            var thuocs = new List<Thuoc>();
            thuocs.Add(new Thuoc(1, "Thuốc đau dạ dày", "Nhóm A", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocDauDaDay.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc đau đầu", "Nhóm B", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocDauDau.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc mát gan", "Nhóm C", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocMatGan.png"));
            //Check if not exit
            Thuoc thuoc = new Thuoc();
            foreach(Thuoc b in thuocs)
            {

                    thuoc = b;
                    break;
                
            }
            if(thuoc==null)
            {
                return HttpNotFound();
            }
            return View(thuoc);
        }
        //Post: Thuoc/EditThuoc/Id
        [HttpPost, ActionName("EditThuoc")]
        [ValidateAntiForgeryToken]

        public ActionResult EditThuoc(int id,string NhomThuoc1,string DangThuoc1,string SanXuat1,string DangKy1,string Images_cover1)
        {
            var thuocs = new List<Thuoc>();
            thuocs.Add(new Thuoc(1, "Thuốc đau dạ dày", "Nhóm A", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocDauDaDay.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc đau đầu", "Nhóm B", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocDauDau.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc mát gan", "Nhóm C", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocMatGan.png"));

            Thuoc thuoc = new Thuoc();
            foreach (Thuoc b in thuocs)
            {
                if (b.Id == id)
                {
                    b.NhomThuoc1 = NhomThuoc1;
                    b.DangThuoc1 = DangThuoc1;
                    b.SanXuat1 = SanXuat1;
                    b.DangKy1 = DangKy1;
                    b.Image_cover1 = Images_cover1;
                    break;
                }
            }
            if (thuoc == null)
            {
                return HttpNotFound();
            }
            

            return View("ListThuocModel", thuocs);
        }
        public ActionResult CreateThuoc()
        {
            return View();

        }
        [HttpPost,ActionName("CreateThuoc")]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include ="Id,ThanhPhan,NhomThuoc,DangThuoc,SanXuat,DangKy,ImagesCover")]Thuoc thuoc)
        {
            var thuocs = new List<Thuoc>();
            thuocs.Add(new Thuoc(1, "Thuốc đau dạ dày", "Nhóm A", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocDauDaDay.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc đau đầu", "Nhóm B", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocDauDau.jpg"));
            thuocs.Add(new Thuoc(1, "Thuốc mát gan", "Nhóm C", "Vỉ x 12 Viên", "Việt Nam", "19/2/2020", "/Content/Images/ThuocMatGan.png"));
            try
            {
                if(ModelState.IsValid)
                {
                    thuocs.Add(thuoc);
                }
            }
            catch(RetryLimitExceededException )
            {
                ModelState.AddModelError("", "Error Save Data");
            }
            return View("ListThuocModel",thuocs);
        }
    }
}