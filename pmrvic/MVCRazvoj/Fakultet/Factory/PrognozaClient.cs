using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet.Factory
{
    public partial class ApiClient
    {
        public async Task<List<Models.VremenskaPrognoza>> GetPrognoza()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "weatherforecast"));
            return await GetAsync<List<Models.VremenskaPrognoza>>(requestUrl);
        }
    }
}
