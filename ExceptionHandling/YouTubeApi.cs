using System;
using System.Collections.Generic;

namespace ExceptionHandling
{

    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube Web Service
                // Read the data
                // Create a list of videos
                throw new Exception("Oops sme low level youtube error");
                return new List<Video>();
            }
            catch (Exception ex)
            {
                // Log

                throw new YouTubeException("Could not fetch de videos from YouTube", ex);
            }
        }
    }
}
