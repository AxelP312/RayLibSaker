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
                        
                        
                        Raylib.ClearBackground(Color.ORANGE);


                        Raylib.EndDrawing();
                    }

                }
            }
        }
    }
}
