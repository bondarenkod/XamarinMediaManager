﻿using System;
using Plugin.MediaManager.Abstractions.Implementations;

namespace Plugin.MediaManager.Abstractions
{
    public interface IMediaNotificationManager
    {
        /// <summary>
        /// Starts the notification.
        /// </summary>
        /// <param name="mediaFile">The media file.</param>
        void StartNotification(IMediaFile mediaFile);

        /// <summary>
        /// Stops the notifications.
        /// </summary>
        void StopNotifications();

        /// <summary>
        /// Updates the notifications.
        /// </summary>
        /// <param name="mediaFile">The media file.</param>
        /// <param name="status">The status.</param>
        void UpdateNotifications(IMediaFile mediaFile, MediaPlayerStatus status);
    }
}