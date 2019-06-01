using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmTogetherToolsLib
{
    public class Tree
    {
        private string _name;
        private int _levelReq;
        private int _harvest;
        private int _price;
        private int _profit;
        private int _xp;
        private int _xpSeason;

        public Tree()
        {
            this._name = "Default";
            this._levelReq = 1;
            this._harvest = 1;
            this._price = 1;
            this._profit = 1;
            this._xp = 1;
            this._xpSeason = 1;
        }

        public Tree(string name, int levelRequirement, int harvestCount, int price, int profitSeason, int xpBuy, int xpSeason)
        {
            this.Name = name;
            this.LevelRequirement = levelRequirement;
            this.HarvestCount = harvestCount;
            this.Price = price;
            this.ProfitSeason = profitSeason;
            this.XPBuy = xpBuy;
            this.XPSeason = xpSeason;
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
                if (value >= 1)
                    this._levelReq = value;
                else
                    this._levelReq = 1;
            }
        }

        public int HarvestCount
        {
            get
            {
                return this._harvest;
            }
            set
            {
                if (value >= 1 && value <= 4)
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

        public int ProfitSeason
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

        public int XPBuy
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

        public int XPSeason
        {
            get
            {
                return this._xpSeason;
            }
            set
            {
                if (value >= 1)
                    this._xpSeason = value;
                else
                    this._xpSeason = 1;
            }
        }

        public int ProfitYear
        {
            get
            {
                return this.ProfitSeason * this.HarvestCount;
            }
        }    

        public int XPYear
        {
            get
            {
                return this.XPSeason * this.HarvestCount;
            }
        }
    }
}
