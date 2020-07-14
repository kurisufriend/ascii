using System;
using System.Drawing;

namespace kot
{
    class Program
    {
        static void Main(string[] args)
        {
            string final = "";
            string[] scale = {".",",",":",";","+","*","?","%","S","#","@"};
            //Array.Reverse(scale);
            var f = new Bitmap("./kurisu.jpg");
            for (int i = 0; i < f.Height; i += 30)
            {
                for (int z = 0; z < f.Width; z += 30)
                {
                    float bright = f.GetPixel(z, i).GetBrightness();
                    string temp = "";
                    for (float x = 1; x > 0; x -= .1f)
                    {
                        int shit = (int)(x * 10);
                        if (bright < x)
                        {
                            temp = scale[shit];
                        }
                    }
                    final += temp;
                }
            final += "\n";
            }
            Console.Write(final);
        }
    }
}
