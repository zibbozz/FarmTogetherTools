using System;
using System.Collections.Generic;
using System.Text;

namespace FarmTogetherToolsLib
{
    public static class Helper
    {
        public static int CropProfit(int price, int profit, int level)
        {
            return (int)(price + profit * (1 + ((level - 1) * 0.015 )));
        }
    }
}
