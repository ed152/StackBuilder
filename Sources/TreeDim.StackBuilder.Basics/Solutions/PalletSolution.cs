﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;

using Sharp3D.Math.Core;
#endregion

namespace treeDiM.StackBuilder.Basics
{
    #region Layer classes (box layer + interlayer)
    /// <summary>
    /// Layer interface to be implemented by either BoxLayer or InterlayerPos
    /// </summary>
    public interface ILayer
    {
        double ZLow { get; }
        int BoxCount { get; }
        int CylinderCount { get; }
        int InterlayerCount { get; }
        BBox3D BoundingBox(Packable packable);
    }

    public class InterlayerPos : ILayer
    {
        #region Constructor
        public InterlayerPos(double zLow, int typeId)
        {
            ZLow = zLow;
            TypeId = typeId;
        }
        #endregion

        #region Interlayer specific properties
        public int TypeId { get; } = 0;
        #endregion

        #region ILayer implementation
        public double ZLow { get; } = 0.0;
        public int BoxCount => 0;
        public int InterlayerCount => 1;
        public int CylinderCount => 0;
        public BBox3D BoundingBox(Packable packable)
        {
            BBox3D bbox = new BBox3D();
            Vector3D dimensions = packable.OuterDimensions;
            Vector3D[] pts = new Vector3D[8];
            pts[0] = new Vector3D(0.0, 0.0, ZLow);
            pts[1] = pts[0] + dimensions.X * Vector3D.XAxis;
            pts[2] = pts[0] + dimensions.Y * Vector3D.YAxis;
            pts[3] = pts[0] + dimensions.X * Vector3D.XAxis + dimensions.Y * Vector3D.YAxis;
            pts[4] = pts[0] + dimensions.Z * Vector3D.ZAxis;
            pts[5] = pts[1] + dimensions.Z * Vector3D.ZAxis;
            pts[6] = pts[2] + dimensions.Z * Vector3D.ZAxis;
            pts[7] = pts[3] + dimensions.Z * Vector3D.ZAxis;
            foreach (Vector3D pt in pts)
                bbox.Extend(pt);
            return bbox;
        }
        #endregion
    }

    /// <summary>
    /// A layer of box
    /// </summary>
    public class Layer3DBox : List<BoxPosition>, ILayer
    {
        #region Enums
        public enum SortType { XY, DIST_BOXCENTER, DIST_MAXCORNER, TOTAL };
        #endregion

        #region Constructor
        public Layer3DBox(double zLow, int layerIndex)
        {
            ZLow = zLow;
            LayerIndex = layerIndex;
        }
        #endregion

        #region Public properties
        public double ZLow { get; } = 0.0;
        public int BoxCount => Count;
        public int InterlayerCount => 0;
        public int CylinderCount => 0;
        public int LayerIndex { get; }
        public double MaximumSpace { get; set; } = 0.0;
        #endregion

        #region Public methods
        /// <summary>
        /// adds a case position
        /// </summary>
        /// <param name="vPosition">Box 'origin' position (origin: lower left corner)</param>
        /// <param name="dirLength">Length axis direction</param>
        /// <param name="dirWidth">Width axis direction</param>
        public void AddPosition(Vector3D vPosition, HalfAxis.HAxis dirLength, HalfAxis.HAxis dirWidth)
        {
            Add(new BoxPosition(vPosition, dirLength, dirWidth));
        }
        public BBox3D BoundingBox(Packable packable)
        {
            BBox3D bbox = new BBox3D();
            if (packable is PackableBrick packableBrick)
            {
                Vector3D dimensions = packableBrick.OuterDimensions;
                foreach (BoxPosition bpos in this)
                    bbox.Extend(bpos.BBox(dimensions));
            }
            return bbox;
        }
        public double Thickness(BProperties bProperties)
        {
            if (Count == 0) return 0.0;
            BoxPosition bPos = this[0];
            Vector3D diagonale = bProperties.Length * HalfAxis.ToVector3D(bPos.DirectionLength)
                                + bProperties.Width * HalfAxis.ToVector3D(bPos.DirectionWidth)
                                + bProperties.Height * Vector3D.CrossProduct(HalfAxis.ToVector3D(bPos.DirectionLength), HalfAxis.ToVector3D(bPos.DirectionWidth));
            return Math.Abs(diagonale.Z);
        }
        public void Sort(Packable packable, SortType sortType)
        {
            Vector3D dimensions = packable.OuterDimensions;
            Vector3D minPoint = BoundingBox(packable).PtMin;
            switch (sortType)
            {
                case SortType.XY: Sort(new ComparerBoxPositionXY(dimensions)); break;
                case SortType.DIST_BOXCENTER: Sort(new ComparerBoxPositionDist(dimensions, minPoint)); break;
                case SortType.DIST_MAXCORNER: Sort(new ComparerBoxPositionDistMaxCorner(dimensions, minPoint)); break;
                default: break;
            }
        }
        #endregion
    }

