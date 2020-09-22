using System.ComponentModel;

namespace FluentBootstrap.Images
{
    public enum ImageStyle
    {
        [Description()]
        Default,
        [Description(Css.ImgRounded)]
        Rounded,
        [Description(Css.ImgCircle)]
        Circle,
        [Description(Css.ImgThumbnail)]
        Thumbnail
    }
}
