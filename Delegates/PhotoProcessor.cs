﻿namespace Delegates
{
    public class PhotoProcessor
    {
        // public delegate void PhotoFilterHandler(Photo photo);

        // public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.save();
        }
    }
}