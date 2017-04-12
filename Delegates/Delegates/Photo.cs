using System;

namespace Delegates
{
    public class Photo
    {
        public string FileName { get; set; }
        public Photo Load(string path)
        {
            Console.WriteLine("Photo Object: Loading Photo @ " + path);
            return new Photo(){ FileName = path};
        }
        public void Save()
        {
            Console.WriteLine("Photo Object: Saving Photo");
        }
    }
}