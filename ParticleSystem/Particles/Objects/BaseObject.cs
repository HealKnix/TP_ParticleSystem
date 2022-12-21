using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles.Objects {
	internal abstract class BaseObject {
		public float x; // координата по X
		public float y;	// координата по Y
		public float r;	// радиус
		public Color color; // цвет

		public Matrix GetTransform() {
			Matrix matrix = new Matrix();
			matrix.Translate(x, y);
			return matrix;
		}
	}
}
