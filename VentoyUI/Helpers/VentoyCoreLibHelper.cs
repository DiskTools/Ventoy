using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VentoyUI.Helpers
{
    class VentoyCoreLibHelper
    {
        [DllImport("Assets\\CoreLib\\Ventoy2Disk_X64.dll", EntryPoint = "LoadCfgIni")]
        public extern static int Test();
    }
}
