using System.Security.Claims;

namespace CollabriaPortal.Services
{
    public class LinkService
    {
        //Personal Links
        public string GetConsumerLinkForUser(ClaimsPrincipal user)
        {
            //test-bank
            if (user.HasClaim("groups", "454c7299-4de5-4716-b567-314a5fb5a48d"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/test-bank/personal";
            }

            //dev-cu
            else if (user.HasClaim("groups", "a1f6ceeb-429a-468b-a846-ac79f5d18c26"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/dev-cu/personal";
            }

            //Alterna Credit Union
            else if (user.HasClaim("groups", "578edee1-361e-4da6-ac0a-4edc659d87ea"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/alterna/personal";
            }

            //Access Credit Union
            else if (user.HasClaim("groups", "57666735-f9ac-4841-8449-501d9bcdde77"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/access-credit-union/personal";
            }

            //Caisse Financial Group
            else if (user.HasClaim("groups", "37cbfd30-c2e4-4e5f-83fa-4aba9ab8dd0c"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/caisse-financial-group/personal";
            }

            //Cambrian Credit Union
            else if (user.HasClaim("groups", "33889798-1034-4654-bc47-a942c6dd8252"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/cambrian-credit-union/personal";
            }

            //Coastal Community Credit Union
            else if (user.HasClaim("groups", "330a0bc9-48ae-4135-8349-5ecb86ee12fc"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/coastal-community-credit-union/personal";
            }

            //DUCA
            else if (user.HasClaim("groups", "7d87f9e7-b81a-4c89-bf8b-1dfce1198ebf"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/duca/personal";
            }

            //Envision Financial
            else if (user.HasClaim("groups", "0096b4d1-a408-4b7f-bc3c-7c0fa4fbcbb0"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/envision-financial/personal";
            }

            //FirstOntario Credit Union
            else if (user.HasClaim("groups", "a0ac92c5-f9b4-4c94-a619-bd3ebbd45cfe"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/firstontario-credit-union/personal";
            }

            //Innovation Federal Credit Union
            else if (user.HasClaim("groups", "ea7581ac-e9bc-457f-b46b-61f4f8ffb26a"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/innovation-federal-credit-union/personal";
            }

            //Interior Savings Credit Union
            else if (user.HasClaim("groups", "67d96d2a-7106-4f5f-ab5f-3c5df94933f5"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/interior-savings-credit-union/personal";
            }

            //Island Savings
            else if (user.HasClaim("groups", "489fcf56-978c-4b24-9e39-fc3c06c8d59c"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/island-savings/personal";
            }

            //Kawartha
            else if (user.HasClaim("groups", "01fb67f9-57f7-414d-a70d-2fe388cc6954"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/kawartha-credit-union/personal";
            }

            //Steinbach Credit Union
            else if (user.HasClaim("groups", "aca71926-1c58-47a8-9793-b38dcd61f824"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/steinbach-credit-union/personal";
            }
            return "https://default-link-if-no-group-matches";
        }

        //Business links
        public string GetBusinessLinkForUser(ClaimsPrincipal user)
        {
            //test-bank
            if (user.HasClaim("groups", "454c7299-4de5-4716-b567-314a5fb5a48d"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/test-bank/business";
            }

            //dev-cu
            else if (user.HasClaim("groups", "a1f6ceeb-429a-468b-a846-ac79f5d18c26"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/dev-cu/business";
            }

            //Alterna
            else if (user.HasClaim("groups", "578edee1-361e-4da6-ac0a-4edc659d87ea"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/alterna/business";
            }

            //Access Credit Union
            else if (user.HasClaim("groups", "57666735-f9ac-4841-8449-501d9bcdde77"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/access-credit-union/business";
            }

            //Caisse Financial Group
            else if (user.HasClaim("groups", "37cbfd30-c2e4-4e5f-83fa-4aba9ab8dd0c"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/caisse-financial-group/business";
            }

            //Cambrian Credit Union
            else if (user.HasClaim("groups", "33889798-1034-4654-bc47-a942c6dd8252"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/cambrian-credit-union/business";
            }

            //Coastal Community Credit Union
            else if (user.HasClaim("groups", "330a0bc9-48ae-4135-8349-5ecb86ee12fc"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/coastal-community-credit-union/business";
            }

            //DUCA
            else if (user.HasClaim("groups", "7d87f9e7-b81a-4c89-bf8b-1dfce1198ebf"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/duca/business";
            }

            //Envision Financial
            else if (user.HasClaim("groups", "0096b4d1-a408-4b7f-bc3c-7c0fa4fbcbb0"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/envision-financial/business";
            }

            //FirstOntario Credit Union
            else if (user.HasClaim("groups", "a0ac92c5-f9b4-4c94-a619-bd3ebbd45cfe"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/firstontario-credit-union/business";
            }

            //Innovation Federal Credit Union
            else if (user.HasClaim("groups", "ea7581ac-e9bc-457f-b46b-61f4f8ffb26a"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/innovation-federal-credit-union/business";
            }

            //Interior Savings Credit Union
            else if (user.HasClaim("groups", "67d96d2a-7106-4f5f-ab5f-3c5df94933f5"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/interior-savings-credit-union/business";
            }

            //Island Savings
            else if (user.HasClaim("groups", "489fcf56-978c-4b24-9e39-fc3c06c8d59c"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/island-savings/business";
            }

            //Kawartha
            else if (user.HasClaim("groups", "01fb67f9-57f7-414d-a70d-2fe388cc6954"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/kawartha-credit-union/business";
            }

            //Steinbach Credit Union
            else if (user.HasClaim("groups", "aca71926-1c58-47a8-9793-b38dcd61f824"))
            {
                return "https://app-7ffktjopn5s2y.azurewebsites.net/affiliate/steinbach-credit-union/business";
            }

            return "https://default-link-if-no-group-matches";
        }
    }
}
