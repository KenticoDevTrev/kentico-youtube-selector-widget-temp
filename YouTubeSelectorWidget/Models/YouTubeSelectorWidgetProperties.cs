using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace KenticoCommunity.YouTubeSelectorWidget
{
    public class YouTubeSelectorWidgetProperties : IWidgetProperties
    {
        public string VideoId { get; set; }

        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "Width", Order = 2)]
        public int? Width { get; set; }

        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "Height", Order = 3)]
        public int? Height { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Auto Play", Order = 4)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ";(default)\r\ntrue;True\r\nfalse;False")]
        public string AutoPlay { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Allow Full Screen", Order = 5)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ";(default)\r\ntrue;True\r\nfalse;False")]
        public string AllowFullScreen { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Show Annotations", Order = 6)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ";(default)\r\ntrue;True\r\nfalse;False")]
        public string ShowAnnotations { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Show Title and Uploader", Order = 7)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ";(default)\r\ntrue;True\r\nfalse;False")]
        public string ShowTitleAndUploader { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Show Related Videos", Order = 8)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ";(default)\r\ntrue;True\r\nfalse;False")]
        public string ShowRelatedVideos { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Show Captions", Order = 9)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ";(default)\r\ntrue;True\r\nfalse;False")]
        public string ShowCaptions { get; set; }

        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "Start Time", Order = 10)]
        public int? StartTime { get; set; }

        [EditingComponent(IntInputComponent.IDENTIFIER, Label = "End Time", Order = 11)]
        public int? EndTime { get; set; }

        [EditingComponent(DropDownComponent.IDENTIFIER, Label = "Video Quality", Order = 12)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), ";Auto\r\n240p;240p\r\n360p;360p\r\n480p;480p\r\n720p;720p\r\n1080p;1080p")]
        public string VideoQuality { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Additional URL Parameters", Order = 13, Tooltip = "These will be added to the end of the YouTube embed url.  See YouTube Documentation for available options.")]
        public string AdditionalParameters { get; set; }
    }
}
