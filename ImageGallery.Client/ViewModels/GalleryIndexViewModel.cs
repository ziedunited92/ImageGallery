using System.Collections.Generic;
using ImageGallery.API.Entities;

namespace ImageGallery.Client.ViewModels
{
    public class GalleryIndexViewModel
    {
        private List<Image> list;

        public IEnumerable<Image> Images { get; private set; }
            = new List<Image>();

        public GalleryIndexViewModel(List<Image> images)
        {
            Images = images;
        }

        
        
           
       
    }
}
