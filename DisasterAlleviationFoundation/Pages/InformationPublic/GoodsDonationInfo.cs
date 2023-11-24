using Microsoft.Extensions.Primitives;

namespace DisasterAlleviationFoundation.Pages.InformationPublic
{
    public class GoodsDonationInfo
    {
        public String? DonorName { get; internal set; }
        internal int NumberOfItems { get; }
        public DateOnly DateOfDonations { get; internal set; }
        public String? Categories { get; internal set; }
        public String? Description { get; internal set; }
        
    }
}
