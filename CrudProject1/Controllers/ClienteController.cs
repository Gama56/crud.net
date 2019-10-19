using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudProject1.Models;
using CrudProject1.Models.ViewModels;

namespace CrudProject1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ListClienteViewModels> lst;
            using (crudnetEntities DB = new crudnetEntities())
            {
                lst = (from d in DB.Cliente
                           select new ListClienteViewModels
                           {
                               Id = d.Id,
                               Nit = d.Nit,
                               Nombre = d.Nombre,
                               Apellido = d.Apellido,
                               Edad = d.Edad,
                               Fecha = d.Fecha
                           }).ToList();

            }
                return View(lst);
        }
        public ActionResult Nuevo()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(ClienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (crudnetEntities db = new crudnetEntities())
                    {
                        var oTabla = new Cliente();
                        oTabla.Id = model.Id;
                        oTabla.Nit = model.Nit;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.Edad = model.Edad;
                        oTabla.Fecha = model.Fecha;
                        db.Cliente.Add(oTabla);
                        db.SaveChanges();
                    }

                    return Redirect("~/Cliente/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Editar(int Id)
        {
            ClienteViewModel model = new ClienteViewModel();
            using (crudnetEntities db = new crudnetEntities())
            {
                var oTabla = db.Cliente.Find(Id);
                model.Id = oTabla.Id;
                model.Nit = oTabla.Nit;
                model.Nombre = oTabla.Nombre;
                model.Apellido = oTabla.Apellido;
                model.Edad = oTabla.Edad;
                model.Fecha = oTabla.Fecha;
                model.Id = oTabla.Id;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(ClienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (crudnetEntities db = new crudnetEntities())
                    {
                        var oTabla = db.Cliente.Find(model.Id);
                        oTabla.Id = model.Id;
                        oTabla.Nit = model.Nit;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.Edad = model.Edad;
                        oTabla.Fecha = model.Fecha;
                        db.Cliente.Add(oTabla);

                        db.Entry(oTabla).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/Cliente/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Buscar(ClienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (crudnetEntities db = new crudnetEntities())
                    {
                        var oTabla = db.Cliente.Find(model.Id);
                        oTabla.Id = model.Id;
                        oTabla.Nit = model.Nit;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.Edad = model.Edad;
                        oTabla.Fecha = model.Fecha;
                        //db.Cliente.Add(oTabla);
                    }
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        [HttpGet]
        public ActionResult Eliminar(int Id)
        {
            using (crudnetEntities db = new crudnetEntities())
            {

                var oTabla = db.Cliente.Find(Id);
                db.Cliente.Remove(oTabla);
                db.SaveChanges();
            }
            return Redirect("~/Cliente/");
        }
    }   
}

