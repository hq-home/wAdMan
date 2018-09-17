using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wAdMan
{
    public class PlatformListView : ListView
    {
        public PlatformListView(){
            var columnHeaders = new System.Windows.Forms.ColumnHeader[] {
                new System.Windows.Forms.ColumnHeader(),
                new System.Windows.Forms.ColumnHeader(),
                new System.Windows.Forms.ColumnHeader()
            };

            this.Columns.AddRange(columnHeaders);

            this.Controls.AddRange(new Control[]{
                new System.Windows.Forms.CheckBox(),
                new System.Windows.Forms.PictureBox(),
                new System.Windows.Forms.Label()
            });

        }
    }
}
