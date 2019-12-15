using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationProject
{
    class Sprite
    {
        public Texture2D Image { get; private set; }
        public Vector2 Position { get; private set; }
        public Rectangle? sourceRectangle { get; private set; }
        public Color color { get; private set; }
        public float Rotation { get; private set; }
        public Vector2 Origin { get; private set; }
        public Vector2 Scale { get; private set; }
        public SpriteEffects effects { get; private set; }
        public float layerDepth { get; private set; }

        public Sprite(Texture2D image, Vector2 position, Color color, float Rotation, Vector2 Origin, Vector2 Scale )
        {
            this.Image = image;
            this.Position = position;
            sourceRectangle = null;
            color = Color.White;
            Rotation = 0;
            Origin = new Vector2(0, 0);
            Scale = new Vector2(1, 1);
            effects = SpriteEffects.None;
            layerDepth = 0;
        }
        public Sprite(Texture2D image, Vector2 position, Color color, float Rotation, Vector2 Origin)
            : this (image, position, color, Rotation, Origin, Vector2.One)
        {

        }



      public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, sourceRectangle, color, Rotation, Origin, Scale, effects, layerDepth);
        }

      
    }
}
