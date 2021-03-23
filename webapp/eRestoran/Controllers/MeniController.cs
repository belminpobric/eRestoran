using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Data;
using eRestoran.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eRestoran.Controllers
{
    public class MeniController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MeniController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string naziv)
        {
            bool ImaLiJela = false;
            MeniVM menivm = new MeniVM
            {
                Rows = _context.Meni.Select(x => new MeniVM.Row
                {
                    Cijena = x.Cijena,
                    KategorijaID = x.KategorijaID,
                    LinkZaSliku = x.LinkZaSliku,
                    Naziv = x.Naziv,
                    ID = x.Id
                }).ToList(),
                
            };
            if (naziv == null)
            {
                return View(menivm);

            }
            //provjera da li je pretraga po nazivu jela 
            foreach (var item in menivm.Rows)
            {
                if(item.Naziv.ToLower().Contains(naziv.ToLower()))
                {
                    ImaLiJela = true;
                    MeniVM pretraga = new MeniVM
                    {
                        Rows = _context.Meni.Where(s=>s.Naziv.ToLower().Contains(naziv.ToLower())).Select(x => new MeniVM.Row
                        {
                            Cijena = x.Cijena,
                            KategorijaID = x.KategorijaID,
                            LinkZaSliku = x.LinkZaSliku,
                            Naziv = x.Naziv,
                            ID = x.Id
                        }).ToList()
                    };
                    return View(pretraga);

                }
            }
            // ako je ImaLiJela false onda je odabir po kategoriji
            if(ImaLiJela == false)
            {
                MeniVM mvm = new MeniVM
                {
                    Rows = _context.Meni.Include(i => i.Kategorija).Where(s => s.Kategorija.NazivKategorije.ToLower() == naziv.ToLower()).Select(x => new MeniVM.Row
                    {
                        Cijena = x.Cijena,
                        KategorijaID = x.KategorijaID,
                        LinkZaSliku = x.LinkZaSliku,
                        Naziv = x.Naziv,
                        ID = x.Id
                    }).ToList()
                };
                return View(mvm);
            }
            return NotFound();
        }
        public IActionResult Detalji(int id)
        {
            var jelo = _context.Meni.Find(id);
            if (jelo != null)
            {
                DetaljiStavkeVM detalji = new DetaljiStavkeVM
                {
                    ID = jelo.Id,
                    LinkZaSliku = jelo.LinkZaSliku,
                    Naziv = jelo.Naziv,
                    Opis = jelo.Opis
                };
                return View(detalji);
            }
            return NotFound();
        }

    }
}
