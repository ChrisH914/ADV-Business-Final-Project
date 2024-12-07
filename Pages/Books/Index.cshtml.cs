using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ADV_Business_Final_Project;

namespace ADV_Business_Final_Project.Pages_Books
{
    public class IndexModel : PageModel
    {
        private readonly ADV_Business_Final_Project.LibraryContext _context;

        public IndexModel(ADV_Business_Final_Project.LibraryContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
