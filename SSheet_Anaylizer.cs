using System.Drawing;

namespace VCELL_Emulator
{
         //new Image().Jpeg;
    /// <summary>
    /// this class is for spriting 
    /// </summary>
    internal class SSheet_Anaylizer
    {
        int width, height; // this shit goes in a fileoutput
        // and this calculates bounds

        int x, y, xoff, yoff;
        const string e = "image/input.bmp";
        private const string Filename = "input.bmp";
        System.Drawing.Image Img =
#pragma warning disable CA1416 // Validate platform compatibility
            System.Drawing.Image.FromFile(e);
#pragma warning restore CA1416 // Validate platform compatibility
        int a, r, g, b;
        public SSheet_Anaylizer(int x, int y, int xoff,
            int yoff, int a, int r, int g, int b)
        {
            // dont use a background
            // analyze the integers from the file.
            // color // restrict palette
            // then draw all pixels
            Draw();
        }
        public System.Drawing.Image Draw()
        {
#pragma warning disable CA1416 // Validate platform compatibility
            Bitmap bitMap = new (width, height);
#pragma warning restore CA1416 // Validate platform compatibility

            for (int y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
#pragma warning disable CA1416 // Validate platform compatibility
                    bitMap.SetPixel(x + xoff,
                    y + yoff, Color.FromArgb(a, r, g, b));
#pragma warning restore CA1416 // Validate platform compatibility
                }
#pragma warning disable CA1416 // Validate platform compatibility
                bitMap.Save(Filename);
#pragma warning restore CA1416 // Validate platform compatibility
            }
            return Img;
        }

        public static System.Drawing.Image PaneDiv
            (System.Drawing.Image diV)
        {
            //diV.
            // put shit here
            return diV;
        }
    }
}