    public class Layer3DBoxIndexed : List<BoxPositionIndexed>, ILayer
    {
        #region Constructor
        public Layer3DBoxIndexed(double zLow, int layerIndex)
        {
            ZLow = zLow;
            LayerIndex = layerIndex;
        }
        #endregion

        #region ILayer implementation
        public double ZLow { get; } = 0.0;
        public int BoxCount => Count;
        public int CylinderCount => 0;
        public int InterlayerCount => 0;
        public BBox3D BoundingBox(Packable packable)
        {
            BBox3D bbox = new BBox3D();
            if (packable is PackableBrick packableBrick)
            {
                Vector3D dimensions = packableBrick.OuterDimensions;
                foreach (var bpos in this)
                    bbox.Extend(bpos.BPos.BBox(dimensions));
            }
            return bbox;
        }
        #endregion
        #region Public methods
        /// <summary>
        /// adds a case position
        /// </summary>
        /// <param name="vPosition">Box 'origin' position (origin: lower left corner)</param>
        /// <param name="dirLength">Length axis direction</param>
        /// <param name="dirWidth">Width axis direction</param>
        public void AddPosition(Vector3D vPosition, HalfAxis.HAxis dirLength, HalfAxis.HAxis dirWidth, int index)
        {
            Add(new BoxPositionIndexed(vPosition, dirLength, dirWidth, index));
        }
        public double Thickness(BProperties bProperties)
        {
            if (Count == 0) return 0.0;
            BoxPosition bPos = this[0].BPos;
            Vector3D diagonale = bProperties.Length * HalfAxis.ToVector3D(bPos.DirectionLength)
                                + bProperties.Width * HalfAxis.ToVector3D(bPos.DirectionWidth)
                                + bProperties.Height * Vector3D.CrossProduct(HalfAxis.ToVector3D(bPos.DirectionLength), HalfAxis.ToVector3D(bPos.DirectionWidth));
            return Math.Abs(diagonale.Z);
        }
        public Layer3DBoxIndexed Sort(Packable packable)
        {
            Vector3D dimensions = packable.OuterDimensions;
            Vector3D minPoint = BoundingBox(packable).PtMin;
            Dictionary<int, double> dictIndexDist = new Dictionary<int, double>();

            foreach (var boxPos in this)
            {
                int index = boxPos.Index;
                double maxDist = boxPos.BPos.MaxDistance(dimensions, minPoint);

                if (dictIndexDist.ContainsKey(index))
                {
                    dictIndexDist[index] = Math.Max(dictIndexDist[index], maxDist);
                }
                else
                    dictIndexDist.Add(index, maxDist);
            }
            // sort by ascending distance
            var sortedDict = from entry in dictIndexDist orderby entry.Value ascending select entry;

            // instantiate new layer
            Layer3DBoxIndexed sortedLayer = new Layer3DBoxIndexed(ZLow, LayerIndex);
            foreach (var elt in sortedDict)
            {
                int index = elt.Key;
                var boxPositions = FindAll(bp => bp.Index == index);

                Vector3D vAxisWidth = HalfAxis.ToVector3D(boxPositions[0].BPos.DirectionWidth);
                boxPositions.Sort(
                    delegate (BoxPositionIndexed bp1, BoxPositionIndexed bp2)
                    {
                        double abscissa1 = Vector3D.DotProduct(bp1.BPos.Position, vAxisWidth);
                        double abscissa2 = Vector3D.DotProduct(bp2.BPos.Position, vAxisWidth);

                        if (abscissa1 > abscissa2) return 1;
                        else if (abscissa2 < abscissa1) return -1;
                        else return 0;
                    });
                foreach (var bpos in boxPositions)
                    sortedLayer.Add(bpos);
            }
            return sortedLayer;            
        }


