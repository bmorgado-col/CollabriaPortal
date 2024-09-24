using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CollabriaPortal.Pages
{

    //Denies user page access if they are not part of the Credit Union Portal Admins group
    [Authorize(Policy = "CollabriaAdminAccess")]
    public class DeleteUserModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
