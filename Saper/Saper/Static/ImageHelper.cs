using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper.Static
{
    public static class ImageHelper
    {
        public static Bitmap GetImageByID(int id)
        {
            switch (id)
            {
                case 0: // unknow
                    return Properties.Resources.unknown;
                case 1: // empty
                    return Properties.Resources.empty;
                case 2: // mine
                    return Properties.Resources.mine;
                case 3: // flag
                    return Properties.Resources.flag;
                case 4: // _1mine
                    return Properties.Resources._1mine;
                case 5: // _2mine
                    return Properties.Resources._2mine;
                case 6: // _3mine
                    return Properties.Resources._3mine;
                case 7: // _4mine
                    return Properties.Resources._4mine;
                case 8: // _5mine
                    return Properties.Resources._5mine;
                default: return null;
            }
        }
    }
}
