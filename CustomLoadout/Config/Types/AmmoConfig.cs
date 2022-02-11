using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLoadout.Config.Types
{
    public sealed class AmmoConfig
    {
        [Description("Should the class' amount of ammo be replaced?")]
        public bool ReplaceAmmo { get; set; }
        public ushort Ammo5 { get; set; }
        public ushort Ammo7 { get; set; }
        public ushort Ammo9 { get; set; }

        public AmmoConfig()
        {
            ReplaceAmmo = false;
            Ammo5 = 0;
            Ammo7 = 0;
            Ammo9 = 0;
        }
    }
}
