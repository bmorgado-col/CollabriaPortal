using Microsoft.AspNetCore.Mvc.RazorPages;
using CollabriaPortal.Services; // Ensure this matches your namespace




public class IndexModel : PageModel
{
    private readonly LinkService _linkService;

    public string ConsumerLink { get; set; }
    public string BusinessLink { get; set; }

    public IndexModel(LinkService linkService)
    {
        _linkService = linkService;
    }

    public void OnGet()
    {
         
        ConsumerLink = _linkService.GetConsumerLinkForUser(User);
        BusinessLink = _linkService.GetBusinessLinkForUser(User);
    }
}
