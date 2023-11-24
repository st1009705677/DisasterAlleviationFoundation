using Microsoft.Extensions.Primitives;

namespace DisasterAlleviationFoundation.Pages.InformationPublic
{
    public class GoodsDonationInfo
    {
        internal int NumberOfItems;

        public DateOnly Date { get; internal set; }
        public StringValues Categories { get; internal set; }
        public StringValues Description { get; internal set; }
        public StringValues DonorName { get; internal set; }
    }
}
