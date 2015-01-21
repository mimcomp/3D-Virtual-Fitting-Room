﻿using Microsoft.Kinect;
using System.Windows.Media.Media3D;

namespace KinectFittingRoom.ViewModel.ClothingItems
{
    class TieItem : ClothingItemBase
    {
        /// <summary>
        /// The ratio
        /// </summary>
        private const double Ratio = 0.3;
        /// <summary>
        /// Initializes a new instance of the <see cref="TieItem"/> class.
        /// </summary>
        /// <param name="model">3D model</param>
        public TieItem(Model3DGroup model)
            : base(model, Ratio)
        {
            JointToTrackPosition = JointType.ShoulderCenter;
            LeftJointToTrackAngle = JointType.ShoulderLeft;
            RightJointToTrackAngle = JointType.ShoulderRight;
        }
    }
}