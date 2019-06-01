using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

/*
 * Damit Config übernommen wird, muss diese als Readonly eingestellt werden
 */


namespace FarmTogetherToolsLib
{
    public struct Language
    {
        public static string DEUTSCH = "Deutsch";
        public static string ENGLISH = "English";
        public static string FRANCAIS = "Français";
    }

    public struct FullscreenMode
    {
        public static int WINDOWED = 0;
        public static int FULLSCREEN = 1;
        public static int FULLSCREENWINDOWED = 2;
    }

    public struct QualityLevel
    {
        public static int VERYLOW = 0;
        public static int LOW = 1;
        public static int MEDIUM = 2;
        public static int HIGH = 3;
        public static int VERYHIGH = 4;
    }

    public struct AOLevel
    {
        public static int DISABLED = 0;
        public static int LOW = 1;
        public static int MEDIUM = 2;
        public static int HIGH = 3;
        public static int VERYHIGH = 4;
    }

    public struct AntialiasLevel
    {
        public static int DISABLED = 0;
        public static int LOW = 1;
        public static int MEDIUM = 2;
        public static int HIGH = 3;
    }

    public struct DepthOfFieldLevel
    {
        public static int DISABLED = 0;
        public static int LOW = 1;
        public static int MEDIUM = 2;
        public static int HIGH = 3;
        public static int VERYHIGH = 4;
    }

    public struct MotionblurLevel
    {
        public static int DISABLED = 0;
        public static int LOW = 1;
        public static int MEDIUM = 2;
        public static int HIGH = 3;
        public static int VERYHIGH = 4;
    }

    public struct Resolution
    {
        public static string _624X464 = "624,464";
        public static string _640X480 = "640,480";
        public static string _1280X720 = "1280,720";
        public static string _1366X768 = "1366,768";
        public static string _1440X900 = "1440,900";
        public static string _1600X900 = "1600,900";
        public static string _1600X1024 = "1600,1024";
        public static string _1680X1050 = "1680,1050";
        public static string _1768X992 = "1768,992";
        public static string _1920X1080 = "1920,1080";
    }

    public class Config
    {
        private string _language;
        private bool _vsync;
        private string _resolution;
        private int _fullscreen;
        private int _refreshRate;
        private int _quality;
        private float _sound;
        private float _music;
        private float _menu;
        private int _ao;
        private int _antialias;
        private int _dof;
        private int _motionblur;
        private float _rendersize;
        private bool _lockCursor;
        private int _targetFPS;
        private int _bgFPS;

        public Config()
        {
            this._language = "English";
            this._vsync = false;
            this._resolution = "1280,720";
            this._fullscreen = 0;
            this._refreshRate = 60;
            this._quality = 0;
            this._sound = 0.05f;
            this._music = 0.05f;
            this._menu = 0.05f;
            this._ao = 0;
            this._antialias = 0;
            this._dof = 0;
            this._motionblur = 0;
            this._rendersize = 0.5f;
            this._lockCursor = false;
            this._targetFPS = 60;
            this._bgFPS = 20;
        }

        public string Language
        {
            get
            {
                return this._language;
            }
            set
            {
                if (value == "English" || value == "Deutsch" || value == "Français")
                    this._language = value;
                else
                    this._language = "English";
            }
        }

        public bool VSync
        {
            get
            {
                return this._vsync;
            }
            set
            {
                this._vsync = value;
            }
        }

        public string Resolution
        {
            get
            {
                return this._resolution;
            }
            set
            {
                this._resolution = value;
            }
        }

        public int Fullscreen
        {
            get
            {
                return this._fullscreen;
            }
            set
            {
                if (value >= 0 && value <= 2)
                    this._fullscreen = value;
                else
                    this._fullscreen = 0;
            }
        }

        public int Quality
        {
            get
            {
                return this._quality;
            }
            set
            {
                if (value >= 0 && value <= 4)
                    this._quality = value;
                else
                    this._quality = 0;
            }
        }

        public int RefreshRate
        {
            get
            {
                return this._refreshRate;
            }
            set
            {
                if (value >= 30 && value <= 240)
                    this._refreshRate = value;
                else
                    this._refreshRate = 60;
            }
        }

        public float Sound
        {
            get
            {
                return this._sound;
            }

            set
            {
                if (value >= 0.0f && value <= 1.0f)
                    this._sound = value;
                else
                    this._sound = 0.05f;
            }
        }


        public float Music
        {
            get
            {
                return this._music;
            }

            set
            {
                if (value >= 0.0f && value <= 1.0f)
                    this._music = value;
                else
                    this._music = 0.05f;
            }
        }

        public float Menu
        {
            get
            {
                return this._menu;
            }

            set
            {
                if (value >= 0.0f && value <= 1.0f)
                    this._menu = value;
                else
                    this._menu = 0.05f;
            }
        }

        public int AmbientOcclusion
        {
            get
            {
                return this._ao;
            }
            set
            {
                if (value >= 0 && value <= 4)
                    this._ao = value;
                else
                    this._ao = 0;
            }
        }

