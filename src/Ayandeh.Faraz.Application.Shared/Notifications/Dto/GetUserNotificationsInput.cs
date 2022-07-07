﻿using System;
using Abp.Notifications;
using Ayandeh.Faraz.Dto;

namespace Ayandeh.Faraz.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}