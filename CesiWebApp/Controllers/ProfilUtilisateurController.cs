using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CesiWebApp.Data;
using CesiWebApp_Data;
using Microsoft.AspNetCore.Mvc;

namespace CesiWebApp.Controllers
{
    public class ProfilUtilisateurController : Controller
    {
        private readonly DefaultContext _context = null;
        public ProfilUtilisateurController(DefaultContext defaultContext)
        {
            this._context = defaultContext;
        }

        public IActionResult Index()
        {
            this.ViewBag.Title = "fdsfsdfdsfdsfds";
    
            return View();
        }
        public IActionResult AutrePage()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Utilisateur utilisateur)
        {
            if (utilisateur is null)
            {
                throw new ArgumentNullException(nameof(utilisateur));
            }
            this._context.Utilisateurs.Add(utilisateur);
            _context.SaveChanges();
            

            return RedirectToAction(nameof(All));
        }
        public IActionResult Delete(int id)
        {
           
            return View();
        }

        public IActionResult Edit(int id)
        {
            //Utilisateur utilisateur = this._context.Utilisateurs.First(item => item.Id == id);
 

            return View(this._context.Utilisateurs.First(item => item.Id == id));
        }       
        [HttpPost]
        public IActionResult Edit(Utilisateur utilisateur)
        {

            this._context.Utilisateurs.Update(utilisateur);
            this._context.SaveChanges();
            return View(utilisateur);
        }

        public IActionResult All() 
        {
            this.ViewBag.Titre = "Liste des profils";
            List<Utilisateur> listeUtilisateur = new List<Utilisateur>();
            listeUtilisateur.Add(new Utilisateur() { Id = 1, Nom = "Sanchez", Prenom = "Rick" });
            listeUtilisateur.Add(new Utilisateur() { Id = 1, Nom = "Sanchez", Prenom = "On s'assoit par terre :D" });
            var query = from Utilisateur in _context.Utilisateurs select Utilisateur;

            return View(query.ToList());



           // return View(listeUtilisateur);
    
        }
    }
}
