
namespace KenticoCommunity.YouTubeSelectorWidget
{
    public class YouTubeSelectorWidgetViewModel
    {
        public string VideoId { get; set; }
        public string ApiKey { get; set; }

        public bool? AutoPlay { get; set; }
        public bool? AllowFullScreen { get; set; }
        public bool? ShowAnnotations { get; set; }
        public bool? ShowTitleAndUploader { get; set; }
        public bool? ShowRelatedVideos { get; set; }
        public bool? ShowCaptions { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
        public string VideoQuality { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        public string AdditionalParameters { get; set; }
    }
}
