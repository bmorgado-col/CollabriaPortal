using Azure.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Models;
using Microsoft.Graph;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;


//Denies user page access if they are not part of the Credit Union Portal Admins group
[Authorize(Policy = "CollabriaAdminAccess")]
public class AddUserModel : PageModel
{
    private readonly AzureAdOptions _azureAdOptions;

    public AddUserModel(IOptions<AzureAdOptions> azureAdOptions)
    {
        _azureAdOptions = azureAdOptions.Value;
    }

    [BindProperty]
    [Required]
    [Display(Name = "First Name")]
    public string? FirstName { get; set; }

    [BindProperty]
    [Required]
    [Display(Name = "Last Name")]
    public string? LastName { get; set; }

    [BindProperty]
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [BindProperty]
    [Required]
    [Display(Name = "Branch Location")]
    public string? BranchLocation { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            string messageBody = $"New user added:\n\nFirst Name: {FirstName}\nLast Name: {LastName}\nEmail: {Email}\nBranch Location: {BranchLocation}";
            await SendEmailAsync(messageBody);
            return RedirectToPage("Success"); // Redirect to a success page or show a success message
        }

        return Page();
    }

    private async Task SendEmailAsync(string messageBody)
    {
 //       var clientSecretCredential = new ClientSecretCredential(
 //    _azureAdOptions.TenantId,
 //    _azureAdOptions.ClientId,
 //    _azureAdOptions.ClientSecret
 //);

 //       var graphClient = new GraphServiceClient(clientSecretCredential);

 //       var message = new Message
 //       {
 //           Subject = "New User Registration",
 //           Body = new ItemBody
 //           {
 //               ContentType = BodyType.Text,
 //               Content = messageBody
 //           },
 //           ToRecipients = new List<Recipient>
 //       {
 //           new Recipient
 //           {
 //               EmailAddress = new EmailAddress
 //               {
 //                   Address = "brandon.morgado@collabriait.onmicrosoft.com"
 //               }
 //           }
 //       }
 //       };

 //       try
 //       {
 //           // Use the SendMail method on the GraphServiceClient
 //           await graphClient.Me.SendMail(message, false).Request().PostAsync();
 //       }
 //       catch (ServiceException ex)
 //       {
 //           // Log the error or handle it as needed
 //           Console.WriteLine($"Error sending email: {ex.Message}");
 //           throw; // Optionally rethrow the exception
 //       }
    }
}
