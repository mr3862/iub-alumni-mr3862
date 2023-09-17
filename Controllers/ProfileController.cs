using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IUBAlumniUSA.Data;
using IUBAlumniUSA.Models;
using IUBAlumniUSA.ViewModels;
using AutoMapper;
using Profile = IUBAlumniUSA.Models.Profile;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;
using IUBAlumniUSA.Services;
using static IUBAlumniUSA.Services.Utility;

namespace IUBAlumniUSA.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _imapper;
        private readonly IEmailSender _emailSender;
        public ProfileController(UserManager<IdentityUser> userManager, ApplicationDbContext context, IMapper imapper, IEmailSender emailSender)
        {
            _context = context;
            _imapper = imapper;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        // GET: Profiles
        //[Authorize(Roles = "SuperAdmin,Admin")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var prof = _context.Profiles.Where(p => p.IdentityUserId == user.Id).FirstOrDefault();

            if(prof==null || !prof.IsApproved )
            {
                return RedirectToAction("Index","Home");
                //return Unauthorized();
            }

            return _context.Profiles != null ?
                        View(await _context.Profiles.Where(p => p.IdentityUserId != "1").ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Profiles'  is null.");
        }

        // GET: Profiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Profiles == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        // GET: Profiles/Create
        public async Task<IActionResult> Create()
        {
            var user = await _userManager.GetUserAsync(User);
            var prof = _context.Profiles.Where(p => p.IdentityUserId == user.Id).FirstOrDefault();
            ProfileViewModel model;
            if (prof == null)
            {
                model = new ProfileViewModel();
            }
            else
            {
                model = _imapper.Map<ProfileViewModel>(prof);
            }
            model.SetContext(_context);
            /*
          model.BatchYearsSelectList = new List<SelectListItem>();
          for (var year = 1993;year < DateTime.Now.Year - 3; year++){
              var item = new SelectListItem(year.ToString(), year.ToString());
              model.BatchYearsSelectList.Add(item);
          }*/
            return View(model);
        }

        // POST: Profiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProfileViewModel profile)
        {
            if (ModelState.IsValid)
            {
                profile.SetContext(_context);
                var prof = _imapper.Map<Profile>(profile);
                var user = await _userManager.GetUserAsync(User);
                prof.IdentityUserId = user.Id;
                if (Request.Form.Files.Count > 0)
                {
                    IFormFile file = Request.Form.Files.FirstOrDefault();
                    using (var dataStream = new MemoryStream())
                    {
                        await file.CopyToAsync(dataStream);
                        prof.ProfilePicture = dataStream.ToArray();
                    }
                    // await _userManager.UpdateAsync(user);
                }

                var existProf = _context.Profiles.Where(p => p.IdentityUserId == user.Id).FirstOrDefault();
                if (existProf != null)
                {
                    prof.Id = existProf.Id;
                    existProf.FirstName = prof.FirstName;
                    existProf.LastName = prof.LastName;
                    existProf.Country = prof.Country;
                    existProf.BatchYear = prof.BatchYear;
                    existProf.BatchTerm = prof.BatchTerm;
                    existProf.Address = prof.Address;
                    existProf.City = prof.City;
                    existProf.ProvinceState = prof.ProvinceState;
                    existProf.ZipPostalCode = prof.ZipPostalCode;
                    existProf.ProfilePicture = prof.ProfilePicture;
                    existProf.Degree = prof.Degree;

                }
                else
                {
                    _context.Add(prof);
                }
                await _context.SaveChangesAsync();

                string hashCode = CreateHashCode(user.Id + prof.Id);

                //var callbackUrl = Url.Page(
                //    "/Profile/Approve",
                //    pageHandler: null,
                //    values: new { area = "", userId = user.Id, code = hashCode },
                //    protocol: Request.Scheme);

                var callbackUrl = Url.ActionLink("Approve", "Profile", new { area = "", userId = user.Id, code = hashCode });

                await _emailSender.SendEmailAsync("mr3862@columbia.edu", "Confirm your email",
                    $"Please approve the profile of {prof.FirstName + " " + prof.LastName} <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }

        private string CreateHashCode(string userId)
        {
            var code = Encoding.UTF8.GetBytes(userId);
            code = MD5.Create().ComputeHash(code);
            var hashCode = WebEncoders.Base64UrlEncode(code);
            return hashCode;
        }

        // GET: Profiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Profiles == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles.FindAsync(id);
            if (profile == null)
            {
                return NotFound();
            }
            
        var  model = _imapper.Map<ProfileViewModel>(profile);        
        model.SetContext(_context);

         return View(model);
        }

        // POST: Profiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProfileViewModel model)
        {
            model.SetContext(_context);
            var profile = _imapper.Map<Profile>(model);
            if (id != profile.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (Request.Form.Files.Count > 0)
                {
                    IFormFile file = Request.Form.Files.FirstOrDefault();
                    using (var dataStream = new MemoryStream())
                    {
                        await file.CopyToAsync(dataStream);
                        profile.ProfilePicture = dataStream.ToArray();
                    }
                    // await _userManager.UpdateAsync(user);
                }

                try
                {
                    var entry = _context.Entry(profile);
                    entry.State = EntityState.Modified;
                    entry.Property("IdentityUserId").IsModified = false;
                    entry.Property("IsApproved").IsModified = false;
                    //_context.Update(profile);


                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfileExists(profile.Id))
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
            return View(model);
        }
/*
        // GET: Profiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Profiles == null)
            {
                return NotFound();
            }

            var profile = await _context.Profiles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (profile == null)
            {
                return NotFound();
            }

            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Profiles == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Profiles'  is null.");
            }
            var profile = await _context.Profiles.FindAsync(id);
            if (profile != null)
            {
                _context.Profiles.Remove(profile);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
*/
        private bool ProfileExists(int id)
        {
            return (_context.Profiles?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> Approve(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }
            var user = await _userManager.FindByIdAsync(userId);
            var prof = _context.Profiles.Where(p => p.IdentityUserId == userId).FirstOrDefault();

            if (user == null || prof == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            string hashCode = CreateHashCode(userId + prof.Id);

            var message = "Error matching code.";
            if (hashCode == code)
            {
                message = "Code matching";

                if (prof != null)
                {
                    prof.IsApproved = true;
                }
                await _context.SaveChangesAsync();
                return View();
            }
            else
            {
                return NotFound($"Unable to match code.");
            }
            //var result = await _userManager.ConfirmEmailAsync(user, code);
            //StatusMessage = result.Succeeded ? "Thank you for confirming your email." : "Error confirming your email.";

            return View();
        }

        public async Task<IActionResult> PendigApproval()
        {
            return View();
        }
    }
}