        #endregion
        #region Public properties
        public int LayerIndex { get; }
        public double MaximumSpace { get; set; } = 0.0;
        #endregion
    }
    #region BoxPosition comparers
    internal class ComparerBoxPositionXY : IComparer<BoxPosition>
    {
        #region Constructor
        public ComparerBoxPositionXY(Vector3D dimensions) { Dimensions = dimensions; }
        private Vector3D Dimensions { get; }
        #endregion
        #region Implement IComparer<BoxPosition>
        public int Compare(BoxPosition boxPos1, BoxPosition boxPos2)
        {
            Vector3D vCenter1 = boxPos1.Center(Dimensions);
            Vector3D vCenter2 = boxPos2.Center(Dimensions);
            int xdiff = vCenter1.X.CompareTo(vCenter2.X);
            if (xdiff != 0)
                return xdiff;
            else
                return vCenter1.Y.CompareTo(vCenter2.Y);
        }
        #endregion
    }
    internal class ComparerBoxPositionDist : IComparer<BoxPosition>
    {
        #region Constructor
        public ComparerBoxPositionDist(Vector3D dimensions, Vector3D minPoint) { Dimensions = dimensions; MinPoint = minPoint; }
        private Vector3D Dimensions { get; }
        private Vector3D MinPoint { get; }
        #endregion
        #region Implement IComparer<BoxPosition>
        public int Compare(BoxPosition boxPos1, BoxPosition boxPos2)
        {
            double dist1 = (boxPos1.Center(Dimensions) - MinPoint).GetLength();
            double dist2 = (boxPos2.Center(Dimensions) - MinPoint).GetLength();

            if (dist1 < dist2)
                return -1;
            else if (dist1 > dist2)
                return 1;
            else
                return 0;
        }
        #endregion
    }
    internal class ComparerBoxPositionDistMaxCorner : IComparer<BoxPosition>
    {
        #region Constructor
        public ComparerBoxPositionDistMaxCorner(Vector3D dimensions, Vector3D minPoint) { Dimensions = dimensions; MinPoint = minPoint; }
        private Vector3D Dimensions { get; }
        private Vector3D MinPoint { get; }
        #endregion
        #region Implement IComparer<BoxPosition>
        public int Compare(BoxPosition boxPos1, BoxPosition boxPos2)
        {
            double dist1 = boxPos1.MaxDistance(Dimensions, MinPoint);
            double dist2 = boxPos2.MaxDistance(Dimensions, MinPoint);

            if (dist1 < dist2)
                return -1;
            else if (dist1 > dist2)
                return 1;
            else
                return 0;
        }
        #endregion
    }
    #endregion

    /// <summary>
    /// A layer of cylinders
    /// </summary>
    public class Layer3DCyl : List<Vector3D>, ILayer
    {
        #region Enum
        public enum SortType { DIST_CENTER }
        #endregion

        #region Constructor
        public Layer3DCyl(double zLow)
        {
            ZLow = zLow;
        }
        #endregion

        #region Public properties
        public double ZLow { get; }
        public int BoxCount { get { return 0; } }
        public int InterlayerCount { get { return 0; } }
        public int CylinderCount { get { return Count; } }
        #endregion

        #region Public methods
        /// <summary>
        /// Compute layer bouding box
        /// </summary>
        /// <param name="bProperties">Case properties</param>
        /// <returns>bounding box</returns>
        public BBox3D BoundingBox(Packable packable)
        {
            BBox3D bbox = new BBox3D();
            if (packable is RevSolidProperties cylProperties)
            {
                double radius = cylProperties.RadiusOuter;
                double height = cylProperties.Height;
                foreach (Vector3D pos in this)
                {
                    Vector3D[] pts = new Vector3D[8];
                    pts[0] = pos - radius * Vector3D.XAxis - radius * Vector3D.YAxis;
                    pts[1] = pos + radius * Vector3D.XAxis - radius * Vector3D.YAxis;
                    pts[2] = pos + radius * Vector3D.XAxis + radius * Vector3D.YAxis;
                    pts[3] = pos - radius * Vector3D.XAxis + radius * Vector3D.YAxis;
                    pts[4] = pos - radius * Vector3D.XAxis - radius * Vector3D.YAxis + height * Vector3D.ZAxis;
                    pts[5] = pos + radius * Vector3D.XAxis - radius * Vector3D.YAxis + height * Vector3D.ZAxis;
                    pts[6] = pos + radius * Vector3D.XAxis + radius * Vector3D.YAxis + height * Vector3D.ZAxis;
                    pts[7] = pos - radius * Vector3D.XAxis + radius * Vector3D.YAxis + height * Vector3D.ZAxis;

                    foreach (Vector3D pt in pts)
                        bbox.Extend(pt);
                }
            }
            return bbox;
        }
        public double Thickness(CylinderProperties cylProperties)
        {
            if (Count == 0) return 0.0;
            return cylProperties.Height;
        }
        public void Sort(Packable packable, SortType sortType)
        {
            switch (sortType)
            {
                case SortType.DIST_CENTER: Sort(new ComparerCylPositionDist()); break;
                default: break;
            }
        }
        #endregion
    }
    #endregion

    #region ComparerCylPositionDist
    public class ComparerCylPositionDist : IComparer<Vector3D>
    {
        public int Compare(Vector3D vPos1, Vector3D vPos2)
        {
            double dist1 = vPos1.GetLengthSquared();
            double dist2 = vPos2.GetLengthSquared();

            if (dist1 < dist2)
                return -1;
            else if (dist1 > dist2)
                return 1;
            else
                return 0;
        }
    }
    #endregion

    #region Layer descriptor
    public class LayerDescriptor
    {
        #region Constructors
        public LayerDescriptor()
        { 
        }
        public LayerDescriptor(bool swapped, bool hasInterlayer)
        {
            Swapped = swapped;
            HasInterlayer = hasInterlayer;
        }
        #endregion

        #region Public properties
        public bool Swapped { get; set; } = false;
        public bool HasInterlayer { get; set; } = true;
        #endregion
    }
    #endregion
}