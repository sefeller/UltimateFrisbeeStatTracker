﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFrisbeeApplication.Models
{
    public class Team
    {
        private string _name;
        public List<Season> seasons; 

        public Team(string name)
        {
            this._name = name;
            this.seasons = new List<Season>(); 
            this.seasons.Add(new Season()); 
        }

        //Name is used for View Binding, _name is the private variable 
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                
            }
        }
    }
}
