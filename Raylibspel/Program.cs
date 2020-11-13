using System.Reflection.PortableExecutable;
using System.Threading.Tasks.Dataflow;
using System;
using Raylib_cs;

namespace Raylibspel
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Spelrutan");
            Raylib.SetTargetFPS(60); 

            bool gameState = true;
            int scene = 0;

            Player spelare = new Player(250, 250, KeyboardKey.KEY_W, KeyboardKey.KEY_S, KeyboardKey.KEY_A, KeyboardKey.KEY_D);

            while (!Raylib.WindowShouldClose())
            {
                while (gameState == true)
                {
                    if (scene == 0)
                    {
                        Raylib.BeginDrawing();
                        Raylib.ClearBackground(Color.WHITE);
                        Raylib.DrawText("Press Enter", 100 , 250, 96, Color.BLACK);
                        if(Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                        {
                            scene = 1;
                        }
                        Raylib.EndDrawing();
                        
                    }
                    else if (scene == 1)
                    {
                        Raylib.BeginDrawing();
                        spelare.Update();
                        Raylib.ClearBackground(Color.ORANGE);
                        spelare.Draw();
                        Raylib.EndDrawing();
                    }

                }
            }
        }
    }
}
