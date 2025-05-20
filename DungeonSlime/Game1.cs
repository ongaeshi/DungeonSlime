using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using System.Linq;

namespace DungeonSlime
{
    public class Game1 : Core
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // The MonoGame logo texture
        private Texture2D _logo;

        public Game1() 
            : base("Dungeon Slime", 1280/2, 720/2, fullScreen: false)
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

            // マウス左ボタンが押されている場合は逆回転
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                _rotation -= 0.01f;
            }
            else
            {
                // 通常は正回転
                _rotation += 0.01f;
            }

            base.Update(gameTime);
        }

        private float _rotation = 0f;

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Begin the sprite batch to prepare for rendering.
            SpriteBatch.Begin();

            // Draw the logo texture
            SpriteBatch.Draw(_logo, Vector2.Zero, Color.White);

            // Enumerable.Rangeで複数のロゴを回転させて描画
            Enumerable.Range(1, 10).ToList().ForEach(i =>
            {
                // ロゴの中心を原点にして回転
                var position = new Vector2(i * 100, i * 100);
                var origin = new Vector2(_logo.Width / 2f, _logo.Height / 2f);
                SpriteBatch.Draw(_logo, position, null, Color.White, _rotation, origin, 1f, SpriteEffects.None, 0f);
            });

            // Always end the sprite batch when finished.
            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
