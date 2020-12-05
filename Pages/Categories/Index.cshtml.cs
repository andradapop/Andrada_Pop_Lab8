using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Andrada_Pop_Lab8.Data;
using Andrada_Pop_Lab8.Models;

namespace Andrada_Pop_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Andrada_Pop_Lab8.Data.Andrada_Pop_Lab8Context _context;

        public IndexModel(Andrada_Pop_Lab8.Data.Andrada_Pop_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
               // .Include(b => b.Book)
               // .Include(b => b.Category).ToListAsync();
        }
    }
}
