﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Weather_App.Common
{
    class Common
    {
        public static string API_KEY = "434bec562fd0bc83a9abed6b6832ebaa";
        public static string API_LINK = "http://api.openweathermap.org/data/2.5/weather";

        public static string APIRequest(string lat, string lng)
        {
            StringBuilder sb = new StringBuilder(API_LINK);
            sb.AppendFormat("?lat={0}&lon={1}&APPID={2}&units=metric");
            return sb.ToString();
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(unixTimeStamp).ToLocalTime();
            return dt;
        }

        public static string GetImage (string icon)
        {
            return $"http://openweathermap.org/img/w/{icon}.png";
        }

    }
}