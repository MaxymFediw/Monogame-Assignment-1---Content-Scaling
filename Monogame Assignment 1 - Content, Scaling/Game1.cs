using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogame_Assignment_1___Content__Scaling //Maxym F.
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Random generator;

        Rectangle window;

        Texture2D backgroundTexture;
        Rectangle backgroundRect;

        Texture2D stanTexture;
        Rectangle stanRect;

        Texture2D cartmanTexture;
        Rectangle cartmanRect;

        Texture2D kyleTexture;
        Rectangle kyleRect;

        Texture2D kennyTexture;
        Rectangle kennyRect;

        Texture2D buttersTexture;
        Rectangle buttersRect;



        SpriteFont titleFont;

        float textOpacity;




        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            Window.Title = "The Boys of South Park";

            generator = new Random();

            window = new Rectangle(0, 0, 800, 500); //        x, y, width, height

            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            backgroundRect = new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);

            cartmanRect = new Rectangle(67, 348, 165, 152);
            buttersRect = new Rectangle(222, 348, 100, 152);
            stanRect = new Rectangle(332, 348, 100, 152);
            kyleRect = new Rectangle(442, 348, 122, 152);
            kennyRect = new Rectangle(572, 348, 112, 150);

            textOpacity = 0f;


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            backgroundTexture = Content.Load<Texture2D>("Images/cartmanHouse");

            cartmanTexture = Content.Load<Texture2D>("Images/Cartman");
            kyleTexture = Content.Load<Texture2D>("Images/Kyle");
            stanTexture = Content.Load<Texture2D>("Images/Stan");
            buttersTexture = Content.Load<Texture2D>("Images/Butters");
            kennyTexture = Content.Load<Texture2D>("Images/Kenny");

            titleFont = Content.Load<SpriteFont>("Fonts/TitleFont");


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            textOpacity += .0005f;

            base.Update(gameTime);

            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            
            
            _spriteBatch.Draw(backgroundTexture, backgroundRect, Color.White);

            _spriteBatch.Draw(cartmanTexture, cartmanRect, Color.White);

            _spriteBatch.Draw(kyleTexture, kyleRect, Color.White);

            _spriteBatch.Draw(kennyTexture, kennyRect, Color.White * textOpacity);

            _spriteBatch.Draw(stanTexture, stanRect, Color.White);

            _spriteBatch.Draw(buttersTexture, buttersRect, Color.White);


            _spriteBatch.DrawString(titleFont, "Come on Down To South Park, and meet some friends of mine.", new Vector2(65, 8), Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
