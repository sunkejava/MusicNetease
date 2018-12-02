using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicNetease.Controls
{
    public partial class UserControl_Srfm : UserControl
    {
        public UserControl_Srfm()
        {
            InitializeComponent();
        }

        private void UserControl_Srfm_Load(object sender, EventArgs e)
        {
            LayeredSkin.DirectUI.DuiTextBox dText = new LayeredSkin.DirectUI.DuiTextBox();
            dText.BackColor = Color.Transparent;
            dText.ReadOnly = true;
            dText.Text = global::MusicNetease.Properties.Resources.DefaultLyric;
            dText.RollSize = 20;
            dText.Dock = DockStyle.Fill;
            dText.TextRenderMode = System.Drawing.Text.TextRenderingHint.SystemDefault;
            dText.Multiline = true;
            layeredBaseControl_gc.DUIControls.Add(dText);
        }
    }
}
