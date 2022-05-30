using System.IO;
using System.Xml.Serialization;

namespace lab_4
{
    public class Config
    {
        public bool IsNullProp()
        {
            return string.IsNullOrEmpty(ChordLength) && string.IsNullOrEmpty(ArcLength) && Radius == null && Alpha == null;
        }
        public static Config GetConfig()
        {
            Config config = null;
            string filename = Global.Config;
            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Config));
                    config = (Config)xml.Deserialize(fs);
                    fs.Close();
                }
            }
            else config = new Config();

            return config;
        }
        public void Save()
        {
            string filename = Global.Config;
            if (File.Exists(filename)) File.Delete(filename);
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Config));
                xml.Serialize(fs, this);
                fs.Close();
            }
        }

        public void Clear()
        {
            Radius = null;
            ArcLength = string.Empty;
            ChordLength = string.Empty;
            Alpha = null;
        }
        public double? Radius { get; set; }
        public string ArcLength{ get; set; }
        public string ChordLength { get; set; }
        public double? Alpha { get; set; }
    }
}
