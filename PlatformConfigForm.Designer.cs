namespace wAdMan
{
    partial class PlatformConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem",
            "ListViewSubItem0"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlatformConfigForm));
            this.lbPlatforms = new System.Windows.Forms.ListBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lvPlatforms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.dlvPlatforms = new BrightIdeasSoftware.DataListView();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvPlatforms)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlatforms
            // 
            this.lbPlatforms.FormattingEnabled = true;
            this.lbPlatforms.Location = new System.Drawing.Point(13, 13);
            this.lbPlatforms.Name = "lbPlatforms";
            this.lbPlatforms.Size = new System.Drawing.Size(249, 121);
            this.lbPlatforms.TabIndex = 0;
            this.lbPlatforms.SelectedIndexChanged += new System.EventHandler(this.lbPlatforms_SelectedIndexChanged);
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Location = new System.Drawing.Point(255, 25);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(24, 23);
            this.btnBrowsePath.TabIndex = 25;
            this.btnBrowsePath.Text = "...";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.btnBrowsePath_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name (Unique)";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(0, 30);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(95, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path (Game folder)";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(94, 0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 15;
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(94, 27);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(155, 20);
            this.tbPath.TabIndex = 20;
            this.tbPath.Leave += new System.EventHandler(this.tbPath_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 54);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fbdPath
            // 
            this.fbdPath.ShowNewFolderButton = false;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.tbName);
            this.pnlControls.Controls.Add(this.btnBrowsePath);
            this.pnlControls.Controls.Add(this.lblName);
            this.pnlControls.Controls.Add(this.btnSave);
            this.pnlControls.Controls.Add(this.lblPath);
            this.pnlControls.Controls.Add(this.tbPath);
            this.pnlControls.Location = new System.Drawing.Point(12, 140);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(279, 78);
            this.pnlControls.TabIndex = 31;
            this.pnlControls.Visible = false;
            // 
            // lvPlatforms
            // 
            this.lvPlatforms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPlatforms.FullRowSelect = true;
            this.lvPlatforms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPlatforms.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.lvPlatforms.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPlatforms.Location = new System.Drawing.Point(299, 13);
            this.lvPlatforms.MultiSelect = false;
            this.lvPlatforms.Name = "lvPlatforms";
            this.lvPlatforms.ShowItemToolTips = true;
            this.lvPlatforms.Size = new System.Drawing.Size(314, 121);
            this.lvPlatforms.SmallImageList = this.smallImageList;
            this.lvPlatforms.TabIndex = 32;
            this.lvPlatforms.UseCompatibleStateImageBehavior = false;
            this.lvPlatforms.View = System.Windows.Forms.View.Details;
            this.lvPlatforms.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvPlatforms_DrawColumnHeader);
            this.lvPlatforms.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvPlatforms_DrawItem);
            this.lvPlatforms.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvPlatforms_DrawSubItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 211;
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "warn16.png");
            // 
            // dlvPlatforms
            // 
            this.dlvPlatforms.DataSource = null;
            this.dlvPlatforms.FullRowSelect = true;
            this.dlvPlatforms.Location = new System.Drawing.Point(620, 13);
            this.dlvPlatforms.Name = "dlvPlatforms";
            this.dlvPlatforms.Size = new System.Drawing.Size(296, 121);
            this.dlvPlatforms.TabIndex = 33;
            this.dlvPlatforms.UseCompatibleStateImageBehavior = false;
            this.dlvPlatforms.View = System.Windows.Forms.View.Details;
            // 
            // PlatformConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 228);
            this.Controls.Add(this.dlvPlatforms);
            this.Controls.Add(this.lvPlatforms);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbPlatforms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlatformConfigForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Platforms Config";
            this.Load += new System.EventHandler(this.PlatformConfigForm_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlvPlatforms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlatforms;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ListView lvPlatforms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList smallImageList;
        private BrightIdeasSoftware.DataListView dlvPlatforms;
    }
}