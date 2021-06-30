﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser.Controllers.HeatMapChart
{
    public partial class HeatMapChartController : Controller
    {
        public IActionResult ColorAndSizeAttributes()
        {
            ViewBag.data = new heatmapDatasource().getData();
            return View();
        }
        public class heatmapDatasource
        {
            public string Year { get; set; }
            public string Months { get; set; }
            public int Accidents { get; set; }

            public int Fatalities { get; set; }
            public List<heatmapDatasource> getData()
            {
                List<heatmapDatasource> data = new List<heatmapDatasource>();
                data.Add(new heatmapDatasource { Year = "2017", Months = "Jan-Feb", Accidents = 4, Fatalities = 39 });
                data.Add(new heatmapDatasource { Year = "2017", Months = "Mar-Apr", Accidents = 3, Fatalities = 8 });
                data.Add(new heatmapDatasource { Year= "2017", Months= "May-Jun", Accidents= 1, Fatalities= 3 });
                data.Add(new heatmapDatasource { Year = "2017", Months = "Jul-Aug", Accidents = 1, Fatalities = 0 });
                data.Add(new heatmapDatasource { Year = "2017", Months = "Sep-Oct", Accidents = 4, Fatalities = 4 });
                data.Add(new heatmapDatasource { Year = "2017", Months = "Nov-Dec", Accidents = 2, Fatalities = 15 });
                data.Add(new heatmapDatasource { Year = "2016", Months = "Jan-Feb", Accidents = 4, Fatalities = 28 });
                data.Add(new heatmapDatasource { Year = "2016", Months = "Mar-Ap", Accidents = 5, Fatalities = 92 });
                data.Add(new heatmapDatasource { Year = "2016", Months = "May-Jun", Accidents = 5, Fatalities = 73 });
                data.Add(new heatmapDatasource { Year = "2016", Months = "Jul-Aug", Accidents = 3, Fatalities = 1 });
                data.Add(new heatmapDatasource { Year = "2016", Months = "Sep-Oct", Accidents = 3, Fatalities = 4 });
                data.Add(new heatmapDatasource { Year = "2016", Months = "Nov-Dec", Accidents = 4, Fatalities = 126 });
                data.Add(new heatmapDatasource { Year = "2015", Months = "Jan-Feb", Accidents = 1, Fatalities = 45 });
                data.Add(new heatmapDatasource { Year = "2015", Months = "Mar-Ap", Accidents = 5, Fatalities = 152});
                data.Add(new heatmapDatasource { Year = "2015", Months = "May-Jun", Accidents = 0, Fatalities = 0 });
                data.Add(new heatmapDatasource { Year = "2015", Months = "Jul-Aug", Accidents = 4, Fatalities = 54 });
                data.Add(new heatmapDatasource { Year = "2015", Months = "Sep-Oct", Accidents = 5, Fatalities = 243});
                data.Add(new heatmapDatasource { Year = "2015", Months = "Nov-Dec", Accidents = 2, Fatalities = 45 });
                data.Add(new heatmapDatasource { Year = "2014", Months = "Jan-Feb", Accidents = 2, Fatalities = 18 });
                data.Add(new heatmapDatasource { Year = "2014", Months = "Mar-Ap", Accidents = 3, Fatalities = 239 });
                data.Add(new heatmapDatasource { Year = "2014", Months = "May-Jun", Accidents = 0, Fatalities = 0 });
                data.Add(new heatmapDatasource { Year = "2014", Months = "Jul-Aug", Accidents = 4, Fatalities = 501 });
                data.Add(new heatmapDatasource { Year = "2014", Months = "Sep-Oct", Accidents = 1, Fatalities = 2 });
                data.Add(new heatmapDatasource { Year = "2014", Months = "Nov-Dec", Accidents = 4, Fatalities = 162 });
                data.Add(new heatmapDatasource { Year = "2013", Months = "Jan-Feb", Accidents = 2, Fatalities = 68 });
                data.Add(new heatmapDatasource { Year = "2013", Months = "Mar-Ap", Accidents = 3, Fatalities = 7 });
                data.Add(new heatmapDatasource { Year = "2013", Months = "May-Jun", Accidents = 2, Fatalities = 12 });
                data.Add(new heatmapDatasource { Year = "2013", Months = "Jul-Aug", Accidents = 4, Fatalities = 15 });
                data.Add(new heatmapDatasource { Year = "2013", Months = "Sep-Oct", Accidents = 2, Fatalities = 64 });
                data.Add(new heatmapDatasource { Year = "2013", Months = "Nov-Dec", Accidents = 3, Fatalities = 83 });
                data.Add(new heatmapDatasource { Year = "2012", Months = "Jan-Feb", Accidents = 0, Fatalities = 0 });
                data.Add(new heatmapDatasource { Year = "2012", Months = "Mar-Ap", Accidents = 2, Fatalities = 158 });
                data.Add(new heatmapDatasource { Year = "2012", Months = "May-Jun", Accidents = 5, Fatalities = 90 });
                data.Add(new heatmapDatasource { Year = "2012", Months = "Jul-Aug", Accidents = 0, Fatalities = 0 });
                data.Add(new heatmapDatasource { Year = "2012", Months = "Sep-Oct", Accidents = 3, Fatalities = 33 });
                data.Add(new heatmapDatasource { Year = "2012", Months = "Nov-Dec", Accidents = 4, Fatalities = 42 });
                return data;
            }
        }
    }
}