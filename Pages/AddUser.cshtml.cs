using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;


public class AddUserModel : PageModel
{

    
    [BindProperty]
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [BindProperty]
    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [BindProperty]
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [BindProperty]
    [Required]
    [Display(Name = "Branch Location")]
    public string BranchLocation { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        

       
    }

    private void SendEmail(string messageBody)
    {
       
    }

}
