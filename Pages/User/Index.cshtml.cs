using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Api_ExampleASP.Models;

namespace api_exampleASP.Pages_User
{
    public class IndexModel : PageModel
    {
        private readonly Api_ExampleASP.Models.PeopleContext _context;

        public IndexModel(Api_ExampleASP.Models.PeopleContext context)
        {
            _context = context;
        }

        public new IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.Users.ToListAsync();
        }
    }
}
