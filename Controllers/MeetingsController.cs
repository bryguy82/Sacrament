using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sacrament.Models;

namespace Sacrament.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly SacramentContext _context;

        public MeetingsController(SacramentContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Meeting.ToListAsync());
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            List<SelectListItem> hymn_list = new List<SelectListItem>()
            {
                new SelectListItem { Text = "High on the Mountain Top", Value = "5" },
                new SelectListItem { Text = "I Saw a Mighty Angel Fly", Value = "15" },
                new SelectListItem { Text = "We Thank Thee, O God, for a Prophet", Value = "19" },
                new SelectListItem { Text = "Christ the Lord Is Risen Today", Value = "200" },
            };

            List<SelectListItem> topic_list = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Faith" },
                new SelectListItem { Text = "Repentance" },
                new SelectListItem { Text = "Holy Ghost" },
                new SelectListItem { Text = "Baptism" },
            };

            ViewBag.Hymns = hymn_list;
            ViewBag.Topics = topic_list;

            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Preside,Conduct,MeetingDate,OpeningPrayer,ClosingPrayer,Hymn_1Num,Hymn_1,Hymn_2Num,Hymn_2,Hymn_3Num,Hymn_3,Hymn_4Num,Hymn_4,FirstName_1,LastName_1,FirstName_2,LastName_2,FirstName_3,LastName_3,FirstName_4,LastName_4,Topic_1,Topic_2,Topic_3,Topic_4")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Preside,Conduct,MeetingDate,OpeningPrayer,ClosingPrayer,Hymn_1Num,Hymn_1,Hymn_2Num,Hymn_2,Hymn_3Num,Hymn_3,Hymn_4Num,Hymn_4,FirstName_1,LastName_1,FirstName_2,LastName_2,FirstName_3,LastName_3,FirstName_4,LastName_4,Topic_1,Topic_2,Topic_3,Topic_4")] Meeting meeting)
        {
            if (id != meeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.ID))
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
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meeting = await _context.Meeting.FindAsync(id);
            _context.Meeting.Remove(meeting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
            return _context.Meeting.Any(e => e.ID == id);
        }
    }
}
