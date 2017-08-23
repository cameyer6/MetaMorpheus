﻿using MzLibUtil;

namespace EngineLayer
{
    public class XLSearchParameters
    {
        public bool SearchDecoy { get; set; }
        public bool DoLocalizationAnalysis { get; set; }

        public CrosslinkerType CrosslinkerType { get; set; }
        public int CrosslinkSearchTopNum { get; set; }
        public bool CrosslinkSearchWithAllBeta { get; set; }
        public string UdXLkerName { get; set; }
        public bool UdXLkerCleavable { get; set; }
        public double? UdXLkerTotalMass { get; set; }
        public double? UdXLkerShortMass { get; set; }
        public double? UdXLkerLongMass { get; set; }
        public char UdXLkerResidue { get; set; }
        public Tolerance XLprecusorMsTl { get; set; }
        public Tolerance XLBetaPrecusorMsTl { get; set; }
        public bool DisposeOfFileWhenDone { get; set; }
    }

}
