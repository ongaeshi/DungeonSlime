using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace DungeonSlime
{
    public class Game1 : Core
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // The MonoGame logo texture
        private Texture2D _logo;

        public Game1() 
            : base("Dungeon Slime", 1280, 720, fullScreen: false)
        {
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _logo = Content.Load<Texture2D>("images/logo");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Begin the sprite batch to prepare for rendering.
            SpriteBatch.Begin();

            // Draw the logo texture
            SpriteBatch.Draw(
                texture: _logo,
                position: new Vector2(
                    (Window.ClientBounds.Width * 0.5f) - (_logo.Width * 0.5f),
                    (Window.ClientBounds.Height * 0.5f) - (_logo.Height * 0.5f)),
                sourceRectangle: null, 
                color: Color.White,
                rotation: 0.0f,
                origin: Vector2.Zero,
                scale: 1.0f,
                effects: SpriteEffects.None, // 縦や横軸のフリップ
                layerDepth: 0.0f); // テクスチャがレンダリングされる深さ

            // Always end the sprite batch when finished.
            SpriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
