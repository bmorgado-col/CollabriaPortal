using System.Security.Claims;

namespace CollabriaPortal.Services
{
    public class LinkService
    {
        public string GetConsumerLinkForUser(ClaimsPrincipal user)
        {
            if (user.HasClaim("groups", "454c7299-4de5-4716-b567-314a5fb5a48d"))
            {
                return "https://collabria-agilitycms-git-uat-collabria-financial.vercel.app/affiliate/test-bank/personal";
            }
            else if (user.HasClaim("groups", "a1f6ceeb-429a-468b-a846-ac79f5d18c26"))
            {
                return "https://collabria-agilitycms-git-uat-collabria-financial.vercel.app/affiliate/dev-cu/personal";
            }

            return "https://default-link-if-no-group-matches";
        }

        public string GetBusinessLinkForUser(ClaimsPrincipal user)
        {
            if (user.HasClaim("groups", "454c7299-4de5-4716-b567-314a5fb5a48d"))
            {
                return "https://collabria-agilitycms-git-uat-collabria-financial.vercel.app/affiliate/test-bank/business";
            }
            else if (user.HasClaim("groups", "a1f6ceeb-429a-468b-a846-ac79f5d18c26"))
            {
                return "https://collabria-agilitycms-git-uat-collabria-financial.vercel.app/affiliate/dev-cu/business";
            }

            return "https://default-link-if-no-group-matches";
        }
    }
}
