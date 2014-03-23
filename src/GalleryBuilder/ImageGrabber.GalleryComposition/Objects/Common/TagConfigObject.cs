using System.Collections.Generic;

namespace ImageGrabber.GalleryComposition.Objects.Common
{
    /// <summary>
    /// Provides a fluent API to create tag configuration objects for Html snippets in the 
    /// Html Gallery Generation service
    /// </summary>
    public class TagConfigObject
    {
        #region Properties
        
        List<TagAttribute> Attributes { get; set; }

        #endregion

        #region Constructor

        private TagConfigObject()
        {
            
        }

        #endregion
    }

    public class TagAttribute
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public enum TagAttributes
    {
        Id,
        Class,
        DataGallery,
        Href,
        Src
    }
}