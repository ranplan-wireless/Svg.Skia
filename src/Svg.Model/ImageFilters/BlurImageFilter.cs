﻿namespace Svg.Model
{
    public class BlurImageFilter : ImageFilter
    {
        public float SigmaX { get; set; }
        public float SigmaY { get; set; }
        public ImageFilter? Input { get; set; }
        public CropRect? CropRect { get; set; }
    }
}
