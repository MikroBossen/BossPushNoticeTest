using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace bossnotificationnamespace
{
    public static class Constants
    {
        public const string SenderID = "232943420018";
        public const string ListenConnectionString = "Endpoint=sb://bossnotificationnamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=vY9h1IcUwYak2H5otmGWiane/Uw+pX7cgcZcxXDLOJs=";
        public const string NotificationHubName = "bossnotificationhub";
    }
}