using Raylib_cs;
namespace Cirkit
{
    internal class App
    {
        static void Main()
        {
            Raylib.InitWindow(1280, 720, "Cirkit");
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib.GetColor(0x000000ff));
                Raylib.DrawText("Hello, world!", 20, 20, 20, Raylib.GetColor(0xffffffff));
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
