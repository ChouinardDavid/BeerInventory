using EFObjects.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerInventory.Models
{
    public class MicrobrasserieModel
    {
        //private readonly IEnumerable<Region> _regions = _regionRepository.GetRegions().ToList();
        public IEnumerable<Region> _regions;

        public Microbrasserie micro;

        public IEnumerable<SelectListItem> regions
        {
            get { return _regions.Select(x => new SelectListItem{ Value = x.Id.ToString(),
                                                                  Text = x.Nom,
                                                                  Selected = (micro.Region.Id == x.Id)
                                                                  }).ToList();
            }
        }
    }
}