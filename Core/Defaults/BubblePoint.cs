﻿//The MIT License(MIT)

//copyright(c) 2016 Alberto Rodriguez

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System;

namespace LiveCharts.Defaults
{
    /// <summary>
    /// An already configured weighted chart point, this class notifies the chart to update every time a property changes
    /// </summary>
    public class BubblePoint : IObservableChartPoint
    {
        private double _x;
        private double _y;
        private double _weight;

        /// <summary>
        /// Creates a new instance of BubblePoint class
        /// </summary>
        public BubblePoint()
        {
            
        }

        /// <summary>
        /// Create a new instance of BubblePoint class, giving x and y coordinates
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public BubblePoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Creates a new instance of BubblePoint class, giving x, y and weight
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="weight"></param>
        public BubblePoint(double x, double y, double weight)
        {
            X = x;
            Y = y;
            Weight = weight;
        }

        /// <summary>
        /// X coordinate in the chart
        /// </summary>
        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPointChanged();
            }
        }

        /// <summary>
        /// Y coordinate in the chart
        /// </summary>
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPointChanged();
            }
        }

        /// <summary>
        /// Point's weight
        /// </summary>
        public double Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPointChanged();
            }
        }

        /// <summary>
        /// Point changed event
        /// </summary>
        public event Action PointChanged;

        /// <summary>
        /// On point property changed method
        /// </summary>
        protected virtual void OnPointChanged()
        {
            if (PointChanged != null) PointChanged.Invoke();
        }
    }

    /// <summary>
    /// An already configured weighted chart point, this class notifies the chart to update every time a property changes
    /// </summary>
    public class HeatPoint : BubblePoint
    {
        /// <summary>
        /// Initializes a new instance of HeatPoint class
        /// </summary>
        public HeatPoint()
        {

        }
        
        /// <summary>
        /// _initializes a new instance of HeatPoint class, giving x, y and weight
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="weight"></param>
        public HeatPoint(double x, double y, double weight)
        {
            X = x;
            Y = y;
            Weight = weight;
        }
    }
}
