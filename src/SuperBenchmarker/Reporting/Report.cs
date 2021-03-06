﻿using SuperBenchmarker.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBenchmarker.Reporting
{
    public class Report
    {
        public Report()
        {
            Slices = new List<Slice>();
            Percentiles = new Dictionary<Decimal, int>();
            StatusCodeSummary = new Dictionary<int, int>();
            Version = VersionHelper.GetVersion();
        }

        public string CommandLine { get; set; }

        public DateTimeOffset Start { get; set; }

        public int ReportingSliceSeconds { get; set; }

        public DateTimeOffset End { get; set; }

        public bool IsFinal { get; set; }

        public List<Slice> Slices { get; set; }

        public int Max { get; set; }

        public int Min { get; set; }

        public double Average { get; set; }

        public Dictionary<Decimal, int> Percentiles { get; set; }

        public Dictionary<int, int> StatusCodeSummary { get; set; }

        public int Total { get; set; }

        public double Rps { get; set; }

        public string Version { get; set; }
    }
}
