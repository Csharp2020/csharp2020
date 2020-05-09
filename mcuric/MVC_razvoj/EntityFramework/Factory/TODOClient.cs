using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public partial class APIClient

    {
        public async Task<List<TODO>> GetUsers()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "TodoItems"));
            return await GetAsync<List<TODO>>(requestUrl);
        }

        public async Task<TODO> SaveUser(TODO model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "User/SaveUser"));
            return await PostAsync<TODO>(requestUrl, model);
        }
    }
}
