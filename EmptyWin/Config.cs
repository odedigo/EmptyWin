using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyWin
{
    public class Config
    {
        private static Color DefaultVgColor = Color.White;
        private static bool DefaultOnTop = true;

        private static Config instance;

        private Config() {
            this.BgColor = DefaultVgColor;
            this.OnTop = DefaultOnTop;
        }

        public static Config Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Config();
                }
                return instance;
            }
        }

        public Color BgColor { get; set; }
        public bool OnTop { get; set; }

    }
}
