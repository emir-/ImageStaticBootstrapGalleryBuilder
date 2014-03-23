using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageGrabber.GalleryComposition.Objects.BootstrapGalleryConfig;

namespace ImageGrabber.GalleryComposition.Interface
{
    /// <summary>
    /// Given an image folder path structure with thumbnails and actual images 
    /// provides a functionality to generate a partial HTML snippet for the bootrap gallery
    /// plugin
    /// </summary>
    public interface IBootstrapGalleryHtmlGenerator
    {
        /// <summary>
        /// Generate a predefined html snippet usable in the bootstrap gallery example. The snipper
        /// is created based on the configuration for paths and thumbnail/server prefixes
        /// </summary>
        /// <param name="config">The configuration object for the bootstrap gallery</param>
        /// <returns></returns>
        string GenerateBootstrapGalleryHtmlSnippet(BootstrapGalleryConfig config);
    }
}
