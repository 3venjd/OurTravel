using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurTravel.Shared.Entities
{
    public class GalleryInterestedPlace
    {
        public int Id { get; set; }

        public string? Url { get; set; }

        public int InterestedPlaceId { get; set; }

        public InterestedPlace? InterestedPlace { get; set; }
    }
}
