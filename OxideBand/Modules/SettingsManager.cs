using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxideBand.Models;

namespace OxideBand.Modules
{
    public static class SettingsManager
    {
        public static string RustDirectory;
        public static string InstrumentsDirectory => Path.Combine(RustDirectory, "instruments");

        public static void Init(out bool NewConfig)
        {
            NewConfig = false;
            if (File.Exists("Config.ini"))
            {
                INIFile file = new INIFile("Config.ini");
                if (file.KeySet("RustDirectory"))
                {
                    if (file["RustDirectory"].Contains("CHANGE ME!"))
                    {
                        NewConfig = true;
                    }
                    RustDirectory = file["RustDirectory"];
                } else
                {
                    NewConfig = true;
                    file["RustDirectory"] = @"Rust Directory, e.g., .... \steamapps\common\Rust";
                    file.Save();
                }
            } else
            {
                NewConfig = true;
                INIFile file = new INIFile();
                file.WriteComment("OxideBand Config File.");
                file.WriteComment("Oxide Band For Rust v1.0. © 'ShimmyMySherbet' 2020");
                file["RustDirectory"] = @"Rust Directory, e.g., .... \steamapps\common\Rust. CHANGE ME!";
                file.Save("Config.ini");
            }
        }
    }
}
