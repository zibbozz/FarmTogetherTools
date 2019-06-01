using System;
using System.Collections.Generic;
using System.Text;

namespace FarmTogetherToolsLib
{
    public class Crop
    {
        private string _name;
        private int _levelReq;
        private int _harvest;
        private int _price;
        private int _profit;
        private int _xp;

        public Crop()
        {
            this._name = "Default";
            this._levelReq = 0;
            this._harvest = 1;
            this._price = 1;
            this._profit = 1;
            this._xp = 1;
        }

        public Crop(string name, int levelReq, int harvestTime, int price, int profit, int xp)
        {
            this.Name = name;
            this.LevelRequirement = levelReq;
            this.HarvestTime = harvestTime;
            this.Price = price;
            this.Profit = profit;
            this.XP = xp;
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value != "")
                    this._name = value;
                else
                    this._name = "Default";
            }
        }

        public int LevelRequirement
        {
            get
            {
                return this._levelReq;
            }
            set
            {
                if (value >= 1 && value <= 200)
                    this._levelReq = value;
                else
                    this._levelReq = 1;
            }
        }

        public int HarvestTime
        {
            get
            {
                return this._harvest;
            }
            set
            {
                if (value >= 1)
                    this._harvest = value;
                else
                    this._harvest = 1;
            }
        }

        public int Price
        {
            get
            {
                return this._price;
            }
            set
            {
                if (value >= 1)
                    this._price = value;
                else
                    this._price = 1;
            }
        }

        public int Profit
        {
            get
            {
                return this._profit;
            }
            set
            {
                if (value >= 1)
                    this._profit = value;
                else
                    this._profit = 1;
            }
        }

        public int LevelProfit(int level)
        {
            return Helper.CropProfit(this.Price, this.Profit, level);
        }

        public int XP
        {
            get
            {
                return this._xp;
            }
            set
            {
                if (value >= 1)
                    this._xp = value;
                else
                    this._xp = 1;
            }
        }

        public double ProfitPerMinute
        {
            get
            {
                return ((double)this.Profit / (double)this.HarvestTime);
            }
        }

        public double XPPerMinute
        {
            get
            {
                return ((double)this.XP / (double)this.HarvestTime);
            }
        }

        public int Harvest
        {
            get
            {
                return this.Price + this.Profit;
            }
        }

        public int HarvestLevel(int level)
        {
            return this.Price + this.LevelProfit(level);
        }
    }
}
