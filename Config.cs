using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace wAdMan
{
    public static class Config
    {
        public static JSONConfig _current;
        private static string _originJSON;
        public static JSONConfig Current 
        {
            get {
                if (_current == null) {
                    _current = LoadFromFile("config.json");
                    _originJSON = ToString(_current);
                }

                return _current;
            }
        }

        public static bool IsRequresUpdate() 
        {
            var curStr = Config.ToString(Config.Current);
            return _originJSON != curStr;
        }

        public static JSONConfig LoadFromFile(string filename)
        {
            var jss = new JavaScriptSerializer();

            var cfgJSON = File.ReadAllText(filename);
            var config = jss.Deserialize<JSONConfig>(cfgJSON);
            return config;
        }

        public static string ToString(JSONConfig jsonCfg)
        {
            var jss = new JavaScriptSerializer();
            return jss.Serialize(jsonCfg);
        }

        public static void SaveCurrent()
        {
            var jss = new JavaScriptSerializer();
            var cfgJSON = Config.ToString(Config.Current);
            if (_originJSON != cfgJSON)
            {
                //File.WriteAllText("config.json", cfgJSON);
                //_originJSON = cfgJSON;
            }
        }
    }

    public class JSONConfig
    {
        public int PlatformSelected = -1;
        public List<ConfigPlatform> Platforms = null;

        public ConfigAddonDefaults AddonDefaults;

        public List<List<ConfigAddonInfo>> Addons;
    }

    public class ConfigPlatform
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class ConfigAddonDefaults
    {
        public string ProjectUrl;
        public string CurseUrl;
        public ConfigAddonRegex ReLive;
        public ConfigAddonRegex ReBeta;
        public ConfigAddonRegex ReAlpha;

    }

    public class ConfigAddonRegex
    {
        public string Base;
        public string Path;
        public string Url;
        public string VersionName;
        public string TargetVersion;
    }

    public class ConfigAddonInfo
    {
        public string Name;
        public string RelUrl;
        public string AbsUrl;
        public ConfigAddonRegex ReLive;
        public ConfigAddonRegex ReBeta;
        public ConfigAddonRegex ReAlpha;
    }
}
