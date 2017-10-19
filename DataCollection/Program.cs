using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollection
{
    public class DataProcess
    {
        public static bool GenImage(string folderPath, string filename)
        {
            try
            {
                var files = new DirectoryInfo(folderPath).GetFiles().OrderBy(f => f.LastWriteTime).Select(f => f.FullName).ToList();
                Image<Bgr, byte> imageShape = new Image<Bgr, byte>(files.First());
                var data = imageShape.Data;
                var xShape = data.GetLength(0);
                var yShape = data.GetLength(1);
                byte[,,] newImage = new byte[xShape, yShape, data.GetLength(2)];
                var curImage = imageShape.Data;
                int length = files.Count - 1;
                for (int i = 0; i < length; i++)
                {
                    var nextImage = new Image<Bgr, byte>(files[i + 1]).Data;
                    //两张图片做差
                    //找哪些地方是后一张curImage有但preImage没有的，即curImage !=0 但 preImage = 0
                    var color = RGBAllocator.GetNewRGB();
                    for (int index_x = 0; index_x < xShape; index_x++)
                    {
                        for (int index_y = 0; index_y < yShape; index_y++)
                        {
                            //如果这个地方是Special的,就渲染到新的图像中去
                            if (IsSpecial(nextImage, curImage, index_x, index_y))
                            {
                                newImage[index_x, index_y, 2] = color.B;
                                newImage[index_x, index_y, 1] = color.R;
                                newImage[index_x, index_y, 0] = color.G;
                            }
                        }
                    }
                    curImage = nextImage;
                }
                Image<Bgr, byte> imageStore = new Image<Bgr, byte>(newImage);
                imageStore.Save(filename);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsSpecial(byte[,,] curImage,byte[,,] preImage,int index_x,int index_y)
        {
            for(int i  = 0; i< 3; i++)
            {
                if(curImage[index_x, index_y, i] != preImage[index_x, index_y, i])
                {
                    return true;
                }
            }
            return false;
        }
    }

    static class RGBAllocator
    {
        public static int count = 0;

        public static Color GetNewRGB()
        {
            count++;
            return Color.FromArgb(count);
        }
    }

    static class RandomColorGen
    {
        public static Random randonGen = new Random();
        public static Color GetRandomColor()
        {
            Color randomColor =
                Color.FromArgb(
                (byte)randonGen.Next(255),
                (byte)randonGen.Next(255),
                (byte)randonGen.Next(255),
                (byte)randonGen.Next(255));
            return randomColor;
        }
    }
}
