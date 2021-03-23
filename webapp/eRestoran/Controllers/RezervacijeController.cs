using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eRestoran.Data;
using eRestoran.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using X.PagedList.Mvc.Core;
using X.PagedList;


namespace eRestoran.Controllers
{
    public class RezervacijeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<OnlineGost> _userManager;
        private readonly SignInManager<OnlineGost> _signInManager;
        public RezervacijeController(ApplicationDbContext context,UserManager<OnlineGost> userManager, SignInManager<OnlineGost> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [Authorize(Roles = "Korisnik")]
        // GET: Rezervacije
        public async Task<IActionResult> Index(int? page)
        {
            var appUser = await _userManager.GetUserAsync(User);
            List<string> rezervacijeUserNameovi = _context.RezervacijaStolova.Select(x => x.UserName).ToList();
            if (rezervacijeUserNameovi.Contains(appUser.UserName))
            {
                List<RezervacijaStolova> rezervacije = _context.RezervacijaStolova.Where(x => x.UserName == appUser.UserName).Select(x => new RezervacijaStolova
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    BrojOsoba = x.BrojOsoba,
                    BrojTelefona = x.BrojTelefona,
                    VrijemeRezervacije = x.VrijemeRezervacije
                }).ToList();
                return View(rezervacije.ToPagedList(page ?? 1, 3));
            }
            else
            {
                return View();
            }
            //return View(await _context.RezervacijaStolova.ToListAsync());
        }
        [Authorize(Roles = "Korisnik")]

        // GET: Rezervacije/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaStolova = await _context.RezervacijaStolova
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rezervacijaStolova == null)
            {
                return NotFound();
            }

            return View(rezervacijaStolova);
        }
        [Authorize(Roles = "Korisnik")]

        // GET: Rezervacije/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rezervacije/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrojOsoba,VrijemeRezervacije,BrojTelefona")] RezervacijaStolova rezervacijaStolova)
        {
            if (ModelState.IsValid)
            {
                var appUser = await _userManager.GetUserAsync(User);
                rezervacijaStolova.UserName = appUser?.UserName;
                _context.Add(rezervacijaStolova);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Korisnik")]

        // GET: Rezervacije/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaStolova = await _context.RezervacijaStolova.FindAsync(id);
            if (rezervacijaStolova == null)
            {
                return NotFound();
            }
            return View(rezervacijaStolova);
        }
        [Authorize(Roles = "Korisnik")]

        // POST: Rezervacije/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BrojOsoba,VrijemeRezervacije,BrojTelefona")] RezervacijaStolova rezervacijaStolova)
        {
            if (id != rezervacijaStolova.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rezervacijaStolova);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezervacijaStolovaExists(rezervacijaStolova.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rezervacijaStolova);
        }
        [Authorize(Roles = "Korisnik")]

        // GET: Rezervacije/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaStolova = await _context.RezervacijaStolova
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rezervacijaStolova == null)
            {
                return NotFound();
            }

            return View(rezervacijaStolova);
        }
        [Authorize(Roles = "Korisnik")]

        // POST: Rezervacije/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezervacijaStolova = await _context.RezervacijaStolova.FindAsync(id);
            _context.RezervacijaStolova.Remove(rezervacijaStolova);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RezervacijaStolovaExists(int id)
        {
            return _context.RezervacijaStolova.Any(e => e.Id == id);
        }
    }
}
