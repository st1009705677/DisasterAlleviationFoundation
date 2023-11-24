using Microsoft.Extensions.Primitives;

namespace DisasterAlleviationFoundation.Pages.InformationPublic
{
    public class GoodsDonationInfo
    {
        internal StringValues NumberOfItems;

        public StringValues Date { get; internal set; }
        public StringValues Categories { get; internal set; }
        public StringValues Description { get; internal set; }
        public StringValues DonorName { get; internal set; }
    }
}
