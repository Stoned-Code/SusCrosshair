using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_SC.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SusCrosshair.Utils
{
    internal class CrosshairSettings
    {
        public static CrosshairSettings Instance;

        private int _r, _g, _b, _size;

        public int R
        {
            get => _r;

            set
            {
                _r = value.Clamp(0, 255);
                WriteJson();
            }

        }

        public int G
        {
            get => _g;

            set
            {
                _g = value.Clamp(0, 255);
                WriteJson();
            }

        }

        public int B
        {
            get => _b;

            set
            {
                _b = value.Clamp(0, 255);
                WriteJson();
            }

        }

        public int Size
        {
            get => _size;

            set
            {
                _size = value.Clamp(1, 72);
                WriteJson();
            }

        }

        public static void Init()
        {
            var env = Environment.CurrentDirectory;
            var settings = Path.Join(env, "Settings.json");

            if (File.Exists(settings))
            {
                var json = "";

                using (var sr = new StreamReader(settings))
                {
                    json = sr.ReadToEnd();
                }

                var jObj = JsonConvert.DeserializeObject(json) as JObject;

                Instance = new CrosshairSettings();

                Instance.R = jObj.GetValue("R").Value<int>();
                Instance.G = jObj.GetValue("G").Value<int>();
                Instance.B = jObj.GetValue("B").Value<int>();
                Instance.Size = jObj.GetValue("Size").Value<int>();

                return;
            }

            Instance = new CrosshairSettings();

            Instance.R = 0;
            Instance.G = 255;
            Instance.B = 0;
            Instance.Size = 32;

            Instance.WriteJson();
        }

        public void WriteJson()
        {
            var env = Environment.CurrentDirectory;
            var settings = Path.Join(env, "Settings.json");

            var jObj = new JObject();

            jObj.Add("R", R);
            jObj.Add("G", G);
            jObj.Add("B", B);
            jObj.Add("Size", Size);

            using (var sw = new StreamWriter(settings))
            {
                sw.Write(jObj.ToString());
            }
        }
    }
}
