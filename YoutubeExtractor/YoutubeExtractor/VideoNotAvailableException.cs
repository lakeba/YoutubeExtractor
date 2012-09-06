﻿using System;

namespace YoutubeExtractor
{
    /// <summary>
    /// The exception that is thrown when the video is not available for viewing.
    /// This can be caused when the uploader resticts the video to specific countries.
    /// </summary>
    public class VideoNotAvailableException : Exception
    { }
}