using System;
using ImageGrabber.GalleryComposition.ConfigurationsFactory;

namespace ImageGrabber.GalleryComposition
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newYorkGallery = ConfigurationFactory.GetYoprkGalleryConfig();
        
            var snipperService = new BootstrapGalleryHtmlGenerator();

            snipperService.GenerateBootstrapGalleryHtmlSnippet(newYorkGallery);

            Console.WriteLine("DONE!");

            Console.ReadLine();
        }
    }
}
