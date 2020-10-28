﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace flskinner
{
    class Config
    {
        public string currentSkin { get; set; }
        public string flStudioPath { get; set; }
        public bool setDefaultPatternColor { get; set; } = true;
        public bool setGridColors { get; set; } = true;
        public bool setMixerColors { get; set; } = true;
        public bool setPlaylistTrackColors { get; set; } = true;
        public bool hideName { get; set; } = false;

        public static Config current;

        public void Save()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var folderPath = string.Format(@"{0}\flskinner\", appDataPath);

            File.WriteAllText(folderPath + "flskinner.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
