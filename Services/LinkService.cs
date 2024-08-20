using System.Security.Claims;

namespace CollabriaPortal.Services
{
    public class LinkService
    {
        //Personal Links
        public string GetConsumerLinkForUser(ClaimsPrincipal user)
        {
            if (user.HasClaim("groups", "454c7299-4de5-4716-b567-314a5fb5a48d"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/test-bank/personal";
            }
            else if (user.HasClaim("groups", "a1f6ceeb-429a-468b-a846-ac79f5d18c26"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/dev-cu/personal";
            }

            return "https://default-link-if-no-group-matches";
        }

        //Business links
        public string GetBusinessLinkForUser(ClaimsPrincipal user)
        {
            if (user.HasClaim("groups", "454c7299-4de5-4716-b567-314a5fb5a48d"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/test-bank/business";
            }
            else if (user.HasClaim("groups", "a1f6ceeb-429a-468b-a846-ac79f5d18c26"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/dev-cu/business";
            }

            return "https://default-link-if-no-group-matches";
        }
    }
}
