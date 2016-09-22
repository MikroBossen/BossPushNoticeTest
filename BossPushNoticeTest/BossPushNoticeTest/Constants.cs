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

namespace BossPushNoticeTest
{
    public static class Constants
    {
        public const string SenderID = "828768700042";
        public const string ListenConnectionString = "Endpoint=sb://bosspushnoticetest.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=rpyz5KCmuuiGk6GHX8jGi2pfxgaFuoIjEnm8bXRT16Q=";
        public const string NotificationHubName = "bosstestnoticehub";
    }
}