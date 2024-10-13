using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPaintDesktop.Rendering
{
    public class ToolStripRender : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            // Set color for the selected
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(61, 61, 61)), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.White;
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(46, 46, 46)), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.White;
            }
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(31, 31, 31)), e.AffectedBounds);
        }

        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            e.Graphics.DrawImage(e.Image, e.ImageRectangle);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            base.OnRenderToolStripBorder(e);
        }
    }
}