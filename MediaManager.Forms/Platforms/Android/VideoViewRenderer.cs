﻿using System;
using Android.Content;
using MediaManager.Forms;
using MediaManager.Forms.Platforms.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(VideoView), typeof(VideoViewRenderer))]
namespace MediaManager.Forms.Platforms.Android
{
    [global::Android.Runtime.Preserve(AllMembers = true)]
    public class VideoViewRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<VideoView, MediaManager.Platforms.Android.Video.VideoView>
    {
        private MediaManager.Platforms.Android.Video.VideoView _videoView;

        public VideoViewRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<VideoView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    _videoView = new MediaManager.Platforms.Android.Video.VideoView(Context);
                    CrossMediaManager.Current.MediaPlayer.SetPlayerView(_videoView);
                    SetNativeControl(_videoView);
                }
            }
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            if (_videoView != null)
            {
                var p = _videoView.LayoutParameters;
                p.Height = heightMeasureSpec;
                p.Width = widthMeasureSpec;
                _videoView.LayoutParameters = p;
            }
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }
    }
}
