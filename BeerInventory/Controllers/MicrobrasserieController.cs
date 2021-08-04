using Repository.IRepository;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Attributes;
using EFObjects.Tables;
using BeerInventory.Models;

namespace BeerInventory.Controllers
{
    public class MicrobrasserieController : Controller
    {
        //[Dependency] 
        private readonly IMicrobrasserieRepository _microbrasserieRepository;
        private readonly IRegionRepository _regionRepository;


        public MicrobrasserieController(IMicrobrasserieRepository microbrasserieRepository,
                                        IRegionRepository regionRepository)
        {
            this._microbrasserieRepository = microbrasserieRepository;
            this._regionRepository = regionRepository;
        }

        // GET: Microbrasserie
        public ActionResult Index()
        {
            IEnumerable<Microbrasserie> micros = this._microbrasserieRepository.GetMicrobrasserie();
            return View(micros);
        }
#
        public ActionResult Edit(int id)
        {
            MicrobrasserieModel micro = new MicrobrasserieModel()
            {
                micro = this._microbrasserieRepository.GetMicrobrasserie(id),
                _regions = this._regionRepository.GetRegions().ToList(),
            };
                
            return View(micro);
        }

        [HttpPost]
        public ActionResult Edit(Microbrasserie micro)
        {
            try
            {
                _microbrasserieRepository.UpdateMicrobrasserie(micro);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "Échec de l'enregistrement";
                return RedirectToAction("Edit", new { id = micro.Id });
            }
        }
    }
}