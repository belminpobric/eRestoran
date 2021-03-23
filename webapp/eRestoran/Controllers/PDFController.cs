using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.Data;
using eRestoran.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;

namespace eRestoran.Controllers
{
    public class PDFController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PDFController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult MeniPDF()
        {
            MeniPDFVM pDFVM = new MeniPDFVM
            {
                TjesteninaRows = _context.Meni.Include(x => x.Kategorija).Where(x => x.Kategorija.NazivKategorije == "Tjestenina").Select(i => new MeniPDFVM.RowTjestenina
                {
                    ID = i.Id,
                    KategorijaID = i.KategorijaID,
                    Cijena = i.Cijena,
                    LinkZaSliku = i.LinkZaSliku,
                    Naziv = i.Naziv
                }).ToList(),
                BeefsteakRows = _context.Meni.Include(x => x.Kategorija).Where(x => x.Kategorija.NazivKategorije == "Beefsteak").Select(i => new MeniPDFVM.RowBeefsteak
                {
                    ID = i.Id,
                    KategorijaID = i.KategorijaID,
                    Cijena = i.Cijena,
                    LinkZaSliku = i.LinkZaSliku,
                    Naziv = i.Naziv
                }).ToList(),
                SendviciRows = _context.Meni.Include(x => x.Kategorija).Where(x => x.Kategorija.NazivKategorije == "Sendvici").Select(i => new MeniPDFVM.RowSendvici
                {
                    ID = i.Id,
                    KategorijaID = i.KategorijaID,
                    Cijena = i.Cijena,
                    LinkZaSliku = i.LinkZaSliku,
                    Naziv = i.Naziv
                }).ToList(),
                SchnitzelRows = _context.Meni.Include(x => x.Kategorija).Where(x => x.Kategorija.NazivKategorije == "Schnitzel").Select(i => new MeniPDFVM.RowSchnitzel
                {
                    ID = i.Id,
                    KategorijaID = i.KategorijaID,
                    Cijena = i.Cijena,
                    LinkZaSliku = i.LinkZaSliku,
                    Naziv = i.Naziv
                }).ToList(),
                DesertsRows = _context.Meni.Include(x => x.Kategorija).Where(x => x.Kategorija.NazivKategorije == "Deserti").Select(i => new MeniPDFVM.RowDeserts
                {
                    ID = i.Id,
                    KategorijaID = i.KategorijaID,
                    Cijena = i.Cijena,
                    LinkZaSliku = i.LinkZaSliku,
                    Naziv = i.Naziv
                }).ToList()
            };
            return new ViewAsPdf("MeniPDF", pDFVM);
        }
    }
}
