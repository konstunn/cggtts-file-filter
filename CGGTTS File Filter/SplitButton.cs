﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CGGTTS_File_Filter
{
    public class SplitButton : Button
    {
        [DefaultValue(20), Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int SplitWidth { get; set; }

        public SplitButton()
        {
            SplitWidth = 20;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            var splitRect = new Rectangle(this.Width - this.SplitWidth, 0, this.SplitWidth, this.Height);

            // Figure out if the button click was on the button itself or the menu split
            if (ContextMenuStrip != null &&
                mevent.Button == MouseButtons.Left &&
                splitRect.Contains(mevent.Location))
            {
                ContextMenuStrip.Show(this, 0, this.Height);    // Shows menu under button
                //Menu.Show(this, mevent.Location); // Shows menu at click location
            }
            else
            {
                base.OnMouseDown(mevent);
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (this.ContextMenuStrip != null && this.SplitWidth > 0)
            {
                // Draw the arrow glyph on the right side of the button
                int arrowX = ClientRectangle.Width - 14;
                int arrowY = ClientRectangle.Height / 2 - 1;

                var arrowBrush = Enabled ? SystemBrushes.ControlText : SystemBrushes.ButtonShadow;

                var arrowPoints = 
                    new[] { new Point(arrowX, arrowY), 
                    new Point(arrowX + 7, arrowY), 
                    new Point(arrowX + 3, arrowY + 4) };

                pevent.Graphics.FillPolygon(arrowBrush, arrowPoints);

                // Draw a separator on the left of the arrow
                int lineX = ClientRectangle.Width - this.SplitWidth;
                int lineYFrom = arrowY - 6;
                int lineYTo = arrowY + 8;
                using (var separatorPen = new Pen(Brushes.DarkGray) { DashStyle = DashStyle.Solid })
                {
                    pevent.Graphics.DrawLine(separatorPen, lineX, lineYFrom, lineX, lineYTo);
                }
            }
        }
    }
}
