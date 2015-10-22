using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMineCraft
{
    class ScreenCamera
    {
        public Matrix transform;
        Viewport view;
        Vector2 centre;

        public ScreenCamera(Viewport view)
        {
            this.view = view; 
        }

        public void Update(GameTime gameTime, Game1 ship)
        {
            centre = new Vector2(500.0f, 500.0f);
            transform = Matrix.CreateScale(new Vector3(1, 1, 0)) * Matrix.CreateTranslation(new Vector3(-centre.X, -centre.Y,0));
        }
    }
}
