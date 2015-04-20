﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace PathFinder
{
    public sealed class PathGenerator
    {
        public const int OscillationFrequencyDef = 1;
        public const int AmplitudeFluctuationsDef = 10;
        public const int MinIntervalWidthDef = 5;
        public const int ProbabilityDef = 5;

        public int OscillationFrequency
        {
            get
            {
                return _oscillationFrequency == 0 ? OscillationFrequencyDef : _oscillationFrequency;
            }
            set
            {
                _oscillationFrequency = value;
            }
        }

        public int AmplitudeFluctuations
        {
            get
            {
                return _amplitudeFluctuations == 0 ? AmplitudeFluctuationsDef : _amplitudeFluctuations;
            }
            set
            {
                _amplitudeFluctuations = value;
            }
        }

        public int MinIntervalWidth
        {
            get
            {
                return _minIntervalWidth == 0 ? MinIntervalWidthDef : _minIntervalWidth;
            }
            set
            {
                _minIntervalWidth = value;
            }
        }

        public Route GetPath(Map map, Point startPoint, Point endPoint, int probability = ProbabilityDef)
        {
            var route = new Route(startPoint, endPoint);

            if (!ValidateRoute(route, map))
            {
                throw new ArgumentException("Incorect map or route");
            }

            var filterMatrix = new List<Tuple<Point, int>>();

            for (int i = route.StartPoint.X + 1; i < route.EndPoint.X; i++)
            {
                var nextPoint = GetNextPoint(i, route);
                if (ValidatePoint(map, nextPoint))
                {
                    var filterMarker = new Tuple<Point, int>(nextPoint, probability);
                    filterMatrix.Add(filterMarker);
                }
            }

            route.HelpPoints = FilterPath(filterMatrix);

            return route;
        }

        private bool ValidatePoint(Map map, Point point)
        {
            return point.X <= map.Width && point.Y <= map.Height;
        }

        private bool ValidateRoute(Route route, Map map)
        {
            if (!(ValidatePoint(map, route.EndPoint) && ValidatePoint(map, route.StartPoint))) return false;
            return true;
        }

        private Point GetNextPoint(int nextX, Route route)
        {
            var nextPoint = new Point();
            var nextY = GetNextY(route, nextX);

            nextPoint.X = nextX;
            nextPoint.Y = nextY;

            return nextPoint;
        }

        private LinkedList<Point> FilterPath(List<Tuple<Point, int>> filterMatrix)
        {
            var result = new LinkedList<Point>();
            var rand = new Random();
            var index = 0;

            while (index < filterMatrix.Count)
            {
                if (filterMatrix[index].Item2 >= rand.Next(RandValue))
                {
                    result.AddLast(filterMatrix[index].Item1);
                    ++index;
                }
                else
                {
                    index += MinIntervalWidth;
                }
            }

            return result;
        }

        private int GetNextY(Route route, int nextX)
        {
            var angle = GetAngle(nextX, route.XLength);

            var nextY = (route.YLength / route.XLength) * nextX +
                ((route.StartPoint.Y * route.EndPoint.X - route.EndPoint.Y * route.StartPoint.X) / route.XLength) +
                AmplitudeFluctuations * Math.Sin(angle);

            return Convert.ToInt32(Math.Round(nextY));
        }

        private double GetAngle(int nextX, double routeXLength)
        {
            return (2 * Math.PI * nextX * OscillationFrequency) / routeXLength;
        }

        private const int RandValue = 100;
        private int _oscillationFrequency;
        private int _amplitudeFluctuations;
        private int _minIntervalWidth;
    }
}
