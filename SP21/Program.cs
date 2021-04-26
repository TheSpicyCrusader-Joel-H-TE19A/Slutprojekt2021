using System;
using Raylib_cs;
using System.Numerics;

namespace SP2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1900, 900, "Möst Epik Battles of Hisotry");

            Texture2D bbbRight = Raylib.LoadTexture("Bling-Bling_Boy_Right.png");
            Texture2D bbbLeft = Raylib.LoadTexture("Bling-Bling_Boy_Left.png");
            Texture2D bbbDown = Raylib.LoadTexture("Bling-Bling_Boy_Down.png");
            Texture2D bbbUp = Raylib.LoadTexture("Bling-Bling_Boy_Up.png");

            Texture2D slayerRight = Raylib.LoadTexture("Doomslayer_Right.png");
            Texture2D slayerLeft = Raylib.LoadTexture("Doomslayer_Left.png");
            Texture2D slayerDown = Raylib.LoadTexture("Doomslayer_Down.png");
            Texture2D slayerUp = Raylib.LoadTexture("Doomslayer_Up.png");


            Texture2D trollfaceRight = Raylib.LoadTexture("Trollface_Right.png");
            Texture2D trollfaceLeft = Raylib.LoadTexture("Trollface_Left.png");
            // Random generator = new Random();

            float width = 1900;
            float height = 900;
            float speed1 = 1f;
            float speed2 = 1f;
            int ballVelocityX = 1;
            int ballVelocityY = 1;
            bool playerRight1 = false;
            bool playerLeft1 = true;
            bool playerUp1 = false;
            bool playerDown1 = false;
            bool playerRight2 = true;
            bool playerLeft2 = false;
            bool playerUp2 = false;
            bool playerDown2 = false;
            bool trollRight = true;
            bool trollLeft = false;
            float player1X = 150;
            float player1Y = 687;
            float player2X = 1750;
            float player2Y = 687;
            int ballx = (int)Math.Round(width / 2);
            int bally = (int)Math.Round(height / 2);
            float ballspeedx = 3;
            float ballspeedy = 3;
            // float BSMultiplier1 = 0.95f;
            // float BSMultiplier2 = 1.05f;
            int player1Points = 0;
            int player2Points = 0;
            string player1 = "Alive";
            string player2 = "Alive";
            string scene = "Menu";

            //TrollFace speed/movement changers 
            Rectangle ability1 = new Rectangle(200, 450, 25, 25);
            Rectangle ability2 = new Rectangle(width / 2, 800, 25, 25);
            Rectangle ability3 = new Rectangle(1700, 450, 25, 25);
            Rectangle ability4 = new Rectangle(width / 2, 100, 25, 25);
            //Player speed/movement changers 
            Rectangle ability5 = new Rectangle(width - 25, 0, 25, 25);
            Rectangle ability6 = new Rectangle(0, 0, 25, 25);
            Rectangle ability7 = new Rectangle(width - 25, height - 25, 25, 25);
            Rectangle ability8 = new Rectangle(0, height - 25, 25, 25);
            Rectangle troll = new Rectangle(ballx, bally, 60, 112);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                if (scene == "Menu")
                {
                    menuText();

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        scene = "Arena";
                    }

                }
                else if (scene == "Arena")
                {
                    Raylib.ClearBackground(Color.LIGHTGRAY);
                    if (player1X == 1830 && player2X == 90 && player1Y == 687 && player2Y == 687)
                    {
                        Raylib.DrawText("BEGIN!", 775, 350, 100, Color.BLACK);
                    }

                    // Raylib.DrawTextureEx(bbbLeft, new Vector2(player1X, player1Y), 0f, 0.25f, Color.WHITE);
                    // Raylib.DrawTextureEx(slayerRight, new Vector2(player2X, player2Y), 0f, 0.25f, Color.WHITE);
                    // Raylib.DrawTextureEx(trollRight, new Vector2(troll.x, troll.y), 0F, 0.25f, Color.WHITE);

                    //BBB sprite movements

                    Raylib.DrawText($"Player1: {player1Points}", 200, 0, 50, Color.BLACK);
                    Raylib.DrawText($"Player2: {player2Points}", 1475, 0, 50, Color.BLACK);
                    Raylib.DrawText($"P1 Speed:{speed1}  P2 Speed:{speed2}", 750, 0, 25, Color.BLACK);

                    if (playerRight1 == true && playerLeft1 == false && playerDown1 == false && playerUp1 == false)
                    {
                        Raylib.DrawTextureEx(bbbRight, new Vector2(player1X, player1Y), 0f, 0.25f, Color.WHITE);
                    }
                    if (playerRight1 == false && playerLeft1 == true && playerDown1 == false && playerUp1 == false)
                    {
                        Raylib.DrawTextureEx(bbbLeft, new Vector2(player1X, player1Y), 0f, 0.25f, Color.WHITE);
                    }
                    if (playerRight1 == false && playerLeft1 == false && playerDown1 == true && playerUp1 == false)
                    {
                        Raylib.DrawTextureEx(bbbDown, new Vector2(player1X, player1Y), 0f, 0.25f, Color.WHITE);
                    }
                    if (playerRight1 == false && playerLeft1 == false && playerDown1 == false && playerUp1 == true)
                    {
                        Raylib.DrawTextureEx(bbbUp, new Vector2(player1X, player1Y), 0f, 0.25f, Color.WHITE);
                    }
                    //Doomslayer sprite movements

                    if (playerRight2 == true & playerLeft2 == false && playerDown2 == false && playerUp2 == false)
                    {
                        Raylib.DrawTextureEx(slayerRight, new Vector2(player2X, player2Y), 0f, 0.25f, Color.WHITE);
                    }
                    if (playerRight2 == false && playerLeft2 == true && playerDown2 == false && playerUp2 == false)
                    {
                        Raylib.DrawTextureEx(slayerLeft, new Vector2(player2X, player2Y), 0f, 0.25f, Color.WHITE);
                    }
                    if (playerRight2 == false && playerLeft2 == false && playerDown2 == true && playerUp2 == false)
                    {
                        Raylib.DrawTextureEx(slayerDown, new Vector2(player2X, player2Y), 0f, 0.25f, Color.WHITE);
                    }
                    if (playerRight2 == false && playerLeft2 == false && playerDown2 == false && playerUp2 == true)
                    {
                        Raylib.DrawTextureEx(slayerUp, new Vector2(player2X, player2Y), 0f, 0.25f, Color.WHITE);
                    }

                    //Troll sprite movements
                    if (trollRight == true && trollLeft == false)
                    {
                        Raylib.DrawTextureEx(trollfaceRight, new Vector2(troll.x, troll.y), 0F, 0.25f, Color.WHITE);
                    }
                    if (trollRight == false && trollLeft == true)
                    {
                        Raylib.DrawTextureEx(trollfaceLeft, new Vector2(troll.x, troll.y), 0F, 0.25f, Color.WHITE);
                    }

                    float xMovement = 0;
                    float yMovement = 0;

                    //Player 1 movements
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && player1X < width - 90)
                    {
                        xMovement = speed1;
                        playerRight1 = true;
                        playerLeft1 = false;
                        playerUp1 = false;
                        playerDown1 = false;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && player1X > 0)
                    {
                        xMovement = -speed1;
                        playerRight1 = false;
                        playerLeft1 = true;
                        playerUp1 = false;
                        playerDown1 = false;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && player1Y > 0)
                    {
                        yMovement = -speed1;
                        playerRight1 = false;
                        playerLeft1 = false;
                        playerUp1 = true;
                        playerDown1 = false;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && player1Y < height - 112.5)
                    {
                        yMovement = speed1;
                        playerRight1 = false;
                        playerLeft1 = false;
                        playerUp1 = false;
                        playerDown1 = true;
                    }

                    player1X += xMovement;
                    player1Y += yMovement;
                    // player1hurtbox.x += xMovement;
                    // player1hurtbox.y += yMovement;
                    //Player 2 movements
                    float xMovement2 = 0;
                    float yMovement2 = 0;


                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) && player2X < width - 90)
                    {
                        xMovement2 = speed2;
                        playerRight2 = true;
                        playerLeft2 = false;
                        playerUp2 = false;
                        playerDown2 = false;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) && player2X > 0)
                    {
                        xMovement2 = -speed2;
                        playerRight2 = false;
                        playerLeft2 = true;
                        playerUp2 = false;
                        playerDown2 = false;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) && player2Y > 0)
                    {
                        yMovement2 = -speed2;
                        playerRight2 = false;
                        playerLeft2 = false;
                        playerUp2 = true;
                        playerDown2 = false;
                    }

                    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) && player2Y < height - 112.5)
                    {
                        yMovement2 = speed2;
                        playerRight2 = false;
                        playerLeft2 = false;
                        playerUp2 = false;
                        playerDown2 = true;
                    }

                    player2X += xMovement2;
                    player2Y += yMovement2;

                    //Troll movements
                    troll.x += ballVelocityX * ballspeedx;
                    troll.y += ballVelocityY * ballspeedy;

                    if (troll.x + 45 > width)
                    {
                        ballVelocityX = ballVelocityX * -1;
                        trollLeft = true;
                        trollRight = false;
                    }
                    else if (troll.x + 45 < 0)
                    {
                        ballVelocityX = ballVelocityX * -1;
                        trollLeft = false;
                        trollRight = true;
                    }
                    if (troll.y + 45 > height)
                    {
                        ballVelocityY = ballVelocityY * -1;
                    }
                    if (troll.y + 45 < 0)
                    {
                        ballVelocityY = ballVelocityY * -1;
                    }



                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "Menu";
                    }
                    Raylib.DrawRectangleRec(ability1, Color.ORANGE);
                    Raylib.DrawRectangleRec(ability2, Color.PINK);
                    Raylib.DrawRectangleRec(ability3, Color.BLUE);
                    Raylib.DrawRectangleRec(ability4, Color.GREEN);
                    Raylib.DrawRectangleRec(ability5, Color.RED);
                    Raylib.DrawRectangleRec(ability6, Color.YELLOW);
                    Raylib.DrawRectangleRec(ability7, Color.PURPLE);
                    Raylib.DrawRectangleRec(ability8, Color.SKYBLUE);

                    //Kollision

                    //ability1
                    if (Raylib.CheckCollisionRecs(ability1, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        ballspeedx = 1;
                        // ballspeedx = ballspeedy * BSMultiplier1;
                        // if (ballspeedx < 1)
                        // {
                        //     ballspeedx = 1;
                        // }
                    }

                    if (Raylib.CheckCollisionRecs(ability1, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        ballspeedx = 1;
                        // ballspeedx = ballspeedy * BSMultiplier1;
                        // if (ballspeedx < 1)
                        // {
                        //     ballspeedx = 1;
                        // }
                    }

                    //ability2
                    if (Raylib.CheckCollisionRecs(ability2, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        ballspeedy = 1;
                        // ballspeedy = ballspeedy * BSMultiplier1;
                        // if (ballspeedy < 1)
                        // {
                        //     ballspeedy = 1;
                        // }
                    }

                    if (Raylib.CheckCollisionRecs(ability2, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        ballspeedy = 1;
                        // ballspeedy = ballspeedy * BSMultiplier1;
                        // if (ballspeedy < 1)
                        // {
                        //     ballspeedy = 1;
                        // }
                    }

                    //ability3
                    if (Raylib.CheckCollisionRecs(ability3, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        ballspeedx = 3;
                        // ballspeedx = ballspeedx * BSMultiplier2;
                        // if (ballspeedx < 3)
                        // {
                        //     ballspeedx = 3;
                        // }
                    }

                    if (Raylib.CheckCollisionRecs(ability3, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        ballspeedx = 3;
                        // ballspeedx = ballspeedx * BSMultiplier2;
                        // if (ballspeedx > 3)
                        // {
                        //     ballspeedx = 3;
                        // }
                    }

                    //ability4
                    if (Raylib.CheckCollisionRecs(ability4, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        ballspeedy = 3;
                        // ballspeedy = ballspeedy * BSMultiplier2;
                        // if (ballspeedy > 3)
                        // {
                        //     ballspeedy = 3;
                        // }
                    }

                    if (Raylib.CheckCollisionRecs(ability4, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        ballspeedy = 3;
                        // ballspeedy = ballspeedy * BSMultiplier2;
                        // if (ballspeedy > 3)
                        // {
                        //     ballspeedy = 3;
                        // }
                    }

                    //ability5
                    if (Raylib.CheckCollisionRecs(ability5, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        speed2 = 1.5f;
                    }

                    if (Raylib.CheckCollisionRecs(ability5, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        speed2 = 1.5f;
                    }

                    //ability6
                    if (Raylib.CheckCollisionRecs(ability6, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        speed1 = 1.5f;
                    }
                    if (Raylib.CheckCollisionRecs(ability6, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        speed1 = 1.5f;
                    }

                    //ability7
                    if (Raylib.CheckCollisionRecs(ability7, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        speed1 = 0.5f;
                    }
                    if (Raylib.CheckCollisionRecs(ability7, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        speed1 = 0.5f;
                    }

                    //ability8
                    if (Raylib.CheckCollisionRecs(ability8, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        speed2 = 0.5f;
                    }
                    if (Raylib.CheckCollisionRecs(ability8, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        speed2 = 0.5f;
                    }
                    //if death

                    if (Raylib.CheckCollisionRecs(troll, new Rectangle(player1X, player1Y, 75, 112)))
                    {
                        player1 = "Dead";
                        player2Points = player2Points + 1;
                    }

                    if (Raylib.CheckCollisionRecs(troll, new Rectangle(player2X, player2Y, 75, 112)))
                    {
                        player2 = "Dead";
                        player1Points = player1Points + 1;
                    }

                    if (player1 == "Dead" || player2 == "Dead")
                    {
                        scene = "Game Over";
                    }
                }
                else if (scene == "Game Over")
                {
                    Raylib.ClearBackground(Color.YELLOW);
                    Raylib.DrawText($"Player1: {player1Points}", 1475, 0, 50, Color.BLACK);
                    Raylib.DrawText($"Player2: {player2Points}", 200, 0, 50, Color.BLACK);
                    if (player1 == "Dead")
                    {
                        p1Death();
                    }
                    if (player2 == "Dead")
                    {
                        p2Death();
                    }

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "Menu";
                    }

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = "Arena";
                        player1 = "Alive";
                        player2 = "Alive";
                        troll.x = (int)Math.Round(width / 2);
                        troll.y = (int)Math.Round(height / 2);
                        player1X = 150;
                        player1Y = 687;
                        player2X = 1750;
                        player2Y = 687;
                        ballspeedx = 3;
                        ballspeedy = 3;
                        ballVelocityX = 1;
                        ballVelocityY = 1;
                        speed1 = 1f;
                        speed2 = 1f;
                    }

                }
                Raylib.EndDrawing();


            }
        }

        static void menuText()
        {
            Raylib.ClearBackground(Color.DARKBLUE);
            Raylib.DrawText("Survive Le Trollage", 250, 100, 125, Color.WHITE);
            Raylib.DrawText("Press ENTER to begin", 600, 300, 50, Color.BLACK);
            Raylib.DrawText("Player 1", 100, 600, 80, Color.WHITE);
            Raylib.DrawText("Player 2", 1400, 600, 80, Color.WHITE);
        }

        static void p1Death()
        {
            Raylib.DrawText("Player 2 aka Doomslayer survived the longest", 550, 100, 50, Color.BLACK);
            Raylib.DrawText("Press TAB to return to menu", 700, 225, 25, Color.BLACK);
            Raylib.DrawText("Press SPACE to play again", 700, 325, 25, Color.BLACK);
            Raylib.DrawText("+1", 300, 50, 50, Color.BLACK);
        }

        static void p2Death()
        {
            Raylib.DrawText("Player 1 aka Bling Bling Boy survived the longest", 550, 100, 50, Color.BLACK);
            Raylib.DrawText("Press TAB to return to menu", 700, 225, 25, Color.BLACK);
            Raylib.DrawText("Press SPACE to play again", 700, 325, 25, Color.BLACK);
            Raylib.DrawText("+1", 1575, 50, 50, Color.BLACK);
        }
    }
}
