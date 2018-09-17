namespace wAdMan
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.cbPlatforms = new System.Windows.Forms.ComboBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.btnCfgPlatform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPlatforms
            // 
            this.cbPlatforms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlatforms.FormattingEnabled = true;
            this.cbPlatforms.Location = new System.Drawing.Point(63, 12);
            this.cbPlatforms.Name = "cbPlatforms";
            this.cbPlatforms.Size = new System.Drawing.Size(152, 21);
            this.cbPlatforms.TabIndex = 0;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(12, 15);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(45, 13);
            this.lblPlatform.TabIndex = 1;
            this.lblPlatform.Text = "Platform";
            // 
            // btnCfgPlatform
            // 
            this.btnCfgPlatform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCfgPlatform.BackgroundImage")));
            this.btnCfgPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCfgPlatform.Location = new System.Drawing.Point(219, 11);
            this.btnCfgPlatform.Name = "btnCfgPlatform";
            this.btnCfgPlatform.Size = new System.Drawing.Size(26, 23);
            this.btnCfgPlatform.TabIndex = 2;
            this.btnCfgPlatform.UseVisualStyleBackColor = true;
            this.btnCfgPlatform.Click += new System.EventHandler(this.btnCfgPlatform_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 582);
            this.Controls.Add(this.btnCfgPlatform);
            this.Controls.Add(this.lblPlatform);
            this.Controls.Add(this.cbPlatforms);
            this.Name = "mainForm";
            this.Text = "wAdMan";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPlatforms;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Button btnCfgPlatform;
    }
}

