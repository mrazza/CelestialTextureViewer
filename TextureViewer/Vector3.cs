// -----------------------------------------------------------------------
// <copyright file="Vector3.cs" company="">
// Copyright (C) 2018 Matthew Razza
// </copyright>
// -----------------------------------------------------------------------

namespace TextureViewer
{
    using System;
    using System.Drawing;
    using System.Text;

    internal class Vector3
    {
        public float X
        {
            get;
            private set;
        }

        public float Y
        {
            get;
            private set;
        }

        public float Z
        {
            get;
            private set;
        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(this.X * this.X + this.Y * this.Y + this.Z * this.Z);
            }
        }

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3 Normalize()
        {
            var length = this.Length;
            return new Vector3(this.X / length, this.Y / length, this.Z / length);
        }

        public static Vector3 FromPixel(Color pixel)
        {
            return new Vector3(pixel.R / 127.5f - 1, pixel.G / 127.5f - 1, pixel.B / 127.5f - 1);
        }

        public Color ToPixel()
        {
            // Let's be safe from rounding errors and clamp at 255.
            return Color.FromArgb(Math.Min(255, (int)((X + 1) * 128)), Math.Min(255, (int)((Y + 1) * 128)), Math.Min(255, (int)((Z + 1) * 128)));
        }

        public Vector3 Mul(Vector3 transformation)
        {
            return new Vector3(this.X * transformation.X, this.Y * transformation.Y, this.Z * transformation.Z);
        }

        public string GetDirectionString()
        {
            StringBuilder builder = new StringBuilder();

            if (this.X > 0)
            {
                builder.Append("[RIGHT] ");
            }
            else if (this.X < 0)
            {
                builder.Append("[LEFT] ");
            }

            if (this.Y > 0)
            {
                builder.Append("[DOWN] ");
            }
            else if (this.Y < 0)
            {
                builder.Append("[UP] ");
            }

            if (this.Z > 0)
            {
                builder.Append("[OUT] ");
            }
            else if (this.Z < 0)
            {
                builder.Append("[IN] ");
            }

            return builder.ToString().Trim();
        }
    }
}