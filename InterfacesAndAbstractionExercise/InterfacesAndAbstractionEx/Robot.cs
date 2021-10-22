﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Robot : IRobot
    {
        public Robot(string model, string id )
        {
            this.Id = id;
            this.Model = model;
        }

        public string Id { get; private set; }

        public string Model { get; private set; }
    }
}