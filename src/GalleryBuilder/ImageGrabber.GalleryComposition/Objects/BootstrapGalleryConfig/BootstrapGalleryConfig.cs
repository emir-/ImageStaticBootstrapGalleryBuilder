namespace ImageGrabber.GalleryComposition.Objects.BootstrapGalleryConfig
{
    /// <summary>
    /// The main configuration class for the bootstrap gallery html snipper generation service
    /// </summary>
    public class BootstrapGalleryConfig
    {
        #region Snippet Save Location
        
        /// <summary>
        /// Where on disk will we save the html snippet for the gallery
        /// html snipper
        /// </summary>
        public string GallerySnippetSavePath { get ; set; }

        /// <summary>
        /// The name of the html snippet. {XX.html}
        /// </summary>
        public string SnippetFileName { get; set; }

        #endregion

        #region Image Location For Gallery Composition
        
        /*
         * The prefixes for the folder structure where the images are located from which we will generate the html snippet
         * gallery
         */

        /// <summary>
        /// The main image location for the main images that will be composed in the snippet.
        /// </summary>
        public string MainImageFolderPath { get; set; }

        /// <summary>
        /// The thumbnail image location for the thumbnail images that will be composed in the snippet
        /// </summary>
        public string ThumbnailImageFolderPath { get; set; }

        #endregion

        #region Web server image location for html element UR prefixes
        
        /*
         * The prefixes for the genrated anchor and image links for the images. These should match web site 
         * folder structure for the images
         */
        
        /// <summary>
        /// Main image web site server path prefix
        /// </summary>
        public string MainImageServerPath { get; set; }

        /// <summary>
        /// Thumbnail image web site server path prefix
        /// </summary>
        public string ThmbnailImageServerPath { get; set; }

        #endregion

        #region General Image configuration

        /// <summary>
        /// The prefix to the main image name which when combined gives the name of the thumbnail for that image.
        /// Does not care about the prefix.
        /// 
        /// Main image: "1.jpeg"
        /// Thumbnail image: "thumb_1.png"
        /// The prefix here is "tnumb_"
        /// </summary>
        public string ThumbnailImagePrefix { get; set; }

        #endregion

        #region Html Generation properties
    
        /// <summary>
        /// Header text displayed right under the starting of the gallery
        /// </summary>
        public string SnippetHeaderText { get; set; }

        /// <summary>
        /// The class for the topmost html snippet wrapper
        /// </summary>
        public string GalleryWrapperClass { get; set; }

        /// <summary>
        /// The id of the topmost gallery snippet wrapper html element
        /// </summary>
        public string GalleryWrapperId { get; set; }

        #endregion
    }
}
