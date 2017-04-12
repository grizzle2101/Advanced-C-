using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        //Custom Delegate
        public delegate void PhotoFilterHandler(Photo photo);


        public void Process(string path, Action<Photo> filterHandler)
        {
           //Built in .NET Delegates Action(Points to a void Method) & Func(Expects an result to be returned(not void)).
           //System.Action<>;
            //System.Func<>;

            //Locate File from Path
            var photo = new Photo().Load(path);

            //Using Delegate's to Apply Filters to Photo.
            filterHandler(photo);

            ////Apply Filters (Old Code)
            //var filter = new PhotoFilters();
            //filter.ApplyBrightness(photo);
            //filter.ApplyContrast(photo);
            //filter.Resize(photo);

            //Save Photo State
            photo.Save();
        }
    }
}
