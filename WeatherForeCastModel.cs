﻿using System;
namespace Bethselamin.Models
{
    public class WeatherForeCastModel
    {

        public DayForecastModel[] consolidated_weather { get; set; }

        public DateTime sun_rise { get; set; }

        public DateTime sun_set { get; set; }

        public string title { get; set; }

        public string timezone { get; set; }

    }
}
