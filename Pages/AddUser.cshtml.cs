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
        if (ModelState.IsValid)
        {
            string messageBody = $"New user added:\n\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nBranch Location: {BranchLocation}";
            SendEmail(messageBody);
        }


    }

    private void SendEmail(string messageBody)
    {
        var smtpClient = new SmtpClient("smtp.office365.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("brandon.morgado@collabriait.onmicrosoft.com", "password#"),
            EnableSsl = true,
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress("brandon.morgado@collabriait.onmicrosoft.com"),
            Subject = "New User Added",
            Body = messageBody,
            IsBodyHtml = false,
        };

        mailMessage.To.Add("recipient@example.com");

        smtpClient.Send(mailMessage);
    }

}
