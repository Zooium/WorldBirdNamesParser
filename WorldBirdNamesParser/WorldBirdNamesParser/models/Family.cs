﻿using System;

namespace WorldBirdNamesParser.models
{
    class Family
    {
        public int ID { get; set; }

        public int OrderID { get; set; }

        public string Scientific { get; set; }

        public string English { get; set; }

        public Family(int ID, int OrderID, string Scientific, string English = null)
        {
            this.ID = ID;
            this.OrderID = OrderID;
            this.Scientific = Scientific.Replace("'", "\\'");
            this.English = English.Replace("'", "\\'");
        }

        public void Output()
        {
            Console.WriteLine($"INSERT INTO specie_families (`order_id`, `scientific`, `english_name`) VALUES ((@orderOffset + {this.OrderID}), '{this.Scientific}', '{this.English}');");
        }
    }
}
