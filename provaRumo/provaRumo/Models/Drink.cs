﻿using provaRumo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Drink : IItem
    {
        public int DrinkId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public float Alcohool { get; set; }
        public int TimeToPrepare { get; set; }
        protected virtual ICollection<Drink> Drinks { get; set; }

        public Drink(int DrinkId, string Name, double Price, float Alcohool, int TimeToPrepare)
        {
            this.DrinkId = DrinkId;
            this.Name = Name;
            this.Price = Price;
            this.Alcohool = Alcohool;
            this.TimeToPrepare = TimeToPrepare;
        }

        public Drink()
        {
            
        }
    }
}