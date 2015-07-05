/*Author: Nick Kroeze
 * Company: NA
 * Input/output: Keyboard, Screen
 * 
 */ 

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


namespace warGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        



        //Club cards
        Texture2D clubAce, clubTwo, clubThree, clubFour, clubFive, clubSix, clubSeven, clubEight, clubNine, clubTen,
            clubJack, clubQueen, clubKing;

        //Diamond Cards
        Texture2D diamondAce, diamondTwo, diamondThree, diamondFour, diamondFive, diamondSix, diamondSeven,
            diamondEight, diamondNine, diamondTen, diamondJack, diamondQueen, diamondKing;

        //Heart Cards
        Texture2D heartAce, heartTwo, heartThree, heartFour, heartFive, heartSix, heartSeven, heartEight, heartNine, heartTen,
            heartJack, heartQueen, heartKing;

        //Spade Cards
        Texture2D spadeAce, spadeTwo, spadeThree, spadeFour, spadeFive, spadeSix, spadeSeven, spadeEight, spadeNine, spadeTen, spadeJack, spadeQueen, spadeKing;


        //Card Backs
        Texture2D compBack, playerBack;

        //Give height and width to the cards
        static int compHeight, playerHeight;
        static int compWidth, playerWidth;
        
        //Place the 2 decks across from each other
        Vector2 playerDeck = new Vector2(10.0f, 270.0f);
        Vector2 compDeck = new Vector2(1260.0f, 270.0f);
        
        //give numerical values to the cards + suit 
        //11= Jack, 12=Queen, 13=King 1=Ace
        //s=spade, h= heart, d=diamond, c=clubs
        
        //first spades
        string s1 = "s1";
        string s2 = "s2";
        string s3 = "s3";
        string s4 = "s4";
        string s5 = "s5";
        string s6 = "s6";
        string s7 = "s7";
        string s8 = "s8";
        string s9 = "s9";
        string s10 = "s10";
        string sJack = "s11";
        string sQueen = "s12";
        string sKing = "s13";

        //Hearts
        string h1 = "h1"; string h2 = "h2"; string h3 = "h3"; string h4 = "h4";
        string h5 = "h5"; string h6 = "h6"; string h7 = "h7"; string h8 = "h8";
        string h9 = "h9"; string h10 = "h10"; string hJack = "h11"; string hQueen = "h12"; string hKing = "k13";

        //diamonds
        string d1 = "d1"; string d2 = "d2"; string d3 = "d3"; string d4 = "d4";
        string d5 = "d5"; string d6 = "d6"; string d7 = "d7"; string d8 = "d8";
        string d9 = "d9"; string d10 = "d10"; string dJack = "d11"; string dQueen = "d12"; string dKing = "d13";

        //Now clubs
        string c1 = "c1"; string c2 = "c2"; string c3 = "c3"; string c4 = "c4";
        string c5 = "c5"; string c6 = "c6"; string c7 = "c7"; string c8 = "c8";
        string c9 = "c9"; string c10 = "c10"; string cJack = "c11"; string cQueen = "c12"; string cKing = "c13";






        
        
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1400;
            graphics.PreferredBackBufferHeight = 700;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //Make the mouse visible
            IsMouseVisible = true;
            
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
            
            //Load Club Card Textures
            clubAce = Content.Load<Texture2D>("cardClubsA");
            clubTwo = Content.Load<Texture2D>("cardClubs2");
            clubThree = Content.Load<Texture2D>("cardClubs3");
            clubFour = Content.Load<Texture2D>("cardClubs4");
            clubFive = Content.Load<Texture2D>("cardClubs5");
            clubSix = Content.Load<Texture2D>("cardClubs6");
            clubSeven = Content.Load<Texture2D>("cardClubs7");
            clubEight = Content.Load<Texture2D>("cardClubs8");
            clubNine = Content.Load<Texture2D>("cardClubs9");
            clubTen = Content.Load<Texture2D>("cardClubs10");
            clubJack = Content.Load<Texture2D>("cardClubsJ");
            clubQueen = Content.Load<Texture2D>("cardClubsQ");
            clubKing = Content.Load<Texture2D>("cardClubsK");

            //Load Diamond Card Textures
            diamondAce = Content.Load<Texture2D>("cardDiamondsA");
            diamondTwo = Content.Load<Texture2D>("cardDiamonds2");
            diamondThree = Content.Load<Texture2D>("cardDiamonds3");
            diamondFour = Content.Load<Texture2D>("cardDiamonds4");
            diamondFive = Content.Load<Texture2D>("cardDiamonds5");
            diamondSix = Content.Load<Texture2D>("cardDiamonds6");
            diamondSeven = Content.Load<Texture2D>("cardDiamonds7");
            diamondEight = Content.Load<Texture2D>("cardDiamonds8");
            diamondNine = Content.Load<Texture2D>("cardDiamonds9");
            diamondTen = Content.Load<Texture2D>("cardDiamonds10");
            diamondJack = Content.Load<Texture2D>("cardDiamondsJ");
            diamondQueen = Content.Load<Texture2D>("cardDiamondsQ");
            diamondKing = Content.Load<Texture2D>("cardDiamondsK");

            //Load Heart Card Textures.
            heartAce = Content.Load<Texture2D>("cardHeartsA");
            heartTwo = Content.Load<Texture2D>("cardHearts2");
            heartThree = Content.Load<Texture2D>("cardHearts3");
            heartFour = Content.Load<Texture2D>("cardHearts4");
            heartFive = Content.Load<Texture2D>("cardHearts5");
            heartSix = Content.Load<Texture2D>("cardHearts6");
            heartSeven = Content.Load<Texture2D>("cardHearts7");
            heartEight = Content.Load<Texture2D>("cardHearts8");
            heartNine = Content.Load<Texture2D>("cardHearts9");
            heartTen = Content.Load<Texture2D>("cardHearts10");
            heartJack = Content.Load<Texture2D>("cardHeartsJ");
            heartQueen = Content.Load<Texture2D>("cardHeartsQ");
            heartKing = Content.Load<Texture2D>("cardHeartsK");

            //Load Spade Card Textures
            spadeAce = Content.Load<Texture2D>("cardSpadesA");
            spadeTwo = Content.Load<Texture2D>("cardSpades2");
            spadeThree = Content.Load<Texture2D>("cardSpades3");
            spadeFour = Content.Load<Texture2D>("cardSpades4");
            spadeFive = Content.Load<Texture2D>("cardSpades5");
            spadeSix = Content.Load<Texture2D>("cardSpades6");
            spadeSeven = Content.Load<Texture2D>("cardSpades7");
            spadeEight = Content.Load<Texture2D>("cardSpades8");
            spadeNine = Content.Load<Texture2D>("cardSpades9");
            spadeTen = Content.Load<Texture2D>("cardSpades10");
            spadeJack = Content.Load<Texture2D>("cardSpadesJ");
            spadeQueen = Content.Load<Texture2D>("cardSpadesQ");
            spadeKing = Content.Load<Texture2D>("cardSpadesK");

            //Load Card Back Textures
            compBack = Content.Load<Texture2D>("cardBack_blue2");
            playerBack = Content.Load<Texture2D>("cardBack_red2");


            //Take the textures and find the width and height
            playerWidth = playerBack.Width;
            playerHeight = playerBack.Height;
            compWidth = compBack.Width;
            compHeight = compBack.Height;

                

            // TODO: use this.Content to load your game content here
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
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Yellow);

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
            spriteBatch.Draw(playerBack, playerDeck, Color.White);
            spriteBatch.Draw(compBack, compDeck, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }

        
        
        /*
        public void cardShuffle()
        {

        }
        */
        
            
            
        }
        
    
}
