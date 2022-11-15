using System;//
using System.Collections.Generic;//
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;//
using System.ComponentModel.DataAnnotations;//
using System.ComponentModel.DataAnnotations.Schema;//

namespace HeladeriaTAMS.DTO.spotify
{
    public class UserSpotify
    {
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        public Followers? followers { get; set; }
    }

    public class Followers
    {
        [JsonPropertyName("total")]
        [Display(Name="Followers")]
        public int Total { get; set; }
    }
}