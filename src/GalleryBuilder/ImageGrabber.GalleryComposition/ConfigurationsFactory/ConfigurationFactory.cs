using ImageGrabber.GalleryComposition.Objects.BootstrapGalleryConfig;

namespace ImageGrabber.GalleryComposition.ConfigurationsFactory
{
    /// <summary>
    /// Static factory class returniong the gallery building configuration objects we are going to be using
    /// </summary>
    public static class ConfigurationFactory
    {
        public static BootstrapGalleryConfig GetYoprkGalleryConfig()
        {
            var configObject = new BootstrapGalleryConfig()
            {
                // TODO : NEEDS MODIFICATION TO CORRECT FOLDERS
                GallerySnippetSavePath = @"C:\tmp_gc\snippet\york\",

                SnippetFileName = @"York.html",

                // TODO : NEEDS MODIFICATION TO CORRECT FOLDERS
                MainImageFolderPath = @"C:\tmp_gc\images\york\",
                
                // TODO : NEEDS MODIFICATION TO CORRECT FOLDERS
                ThumbnailImageFolderPath = @"C:\tmp_gc\images\york\thumb\",

                // TODO : NEEDS MODIFICATION TO CORRECT PATH based on published web site
                MainImageServerPath = @"/images/york/",

                // TODO : NEEDS MODIFICATION TO CORRECT PATHS based on published web site
                ThmbnailImageServerPath = @"/images/york/thumb/",

                ThumbnailImagePrefix = "thumb_",

                GalleryWrapperClass = "well image-container",
                GalleryWrapperId = "abstract",

                SnippetHeaderText = "New York!"
            };

            return configObject;
        }
    }
}
