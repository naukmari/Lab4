using System;
using System.IO;

namespace CharpZavertailo2.Tools.Managers
{
   internal static class StationManager
    {
        internal static readonly string WorkingDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CharpZavertailo2");

        internal static Person CurrentPerson { get; set; }
    }
}
