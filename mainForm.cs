using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace wAdMan
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            var toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.btnCfgPlatform, "Configure Platforms");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var platforms = Config.Current.Platforms;
            if (!platforms.Any()) 
            {
                platforms = DetectPlatforms();

                if (platforms.Any())
                {
                    Config.Current.Platforms = platforms;
                }
            }

            platforms.Insert(0, new ConfigPlatform() { Name = "None" });

            cbPlatforms.ValueMember = "Path";
            cbPlatforms.DisplayMember = "Name";
            cbPlatforms.DataSource = platforms;
            cbPlatforms.SelectedIndex = 0;
            cbPlatforms.SelectedIndexChanged += cbPlatforms_SelectedIndexChanged;
        }

        void cbPlatforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbPlatforms.SelectedIndex;
            var platforms = (List<ConfigPlatform>)cbPlatforms.DataSource;
            if (platforms[0].Name == "None") 
            {
                cbPlatforms.SelectedIndexChanged -= cbPlatforms_SelectedIndexChanged;

                platforms.RemoveAt(0);
                cbPlatforms.DataSource = null;
                cbPlatforms.DisplayMember = "Name";
                cbPlatforms.DataSource = platforms;
                cbPlatforms.SelectedIndex = selectedIndex - 1;
                cbPlatforms.Invalidate();

                cbPlatforms.SelectedIndexChanged += cbPlatforms_SelectedIndexChanged;
            }
        }

        private List<ConfigPlatform> DetectPlatforms()
        {
            var basePath = @"SOFTWARE\Wow6432Node\Blizzard Entertainment\";
            var Live = "World of Warcraft";
            var Beta = @"World of Warcraft\Beta";
            var Ptr = @"World of Warcraft\PTR";
            var parName = "InstallPath";
            var parNameOld = "GamePath";
            
            List<ConfigPlatform> list = new List<ConfigPlatform>();

            RegistryKey key = Registry.LocalMachine.OpenSubKey(basePath + Live);
            if (key != null)
            {
                var p = new ConfigPlatform() { Name = "WoW Live", Path = (string)key.GetValue(parName) };
                list.Add(p);
                key.Close();
            }

            key = Registry.LocalMachine.OpenSubKey(basePath + Beta);
            if (key != null)
            {
                var p = new ConfigPlatform() { Name = "WoW Beta", Path = (string)key.GetValue(parName) };
                list.Add(p);
                key.Close();
            }

            key = Registry.LocalMachine.OpenSubKey(basePath + Ptr);
            if (key != null)
            {
                var p = new ConfigPlatform() { Name = "WoW Ptr", Path = (string)key.GetValue(parName) };
                list.Add(p);
                key.Close();
            }

            return list;
            
        }

        private void btnCfgPlatform_Click(object sender, EventArgs e)
        {
            pConfig.Platforms = (cbPlatforms.DataSource as List<ConfigPlatform>).Where(p => p.Path != null).ToList();
            pConfig.ShowDialog(this);

            if (pConfig.HasChanges) 
            {
                cbPlatforms.SelectedIndexChanged -= cbPlatforms_SelectedIndexChanged;

                var selectedValue = (string)cbPlatforms.SelectedValue;
                var selectedIndex = cbPlatforms.SelectedIndex;

                cbPlatforms.DataSource = null;
                cbPlatforms.DisplayMember = "Name";
                cbPlatforms.DataSource = pConfig.Platforms;
                cbPlatforms.Invalidate();

                int idx = 0;
                if (selectedValue != null) 
                {
                    idx = pConfig.Platforms.FindIndex((p) => p.Path == selectedValue) + 1;
                    if(idx > 0)cbPlatforms.SelectedIndex = idx;
                }
                cbPlatforms.SelectedIndexChanged += cbPlatforms_SelectedIndexChanged;

                if(idx == 0 && selectedValue != null)
                    cbPlatforms.SelectedIndex = 0;
            }
        }

        private PlatformConfigForm pConfig = new PlatformConfigForm();
    }
}
