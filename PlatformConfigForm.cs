using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wAdMan
{
    public partial class PlatformConfigForm : Form
    {
        public List<ConfigPlatform> Platforms { get; set; }
        private List<ConfigPlatform> originalPlatforms;

        private bool _hasChanges;
        public bool HasChanges { get { return _hasChanges; } }
        public PlatformConfigForm()
        {
            InitializeComponent();

            var toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.btnDelete, "Delete Platform");
            toolTip.SetToolTip(this.btnAdd, "Add Platform");
            toolTip.SetToolTip(this.btnBrowsePath, "Browse folder");
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            fbdPath.ShowDialog(this);
        }

        private void PlatformConfigForm_Load(object sender, EventArgs e)
        {
            if(Platforms == null) Platforms = new List<ConfigPlatform>();
            originalPlatforms = Platforms.Select(p => new ConfigPlatform() { Name = p.Name, Path = p.Path }).ToList();

            lbPlatforms.DataSource = Platforms;
            lbPlatforms.DisplayMember = "Name";
            lbPlatforms.ValueMember = "Path";

            lvPlatforms.OwnerDraw = true;
            LoadListView(Platforms);
        }

        private void LoadListView(List<ConfigPlatform> platforms)
        {
            // Get the table from the data set
            //DataTable dtable = _DataSet.Tables["Titles"];

            // Clear the ListView control
            lvPlatforms.Items.Clear();

            // Display items in the ListView control
            for (int i = 0; i < platforms.Count; i++)
            {
                var p = platforms[i];

                // Define the list items
                ListViewItem lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(p.Path);


                if (i == 1)
                {
                    lvi.ImageIndex = 0;
                    lvi.ForeColor = Color.Red;
                    lvi.ToolTipText = "Corrupted data";
                }


                // Add the list items to the ListView
                lvPlatforms.Items.Add(lvi);
                
                
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _hasChanges = originalPlatforms.Count != lbPlatforms.Items.Count;
            for (var i = 0; i < originalPlatforms.Count && !_hasChanges; i++) 
            {
                _hasChanges = _hasChanges
                    || originalPlatforms[i].Name != (lbPlatforms.Items[i] as ConfigPlatform).Name
                    || originalPlatforms[i].Path != (lbPlatforms.Items[i] as ConfigPlatform).Path;
            }

            if (_hasChanges) { 
                Platforms = lbPlatforms.Items.OfType<ConfigPlatform>().Select(p => new ConfigPlatform() { Name = p.Name, Path = p.Path }).ToList();

            Config.SaveCurrent();

            base.OnClosing(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void lbPlatforms_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Visible =
            pnlControls.Visible = lbPlatforms.SelectedIndex > -1;

            if (pnlControls.Visible) 
            {
                var p = (ConfigPlatform)lbPlatforms.SelectedItem;
                tbName.Text = p.Name;
                tbPath.Text = p.Path;
            }
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            //Unique
        }

        private void tbPath_Leave(object sender, EventArgs e)
        {
            // Unique
        }

        private void lvPlatforms_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvPlatforms_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if(!e.Item.Selected) SetRowBackground(e);
            else
            {
                e.DrawDefault = false;
                //e.Graphics.DrawRectangle(new Pen(Brushes.Yellow, 1.0f), e.Bounds); //
                e.Graphics.FillRectangle(Brushes.Yellow, e.Bounds);
                //e.DrawText(TextFormatFlags.TextBoxControl);
            }
        }

        private void lvPlatforms_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            SetRowBackground(e);
        }

        private static void SetRowBackground(EventArgs e)
        {
            var itemArgs = new LVItemArgsDto(e);

            itemArgs.DrawDefault = true;
            if (( itemArgs.ItemIndex % 2) == 1)
            {
                itemArgs.Item.BackColor = Color.FromArgb(240, 240, 250);
                itemArgs.Item.UseItemStyleForSubItems = true;
            }
        }

        
    }

    public class LVItemArgsDto
    {
        public int ItemIndex { 
            get {
                return item != null ? item.ItemIndex :
                    subitem != null ? subitem.ItemIndex :
                    -1;
            } 
        }
        public ListViewItem Item
        {
            get
            {
                return item != null ? item.Item :
                    subitem != null ? subitem.Item :
                    null;
            }
        }

        private DrawListViewItemEventArgs item = null;
        private DrawListViewSubItemEventArgs subitem = null;

        public bool DrawDefault 
        {
            get {
                return item != null ? item.DrawDefault :
                    subitem != null ? subitem.DrawDefault :
                    false;
            }
            set {
                if (item != null) item.DrawDefault = value;
                else if (subitem != null) subitem.DrawDefault = value;
            }
        }


        public LVItemArgsDto(EventArgs e) 
        {
            item = e as DrawListViewItemEventArgs;
            subitem = e as DrawListViewSubItemEventArgs;
        }
    }
}
