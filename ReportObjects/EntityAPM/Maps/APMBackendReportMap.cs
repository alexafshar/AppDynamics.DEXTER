﻿using AppDynamics.Dexter.ReportObjects;
using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjectMaps
{
    public class APMBackendReportMap : ClassMap<APMBackend>
    {
        public APMBackendReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.BackendName).Index(i); i++;
            Map(m => m.BackendType).Index(i); i++;

            Map(m => m.IsExplicitRule).Index(i); i++;
            Map(m => m.RuleName).Index(i); i++;

            Map(m => m.NumProps).Index(i); i++;
            Map(m => m.Prop1Name).Index(i); i++;
            Map(m => m.Prop1Value).Index(i); i++;
            Map(m => m.Prop2Name).Index(i); i++;
            Map(m => m.Prop2Value).Index(i); i++;
            Map(m => m.Prop3Name).Index(i); i++;
            Map(m => m.Prop3Value).Index(i); i++;
            Map(m => m.Prop4Name).Index(i); i++;
            Map(m => m.Prop4Value).Index(i); i++;
            Map(m => m.Prop5Name).Index(i); i++;
            Map(m => m.Prop5Value).Index(i); i++;
            Map(m => m.Prop6Name).Index(i); i++;
            Map(m => m.Prop6Value).Index(i); i++;
            Map(m => m.Prop7Name).Index(i); i++;
            Map(m => m.Prop7Value).Index(i); i++;

            Map(m => m.DBMonCollectorName).Index(i); i++;
            Map(m => m.DBMonCollectorType).Index(i); i++;

            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.BackendID).Index(i); i++;
            Map(m => m.DBMonCollectorConfigID).Index(i); i++;
            Map(m => m.MetricGraphLink).Index(i); i++;
            Map(m => m.DetailLink).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.BackendLink).Index(i); i++;
        }
    }
}
