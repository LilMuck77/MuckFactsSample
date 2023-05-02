using System;
using System.Collections.Generic;

namespace MuckFactsSample

{
    public class MuckFactData
    {
        public MuckFactData()
        {
        }
        public static IEnumerable<MuckFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string Image { get; set; }
        static MuckFactData()
        {
            List<MuckFactData> all = new List<MuckFactData>();
            all.Add(new MuckFactData() { TheFact = "I have 4 children.", ShortFact = "Children", Image = "https://media.istockphoto.com/id/546464946/photo/two-little-girls-on-a-forest-road.jpg?s=612x612&w=0&k=20&c=aoCSMXIRjGUpaa9RdBHbexiuo-jSop4kTTJeaC_IjcY=" });
            all.Add(new MuckFactData() { TheFact = "I have been married for 6 years.", ShortFact = "Marriage", Image = "https://banner2.cleanpng.com/20180206/sgw/kisspng-wedding-ring-silver-clip-art-silver-ring-png-pic-5a79b6df0984e6.043612511517926111039.jpg" });
            all.Add(new MuckFactData() { TheFact = "I wrestled for 12 years.", ShortFact = "Sport", Image = "https://as2.ftcdn.net/v2/jpg/01/83/37/55/1000_F_183375525_If2m21RoEypOjQyvVcb1PxOMJO0fZNXh.jpg" });
            all.Add(new MuckFactData() { TheFact = "I am a born again Christian.", ShortFact = "Religion", Image = "https://media.istockphoto.com/id/657091114/photo/crucifixion-of-jesus-christ.jpg?s=612x612&w=0&k=20&c=GrvlF-IaMzbTJoRxMfz-g8PVjlbdi7l56FmG6uOi0q0=" });
            all.Add(new MuckFactData() { TheFact = "I am a flooring specialist.", ShortFact = "Job", Image = "https://media.istockphoto.com/id/638727076/photo/installing-wood-flooring.jpg?s=612x612&w=0&k=20&c=l4wcPVlfJ42CbR5U1OYgMdq1wW3HJtqABtz2MepeMpY=" });
            All = all;

        }
    }
}