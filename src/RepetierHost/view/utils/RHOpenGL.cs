using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;
using System.Windows.Forms;

namespace RepetierHost.view.utils
{
    public class RHOpenGL : OpenTK.GLControl
    {
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }
    }
}
