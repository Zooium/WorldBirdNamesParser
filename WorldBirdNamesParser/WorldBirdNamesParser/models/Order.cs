﻿using System;

namespace WorldBirdNamesParser.models
{
    class Order
    {
        public int ID { get; set; }

        public string Scientific { get; set; }

        public Order(int ID, string Scientific)
        {
            this.ID = ID;
            this.Scientific = Scientific.Replace("'", "\\'");
        }

        public void Output()
        {
            Console.WriteLine($"INSERT INTO specie_orders (`class_id`, `scientific`) SELECT @classIndex, '{this.Scientific}';");
        }
    }
}
