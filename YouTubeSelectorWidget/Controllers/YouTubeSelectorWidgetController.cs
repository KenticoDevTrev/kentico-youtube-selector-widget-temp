using CMS.Helpers;
using Kentico.PageBuilder.Web.Mvc;
using KenticoCommunity.YouTubeSelectorWidget;
using System.Configuration;
using System.Web.Mvc;

[assembly: RegisterWidget("KenticoCommunity.YouTubeSelectorWidget", typeof(YouTubeSelectorWidgetController), "YouTube selector widget", Description = "Shows selected YouTube video", IconClass = "icon-brand-youtube")]

namespace KenticoCommunity.YouTubeSelectorWidget
{
    public class YouTubeSelectorWidgetController : WidgetController<YouTubeSelectorWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();

            var ViewModel = new YouTubeSelectorWidgetViewModel
            {
                VideoId = properties.VideoId,
                ApiKey = ConfigurationManager.AppSettings["YouTubeApiKey"],
                Width = properties.Width,
                Height = properties.Height,
                StartTime = properties.StartTime,
                EndTime = properties.EndTime,
                VideoQuality = ValidationHelper.GetString(properties.VideoQuality, ""),
                AdditionalParameters = ValidationHelper.GetString(properties.AdditionalParameters, "")
            };
            ViewModel.AutoPlay = (string.IsNullOrWhiteSpace(properties.AutoPlay) ? (bool?)null : ValidationHelper.GetBoolean(properties.AutoPlay, false));
            ViewModel.AllowFullScreen = (string.IsNullOrWhiteSpace(properties.AllowFullScreen) ? (bool?)null : ValidationHelper.GetBoolean(properties.AllowFullScreen, false));
            ViewModel.ShowAnnotations = (string.IsNullOrWhiteSpace(properties.ShowAnnotations) ? (bool?)null : ValidationHelper.GetBoolean(properties.ShowAnnotations, false));
            ViewModel.ShowTitleAndUploader = (string.IsNullOrWhiteSpace(properties.ShowTitleAndUploader) ? (bool?)null : ValidationHelper.GetBoolean(properties.ShowTitleAndUploader, false));
            ViewModel.ShowRelatedVideos = (string.IsNullOrWhiteSpace(properties.ShowRelatedVideos) ? (bool?)null : ValidationHelper.GetBoolean(properties.ShowRelatedVideos, false));
            ViewModel.ShowCaptions = (string.IsNullOrWhiteSpace(properties.ShowCaptions) ? (bool?)null : ValidationHelper.GetBoolean(properties.ShowCaptions, false));

            return PartialView("Widgets/_YouTubeSelectorWidget", ViewModel);
        }
    }
}
