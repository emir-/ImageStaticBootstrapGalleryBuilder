using System;
using System.IO;
using System.Linq;
using System.Web.UI;
using ImageGrabber.GalleryComposition.Interface;
using ImageGrabber.GalleryComposition.Objects.BootstrapGalleryConfig;

namespace ImageGrabber.GalleryComposition
{
    public class BootstrapGalleryHtmlGenerator : IBootstrapGalleryHtmlGenerator
    {
        /// <summary>
        /// Generate a predefined html snippet usable in the bootstrap gallery example. The snipper
        /// is created based on the configuration for paths and thumbnail/server prefixes
        /// </summary>
        /// <param name="config">The configuration object for the bootstrap gallery</param>
        /// <returns></returns>
        public string GenerateBootstrapGalleryHtmlSnippet(BootstrapGalleryConfig config)
        {
            var mainImages = Directory.GetFiles(config.MainImageFolderPath);
            var thumbnailImages = Directory.GetFiles(config.ThumbnailImageFolderPath);

            var stringWriter = new StringWriter();

            ProcessSnippetSaveDirectory(config);

            using (var html = new HtmlTextWriter(stringWriter))
            {
                string galleryWrapperClass = config.GalleryWrapperClass;
                string galleryWrapperId = config.GalleryWrapperId;

                var anchorClass = "";
                var thumbImgClass = "img-thumbnail img-rounded thumbnail-new-year";

                // start the wrapper
                html.AddAttribute("class", galleryWrapperClass);
                html.AddAttribute("id", galleryWrapperId);

                html.RenderBeginTag(HtmlTextWriterTag.Div);

                // add the gallery snippet header
                if (!string.IsNullOrWhiteSpace(config.SnippetHeaderText))
                {
                    html.RenderBeginTag(HtmlTextWriterTag.H1);
                    html.WriteEncodedText(config.SnippetHeaderText);
                    html.RenderEndTag();
                }

                foreach (var mainImagePath in mainImages)
                {
                    var mainImageName = Path.GetFileName(mainImagePath);
                    var thumbnailName = GetThumbnailFromMainImageName(mainImageName, thumbnailImages, config.ThumbnailImagePrefix);

                    // ANCHOR
                    html.AddAttribute("data-gallery", "");
                    html.AddAttribute("href", config.MainImageServerPath + mainImageName);
                    html.AddAttribute("class", anchorClass);

                    html.RenderBeginTag(HtmlTextWriterTag.A);

                    // IMAGE TAG ( THUMBNAIL )
                    html.AddAttribute("class", thumbImgClass);
                    html.AddAttribute("src", config.ThmbnailImageServerPath + thumbnailName);

                    html.RenderBeginTag(HtmlTextWriterTag.Img);

                    // END THE IMG
                    html.RenderEndTag();

                    // END THE ANCHOR
                    html.RenderEndTag();
                }

                html.RenderEndTag();
            }

            // Html rendering is done up to this point. 

            // write the html to a file
            var snippetPath = config.GallerySnippetSavePath + config.SnippetFileName;

            using (StreamWriter writer = new StreamWriter(snippetPath, false))
            {
                writer.Write(stringWriter.ToString());
            }

            return stringWriter.ToString();
        }

        #region Private Utilities

        private string GetThumbnailFromMainImageName(string mainImageName, string[] thumbnailImages, string thumbnailPrefix)
        {
            /*
             *  We should be comparing thumbnail and main image names without the extension as thumbnails
             *  might have different extensions from main images
             */

            // get the possible name of the thumbnail without the extensions
            var thumbnailNameWithNoExtension = Path.GetFileNameWithoutExtension(thumbnailPrefix + mainImageName);

            var thumbnailImageFile =
                thumbnailImages.FirstOrDefault(
                    thumbPath => Path.GetFileNameWithoutExtension(thumbPath) == thumbnailNameWithNoExtension);

            // we are only going to be returning the file name without the whole path
            return Path.GetFileName(thumbnailImageFile);
        }

        private static void ProcessSnippetSaveDirectory(BootstrapGalleryConfig config)
        {
            if (Directory.Exists(config.GallerySnippetSavePath))
            {
                Directory.Delete(config.GallerySnippetSavePath, true);
            }

            Directory.CreateDirectory(config.GallerySnippetSavePath);
        }

        #endregion
    }
}