        public int Antialiasing
        {
            get
            {
                return this._antialias;
            }
            set
            {
                if (value >= 0 && value <= 3)
                    this._antialias = value;
                else
                    this._antialias = 0;
            }
        }

        public int DepthOfField
        {
            get
            {
                return this._dof;
            }
            set
            {
                if (value >= 0 && value <= 4)
                    this._dof = value;
                else
                    this._dof = 0;
            }
        }

        public int Motionblur
        {
            get
            {
                return this._motionblur;
            }
            set
            {
                if (value >= 0 && value <= 4)
                    this._motionblur = value;
                else
                    this._motionblur = 0;
            }
        }

        public float Rendersize
        {
            get
            {
                return this._rendersize;
            }
            set
            {
                if (value >= 0.01f && value <= 4.0f)
                    this._rendersize = value;
                else
                    this._rendersize = 0.5f;
            }
        }

        public bool LockCursor
        {
            get
            {
                return this._lockCursor;
            }
            set
            {
                this._lockCursor = value;
            }
        }

        public int TargetFramerate
        {
            get
            {
                return this._targetFPS;
            }
            set
            {
                if (value >= 20 && value <= 240)
                    this._targetFPS = value;
                else
                    this._targetFPS = 60;
            }
        }

        public int BackgroundFramerate
        {
            get
            {
                return this._bgFPS;
            }
            set
            {
                if (value >= 20 && value <= 240)
                    this._bgFPS = value;
                else
                    this._bgFPS = 20;
            }
        }

        public void Save(string path)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            XmlDocument doc = new XmlDocument();

            XmlElement root = doc.CreateElement("Config");

            XmlElement general = doc.CreateElement("General");

            XmlElement language = doc.CreateElement("Language");

            language.SetAttribute("value", this._language);

            general.AppendChild(language);

            root.AppendChild(general);

            XmlElement graphics = doc.CreateElement("Graphics");

            XmlElement vsync = doc.CreateElement("VSync");

            vsync.SetAttribute("value", this._vsync ? "true" : "false");

            graphics.AppendChild(vsync);

            XmlElement resolution = doc.CreateElement("Resolution");

            resolution.SetAttribute("value", this._resolution);

            graphics.AppendChild(resolution);

            XmlElement fullscreen = doc.CreateElement("FullscreenMode");

            fullscreen.SetAttribute("value", this._fullscreen.ToString());

            graphics.AppendChild(fullscreen);

            XmlElement refreshrate = doc.CreateElement("RefreshRate");

            refreshrate.SetAttribute("value", this._refreshRate.ToString());

            graphics.AppendChild(refreshrate);

            XmlElement quality = doc.CreateElement("Quality");

            quality.SetAttribute("value", this._quality.ToString());

            graphics.AppendChild(quality);

            root.AppendChild(graphics);

            XmlElement sound = doc.CreateElement("Sound");

            XmlElement ssound = doc.CreateElement("Sound");

            ssound.SetAttribute("value", this._sound.ToString(nfi));

            sound.AppendChild(ssound);

            XmlElement music = doc.CreateElement("Music");

            music.SetAttribute("value", this._music.ToString(nfi));

            sound.AppendChild(music);

            XmlElement menu = doc.CreateElement("Menu");

            menu.SetAttribute("value", this._menu.ToString(nfi));

            sound.AppendChild(menu);

            root.AppendChild(sound);

            XmlElement ao = doc.CreateElement("AmbientOcclusion");

            ao.SetAttribute("value", this._ao.ToString());

            root.AppendChild(ao);

            XmlElement antialias = doc.CreateElement("Antialiasing");

            antialias.SetAttribute("value", this._antialias.ToString());

            root.AppendChild(antialias);

            XmlElement dof = doc.CreateElement("DepthOfField");

            dof.SetAttribute("value", this._dof.ToString());

            root.AppendChild(dof);

            XmlElement motionblur = doc.CreateElement("MotionBlur");

            motionblur.SetAttribute("value", this._motionblur.ToString());

            root.AppendChild(motionblur);

            XmlElement rendersize = doc.CreateElement("RenderSize");

            rendersize.SetAttribute("value", this._rendersize.ToString(nfi));

            root.AppendChild(rendersize);

            XmlElement init = doc.CreateElement("InitialConfig");

            init.SetAttribute("value", "false");

            root.AppendChild(init);

            XmlElement lockCursor = doc.CreateElement("LockCursor");

            lockCursor.SetAttribute("value", this._lockCursor ? "true" : "false");

            root.AppendChild(lockCursor);

            XmlElement targetFPS = doc.CreateElement("TargetFramerate");

            targetFPS.SetAttribute("value", this._targetFPS.ToString());

            root.AppendChild(targetFPS);

            XmlElement bgFPS = doc.CreateElement("BGFramerate");

            bgFPS.SetAttribute("value", this._bgFPS.ToString());

            root.AppendChild(bgFPS);
            doc.AppendChild(root);

            doc.Save(path);
        }
    }
}
