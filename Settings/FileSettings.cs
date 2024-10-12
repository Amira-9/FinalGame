﻿namespace WebApplication2.Settings
{
    public static class FileSettings
    {
        public const string ImagePath = "/assets/Images/games";
        public const string AllowedExtentions = ".jpg,.jpeg,.png";
        public const int MaxFileSizeInMB = 1;
        public const int MaxFileSizeInBytes = MaxFileSizeInMB *1024*1024;

    }
}
