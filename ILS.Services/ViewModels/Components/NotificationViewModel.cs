using System;
using System.Collections.Generic;
using System.Text;

namespace ILS.Services.ViewModels
{
    public class NotificationViewModel
    {
        public string Message { get; set; }
        public NotificationType MessageType { get; set; }
    }

    public enum NotificationType
    {
        success,
        error,
        warning
    }
}
