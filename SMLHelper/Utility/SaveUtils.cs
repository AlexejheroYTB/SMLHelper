﻿namespace SMLHelper.V2.Utility
{
    using System.IO;

    /* TODO: Maybe add more saving related functions here,
       such as those related to serializing? */
    public static class SaveUtils
    {
        /// <summary>
        /// Returns the path to the current save slot's directory.
        /// </summary>
        public static string GetCurrentSaveDataDir()
        {
            return SaveLoadManager.temporarySavePath;
        }
    }
}
