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
        static string s1 = "s1";
        static string s2 = "s2";
        static string s3 = "s3";
        static string s4 = "s4";
        static string s5 = "s5";
        static string s6 = "s6";
        static string s7 = "s7";
        static string s8 = "s8";
        static string s9 = "s9";
        static string s10 = "s10";
        static string sJack = "s11";
        static string sQueen = "s12";
        static string sKing = "s13";

        //Hearts
        static string h1 = "h1"; static string h2 = "h2"; static string h3 = "h3"; static string h4 = "h4";
        static string h5 = "h5"; static string h6 = "h6"; static string h7 = "h7"; static string h8 = "h8";
        static string h9 = "h9"; static string h10 = "h10"; static string hJack = "h11"; static string hQueen = "h12"; static string hKing = "k13";

        //diamonds
        static string d1 = "d1"; static string d2 = "d2"; static string d3 = "d3"; static string d4 = "d4";
        static string d5 = "d5"; static string d6 = "d6"; static string d7 = "d7"; static string d8 = "d8";
        static string d9 = "d9"; static string d10 = "d10"; static string dJack = "d11"; static string dQueen = "d12"; static string dKing = "d13";

        //Now clubs
        static string c1 = "c1"; static string c2 = "c2"; static string c3 = "c3"; static string c4 = "c4";
        static string c5 = "c5"; static string c6 = "c6"; static string c7 = "c7"; static string c8 = "c8";
        static string c9 = "c9"; static string c10 = "c10"; static string cJack = "c11"; static string cQueen = "c12"; static string cKing = "c13";

        List<string> deck = new List<string> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, cJack, cQueen, cKing, d1, d2, d3, d4,
        d5, d6, d7, d8, d9, d10, dJack, dQueen, dKing, h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, hJack, hQueen, hKing, s1,
        s2, s3, s4, s5,s6,s7, s8, s9, s10, sJack, sQueen, sKing};
        

        //Split deck into 2
        

        
        
        
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
            cardShuffle();

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

        
        
        
        public void cardShuffle()
        {
            var shuffle = new Random();
            var newDeck = deck.OrderBy(item => shuffle.Next());

        }
        
        
            
            
        }
        
    
}
