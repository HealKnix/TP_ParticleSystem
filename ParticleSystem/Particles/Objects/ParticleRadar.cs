using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Particles.Objects {
	internal class ParticleRadar : BaseObject {
		public static new float x; // координата X
		public static new float y; // координата Y
		public static new float r = 50; // радиус радара
		public static int particleCount = 0; // кол-во частиц в радаре
		private static new Color color = Color.Red; // цвет радара

		/*
		 Метод ищет пересечение частицы с радаром
		*/
		public static void particleInside(List<Particle> particle, Graphics g) {
			particleCount = 0;
			for (int i = 0; i < particle.Count; i++) {
				float length = MathF.Sqrt((x - particle[i].x) * (x - particle[i].x) + (y - particle[i].y) * (y - particle[i].y));
				if (length <= r) {
					particleCount++;
					particle[i].Render(color, g); // отрисовываем частицу с цветом радара
				}
			}
		}

		public static new Matrix GetTransform() {
			Matrix matrix = new Matrix();
			matrix.Translate(x, y);
			return matrix;
		}

		/*
		 Метод отрисовывает радар
		*/
		public static void Render(Graphics g) {
			g.Transform = GetTransform();

			g.DrawEllipse(new Pen(Color.FromArgb(255, color), 2), -r, -r, r * 2, r * 2);
			g.DrawString(
				particleCount.ToString(),
				new Font("Verdana", 16),
				new SolidBrush(Color.Black),
				-16, -16
			);
		}
	}
}
