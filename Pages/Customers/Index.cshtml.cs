using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VitecovitchFinale.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VitecovitchFinale.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly VitecovitchFinale.Models.VitecovitchFinaleContext _context;

        public IndexModel(VitecovitchFinale.Models.VitecovitchFinaleContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Subscribtions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CustomerSubscribtion { get; set; }
        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> subscribtionQuery = from c in _context.Customer
                                            orderby c.Subscribtion
                                            select c.Subscribtion;

            var customers = from c in _context.Customer
                         select c;

            if (!string.IsNullOrEmpty(SearchString))
            {
                customers = customers.Where(s => s.CustomerName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CustomerSubscribtion))
            {
                customers = customers.Where(x => x.Subscribtion == CustomerSubscribtion);
            }
            Subscribtions = new SelectList(await subscribtionQuery.Distinct().ToListAsync());
            Customer = await customers.ToListAsync();
        }
    }
}
