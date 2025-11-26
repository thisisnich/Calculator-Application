using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calculator_Application
{
    public class StyledTabControl : TabControl
    {
        private Color _baseBackColor = SystemColors.Control;
        private Color _inactiveBackColor = Color.LightGray;
        private Color _inactiveForeColor = Color.Black;
        private Color _activeBackColor = Color.DodgerBlue;
        private Color _activeForeColor = Color.White;

        public StyledTabControl()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            DrawMode = TabDrawMode.Normal;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new Size(80, 30);
        }

        public void ApplyColors(ThemeColors colors)
        {
            _baseBackColor = colors.FormBackColor;
            _inactiveBackColor = colors.NeutralButtonBackColor;
            _inactiveForeColor = colors.NeutralButtonForeColor;
            _activeBackColor = colors.OperatorButtonBackColor;
            _activeForeColor = colors.OperatorButtonForeColor;
            foreach (TabPage page in TabPages)
            {
                page.BackColor = colors.FormBackColor;
                page.ForeColor = colors.TextBoxForeColor;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TabCount == 0)
                return;

            Rectangle header = GetTabRect(0);
            Rectangle headerArea = new Rectangle(0, 0, Width, header.Bottom + 2);
            using (var brush = new SolidBrush(_baseBackColor))
            {
                e.Graphics.FillRectangle(brush, headerArea);
            }

            for (int i = 0; i < TabCount; i++)
            {
                DrawTabButton(e.Graphics, i);
            }
        }

        private void DrawTabButton(Graphics g, int index)
        {
            Rectangle rect = GetTabRect(index);
            bool selected = index == SelectedIndex;
            bool hover = rect.Contains(PointToClient(Cursor.Position));

            Color back = selected ? _activeBackColor :
                hover ? Lighten(_inactiveBackColor, 12) : _inactiveBackColor;
            Color fore = selected ? _activeForeColor : _inactiveForeColor;

            using (var brush = new SolidBrush(back))
            {
                g.FillRectangle(brush, rect);
            }

            TextRenderer.DrawText(
                g,
                TabPages[index].Text,
                new Font(Font.FontFamily, 9f, FontStyle.Bold),
                rect,
                fore,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private static Color Lighten(Color color, int amount)
        {
            int r = Math.Min(255, color.R + amount);
            int g = Math.Min(255, color.G + amount);
            int b = Math.Min(255, color.B + amount);
            return Color.FromArgb(r, g, b);
        }
    }
}




