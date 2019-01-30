﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12抽象类练习
{
    public class Square : Shape
    {
        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private double _width;
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public Square(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.Height + this.Width);
        }
    }
}
