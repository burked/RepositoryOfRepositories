using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace BugSmasher
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D Background, Spritesheet;
        Sprite Cursor;
        List<Sprite> Bugs = new List<Sprite>();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        Random Number = new Random();
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Background = Content.Load<Texture2D>("background");
            Spritesheet = Content.Load<Texture2D>("spritesheet");
            Cursor = new Sprite(new Vector2(40, 40), Spritesheet, new Rectangle(135, 197, 48, 52), Vector2.Zero);

            for (int i = 0; i < 20; i++ )
            {

                spawnbug();
            }
        }
        public void spawnbug()
        {
            
            int X = Number.Next(1, 400);
            int Y = Number.Next(1, 400);
            Bugs.Add(new Sprite(new Vector2(0, Y), Spritesheet, new Rectangle(0, 0, 64, 64), new Vector2(100, 0)));
        }
        protected override void UnloadContent()
        {
           
        }

        
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            
            base.Update(gameTime);

            for (int L = 0; L < Bugs.Count; L++)
            {
                int RandX = Number.Next(-3, 3);
                int RandY = Number.Next(-3, 3);
               
                    Bugs[L].Update(gameTime);
            }
            base.Update(gameTime);

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
           
            spriteBatch.Draw(Background,new Rectangle(0,0,this.Window.ClientBounds.Width,this.Window.ClientBounds.Height), Color.White);
            int X = Number.Next(1, 400);
            int Y = Number.Next(1, 400);
            for (int L = 0; L < Bugs.Count; L++)
            {
                Bugs[L].Draw(spriteBatch);
            }
            spriteBatch.End(); 
            base.Draw(gameTime);
        }   
    }
}
