﻿using AppDynamics.Dexter.ReportObjects;
using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjectMaps
{
    public class APMServiceEndpointReportMap : ClassMap<APMServiceEndpoint>
    {
        public APMServiceEndpointReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.TierName).Index(i); i++;
            Map(m => m.SEPName).Index(i); i++;
            Map(m => m.SEPType).Index(i); i++;

            Map(m => m.IsExplicitRule).Index(i); i++;
            Map(m => m.RuleName).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
            Map(m => m.SEPID).Index(i); i++;
            Map(m => m.DetailLink).Index(i); i++;
            Map(m => m.MetricGraphLink).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.TierLink).Index(i); i++;
            Map(m => m.SEPLink).Index(i); i++;
        }
    }
}
