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
    public static class Game1 : Microsoft.Xna.Framework.Game
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
            int X = Number.Next(1,400);
            int Y = Number.Next(1,400);
            for (int L = 0; L > 20; ++L)
            {
                int I = 0;
                ++I;
                for (int K = 0; K > 20; ++K)
                {
                    Bugs[I] = new Sprite(new Vector2(X, Y), Spritesheet, new Rectangle(0, 0, 0, 0), Vector2.Zero);
                }




            }
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// if (Check == 1)
        ///    {int I = 0; }
        ///    else if (Check == 2)
       ///     {int I = 0;}
       ///     else if (Check == 3)
         ///   {int I = 0;}
       ///     else if (Check == 4)
        ///    {int I = 0;}
         ///   else if (Check == 5)
         ///   {int I = 0;}
        ///    else if (Check == 6)
        ///    {int I = 0;}
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            
            base.Update(gameTime);
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.Draw(Background, Vector2.Zero, Color.White);
            int X = Number.Next(1, 400);
            int Y = Number.Next(1, 400);
            for (int L = 0; L > 20; ++L)
            {
                int I = 0;
                ++I;
                for (int K = 0; K > 20; ++K)
                {
                    Bugs[I].Update(gameTime);
                }

            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
           
            SpriteBatch.Draw(Background, Vector2.Zero, Color.White);
            int X = Number.Next(1, 400);
            int Y = Number.Next(1, 400);
            for (int L = 0; L > 20; ++L)
            {
                int I = 0;
                ++I;
                for (int K = 0; K > 20; ++K)
                {
                    Bugs[I].Draw(spriteBatch);
                }

            }
            spriteBatch.End(); 
            base.Draw(gameTime);
        }   
    }
}
//            GraphicsDevice.Clear(Color.CornflowerBlue);
   //         spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
       //     spriteBatch.Draw(background, Vector2.Zero, Color.White);
    //        Bug.Draw(spriteBatch);
       //     Cursor.Draw(spriteBatch);
      //      spriteBatch.End();