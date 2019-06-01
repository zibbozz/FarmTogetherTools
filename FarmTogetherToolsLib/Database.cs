using System;
using System.Collections.Generic;
using System.Text;

namespace FarmTogetherToolsLib
{
    public class Database
    {
        private List<Crop> _crops = new List<Crop>();
        private List<Tree> _trees = new List<Tree>();

        public Database()
        {
            _crops.Add(new Crop("Agave", 10, 600, 400, 250, 49));
            _crops.Add(new Crop("Aloe Vera", 4, 240, 150, 70, 18));
            _crops.Add(new Crop("Artichoke", 40, 420, 7000, 960, 94));
            _crops.Add(new Crop("Asparagus", 11, 60, 840, 60, 14));
            _crops.Add(new Crop("Azoychka Tomato", 14, 300, 950, 350, 37));
            _crops.Add(new Crop("Barley", 31, 1440, 7500, 1500, 160));
            _crops.Add(new Crop("Beans", 7, 30, 200, 40, 7));
            _crops.Add(new Crop("Beefsteak tomato", 10, 360, 1000, 200, 38));
            _crops.Add(new Crop("Beet", 12, 360, 800, 300, 42));
            _crops.Add(new Crop("Black Goji Berry", 19, 25, 2250, 150, 14));
            _crops.Add(new Crop("Blackberry", 5, 240, 220, 60, 20));
            _crops.Add(new Crop("Blue Grape", 2, 360, 50, 50, 16));
            _crops.Add(new Crop("Broccoli", 30, 60, 5000, 250, 30));
            _crops.Add(new Crop("Cabbage", 3, 45, 100, 40, 5));
            _crops.Add(new Crop("Carrot", 1, 20, 35, 25, 2));
            _crops.Add(new Crop("Cauliflower", 7, 45, 260, 50, 9));
            _crops.Add(new Crop("Chard", 60, 900, 12000, 2250, 174));
            _crops.Add(new Crop("Cheddar Cauliflower", 20, 45, 2400, 200, 19));
            _crops.Add(new Crop("Cherokee Purple Tomato", 21, 720, 2500, 1000, 85));
            _crops.Add(new Crop("Chickpea", 14, 180, 2000, 350, 32));
            _crops.Add(new Crop("Chili", 14, 180, 2000, 350, 32));
            _crops.Add(new Crop("Corn", 13, 2880, 2000, 1000, 144));
            _crops.Add(new Crop("Cotton", 4, 720, 100, 90, 35));
            _crops.Add(new Crop("Crookneck Pumpkin", 50, 600, 10000, 1200, 130));
            _crops.Add(new Crop("Eggplant", 2, 1440, 80, 160, 35));
            _crops.Add(new Crop("Garlic", 8, 210, 300, 100, 23));
            _crops.Add(new Crop("Graffiti Cauliflower", 28, 2880, 4500, 2000, 219));
            _crops.Add(new Crop("Green Grape", 7, 600, 250, 150, 41));
            _crops.Add(new Crop("Green Pepper", 12, 240, 900, 200, 32));
            _crops.Add(new Crop("Jicama", 18, 10, 2150, 70, 10));
            _crops.Add(new Crop("Kiwifruit", 11, 1440, 1000, 600, 88));
            _crops.Add(new Crop("Leek", 16, 45, 1250, 130, 15));
            _crops.Add(new Crop("Lettuce", 1, 10, 15, 15, 1));
            _crops.Add(new Crop("Lombardy Cabbage", 9, 1080, 500, 337, 66));
            _crops.Add(new Crop("Melon", 15, 10, 1000, 60, 7));
            _crops.Add(new Crop("Parasol Mushroom", 5, 60, 170, 50, 8));
            _crops.Add(new Crop("Peanut", 1, 30, 40, 25, 3));
            _crops.Add(new Crop("Peas", 5, 360, 180, 100, 30));
            _crops.Add(new Crop("Pineapple", 32, 960, 5500, 1500, 126));
            _crops.Add(new Crop("Potato", 2, 180, 60, 60, 10));
            _crops.Add(new Crop("Pumpkin", 3, 2880, 100, 300, 65));
            _crops.Add(new Crop("Purple Carrot", 26, 20, 4200, 80, 18));
            _crops.Add(new Crop("Raspberry", 22, 120, 3500, 280, 28));
            _crops.Add(new Crop("Red Goji Berry", 15, 90, 1400, 200, 22));
            _crops.Add(new Crop("Red Grape", 13, 600, 1250, 360, 57));
            _crops.Add(new Crop("Red Onion", 9, 300, 440, 120, 31));
            _crops.Add(new Crop("Red Pepper", 11, 720, 750, 400, 56));
            _crops.Add(new Crop("Red Pine Mushroom", 9, 20, 450, 35, 7));
            _crops.Add(new Crop("Red Sorghum", 31, 600, 5250, 800, 96));
            _crops.Add(new Crop("Romanesco", 45, 90, 6000, 400, 45));
            _crops.Add(new Crop("Rye", 17, 1440, 2500, 1250, 110));
            _crops.Add(new Crop("Shallot", 19, 240, 2200, 320, 42));
            _crops.Add(new Crop("Shiitake", 25, 1440, 4000, 1000, 138));
            _crops.Add(new Crop("Spinach", 35, 150, 6000, 400, 52));
            _crops.Add(new Crop("Strawberry", 10, 2160, 800, 700, 107));
            _crops.Add(new Crop("Sunflower", 17, 480, 1500, 700, 58));
            _crops.Add(new Crop("Tomato", 4, 120, 105, 60, 12));
            _crops.Add(new Crop("Turnip", 6, 10, 200, 25, 3));
            _crops.Add(new Crop("Wasabi", 11, 600, 1500, 400, 53));
            _crops.Add(new Crop("Watermelon", 6, 2880, 250, 550, 95));
            _crops.Add(new Crop("Wheat", 8, 1440, 400, 400, 75));
            _crops.Add(new Crop("White Mushroom", 18, 180, 2000, 330, 34));
            _crops.Add(new Crop("White Sorghum", 20, 600, 2350, 900, 75));
            _crops.Add(new Crop("Yellow Onion", 3, 210, 80, 70, 14));
            _crops.Add(new Crop("Yellow Pepper", 4, 90, 125, 55, 10));
            _crops.Add(new Crop("Yellow Zucchini", 12, 15, 850, 70, 8));
            _crops.Add(new Crop("Zucchini", 3, 15, 120, 30, 3));

            _trees.Add(new Tree("Almond Tree", 4, 2, 350, 27, 1, 4));
            _trees.Add(new Tree("Apple Tree", 1, 4, 100, 18, 1, 1));
            _trees.Add(new Tree("Apricot", 10, 2, 1500, 88, 3, 6));
            _trees.Add(new Tree("Avocado", 34, 2, 9500, 239, 19, 12));
            _trees.Add(new Tree("Bamboo", 6, 2, 600, 40, 1, 5));
            _trees.Add(new Tree("Banana Tree", 5, 1, 400, 62, 1, 7));
            _trees.Add(new Tree("Cacao Tree", 17, 2, 4500, 127, 9, 8));
            _trees.Add(new Tree("Cactus", 13, 3, 2500, 77, 5, 6));
            _trees.Add(new Tree("Carob Tree", 11, 2, 1900, 107, 4, 7));
            _trees.Add(new Tree("Cherry Tree", 11, 1, 1750, 143, 3, 10));
            _trees.Add(new Tree("Coconut Tree", 7, 1, 800, 72, 2, 8));
            _trees.Add(new Tree("Coffea", 30, 1, 8500, 398, 17, 17));
            _trees.Add(new Tree("Cypress", 9, 2, 1250, 69, 2, 6));
            _trees.Add(new Tree("Date Palm", 28, 1, 8000, 327, 16, 16));
            _trees.Add(new Tree("Dragon Fruit Cactus", 45, 1, 12500, 382, 25, 21));
            _trees.Add(new Tree("Durian Tree", 42, 1, 12500, 418, 25, 20));
            _trees.Add(new Tree("Fig", 14, 1, 3000, 196, 6, 11));
            _trees.Add(new Tree("Ginkgo Biloba", 16, 3, 5000, 103, 10, 6));
            _trees.Add(new Tree("Hazel Tree", 70, 2, 25000, 332, 50, 17));
            _trees.Add(new Tree("Laurel", 14, 2, 3250, 100, 13, 9));
            _trees.Add(new Tree("Lemon Tree", 2, 1, 200, 39, 1, 4));
            _trees.Add(new Tree("Lime Tree", 19, 1, 5400, 314, 11, 13));
            _trees.Add(new Tree("Lychee", 35, 2, 10000, 247, 20, 12));
            _trees.Add(new Tree("Mango", 21, 4, 6000, 117, 12, 6));
            _trees.Add(new Tree("Mistletoe", 8, 1, 1500, 112, 3, 9));
            _trees.Add(new Tree("Mulberry", 12, 2, 2000, 96, 4, 7));
            _trees.Add(new Tree("Nactarine Tree", 24, 3, 7200, 179, 14, 8));
            _trees.Add(new Tree("Olive Tree", 22, 2, 6500, 210, 13, 9));
            _trees.Add(new Tree("Orange Tree", 8, 1, 1000, 103, 2, 9));
            _trees.Add(new Tree("Papaya", 26, 2, 7700, 212, 15, 10));
            _trees.Add(new Tree("Passion Fruit Vine", 19, 2, 6500, 186, 13, 9));
            _trees.Add(new Tree("Peach Tree", 5, 2, 420, 32, 1, 4));
            _trees.Add(new Tree("Pear Tree", 3, 3, 300, 21, 1, 3));
            _trees.Add(new Tree("Plum Tree", 20, 3, 5800, 143, 12, 7));
            _trees.Add(new Tree("Pomegranate Tree", 18, 1, 12500, 418, 25, 20));
            _trees.Add(new Tree("Quince", 32, 1, 9000, 422, 18, 17));
            _trees.Add(new Tree("Rice", 60, 2, 18000, 244, 36, 16));
            _trees.Add(new Tree("Tamarind", 25, 4, 7500, 398, 15, 7));
            _trees.Add(new Tree("Tangerine Tree", 38, 2, 11000, 223, 22, 13));
            _trees.Add(new Tree("Walnut Tree", 50, 1, 13000, 460, 26, 22));
            _trees.Add(new Tree("Withered Tree", 15, 1, 3500, 204, 7, 12));
            _trees.Add(new Tree("Yuzu Tree", 40, 2, 12000, 296, 24, 13));
        }

        public List<Crop> Crops
        {
            get
            {
                return this._crops;
            }
        }

        public List<Tree> Trees
        {
            get
            {
                return this._trees;
            }
        }

        public Crop Crop(string name)
        {
            Crop temp = new Crop();
            foreach(Crop crop in this.Crops)
            {
                if (crop.Name == name)
                {
                    temp = crop;
                    break;
                }
                else
                    temp = new Crop("Not found", 1, 1, 1, 1, 1);
            }
            return temp;
        }

        public Tree Tree(string name)
        {
            Tree temp = new Tree();
            foreach(Tree tree in this.Trees)
            {
                if (tree.Name == name)
                {
                    temp = tree;
                    break;
                }
                else
                    temp = new Tree("Default", 1, 1, 1, 1, 1, 1);
            }
            return temp;
        }
    }
}
