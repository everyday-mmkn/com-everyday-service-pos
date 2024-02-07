﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Inventory.Lib.Helpers
{
    public static class APIEndpoint
    {
        public static string Core { get; set; }
        public static string Warehouse { get; set; }
        public static string Production { get; set; }
        public static string Purchasing { get; set; }
        public static string Sales { get; set; }
        public static string CoreConnectionString { get; set; }
        public static string DefaultConnectionString { get; set; }
    }
}
