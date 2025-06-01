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

        private Texture2D _textureAtlas;
        private Rectangle _paddleSourceRect;
        private Rectangle _ballSourceRect;
        private Vector2 _leftPaddlePosition;
        private Vector2 _rightPaddlePosition;
        private Vector2 _ballPosition;

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
            _textureAtlas = Content.Load<Texture2D>("pong-atlas");
            _paddleSourceRect = new Rectangle(0, 0, 32, 32);
            _ballSourceRect = new Rectangle(32, 0, 32, 32);
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

            _leftPaddlePosition = new Vector2(50, GraphicsDevice.Viewport.Height / 2 - _paddleSourceRect.Height / 2);
            _rightPaddlePosition = new Vector2(GraphicsDevice.Viewport.Width - 50 - _paddleSourceRect.Width, GraphicsDevice.Viewport.Height / 2 - _paddleSourceRect.Height / 2);
            _ballPosition = new Vector2(GraphicsDevice.Viewport.Width / 2 - _ballSourceRect.Width / 2, GraphicsDevice.Viewport.Height / 2 - _ballSourceRect.Height / 2);

            SpriteBatch.Begin();

            // All draw calls use the same texture, so there is no texture swapping!
            SpriteBatch.Draw(_textureAtlas, _leftPaddlePosition, _paddleSourceRect, Color.White);
            SpriteBatch.Draw(_textureAtlas, _rightPaddlePosition, _paddleSourceRect, Color.White);
            SpriteBatch.Draw(_textureAtlas, _ballPosition, _ballSourceRect, Color.White);

            SpriteBatch.End();
        }
    }
}
