using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles.Objects {
	internal class Particle : BaseObject {
		public static List<Particle> particles = new List<Particle>(); // список всех частиц
		public static float speed = 2.5f; // скорость частицы
		public float gravitation = 0.05f; // гравитация частицы
		public float dx; // вектор направления по x
		public float dy; // вектор направления по y
		public float vx; // вектор скорости по x
		public float vy; // вектор скорости по y
		public float health; // жизнь частицы
		public string? type; // тип частицы

		public Particle(float x, float y, float r, Color color, string? type) {
			this.x = x;
			this.y = y;
			int randAngle = new Random().Next(0, 359);
			GetUnitDirectionVector(
				MathF.Cos((randAngle * MathF.PI) / 180),
				MathF.Sin((randAngle * MathF.PI) / 180)
			);
			this.vx = this.dx * speed;
			this.vy = this.dy * speed;
			this.r = new Random().Next(1, (int)r);
			this.health = new Random().Next(50, 200);
			this.type = type;
            this.color = Color.FromArgb((int)this.health, color);
		}

		/*
		 Метод трансформирует вектор направления в единичный вектор направления
		*/
		public void GetUnitDirectionVector() {
			float length = MathF.Sqrt(this.vx * this.vx + this.vy * this.vy);
			this.dx = this.vx / length;
			this.dy = this.vy / length;
		}
		public void GetUnitDirectionVector(float x, float y) {
			float length = MathF.Sqrt(x * x + y * y);
			this.dx = x / length;
			this.dy = y / length;
		}

		/*
		 Метод отрисовывает частицу с заданным цветом 
		*/
		public void Render(Color color, Graphics g) {
			g.Transform = GetTransform();

			g.FillEllipse(new SolidBrush(color), -r, -r, r * 2, r * 2);
		}

		/*
			Метод отрисовывет частицу и вектор направления 
		*/
		public void Render(Graphics g, bool isDebug, float mouseX, float mouseY) {
			g.Transform = GetTransform();

			g.FillEllipse(new SolidBrush(Color.FromArgb((int)this.health < 0 ? 0 : (int)this.health, color)), -r, -r, r * 2, r * 2);

			if (isDebug) {
				float length = MathF.Sqrt((mouseX - this.x) * (mouseX - this.x) + (mouseY - this.y) * (mouseY - this.y));
				if (length <= this.r) {
					g.DrawEllipse(new Pen(Color.Lime, 2), -r, -r, r * 2, r * 2);
					g.DrawString(
						"x: " + ((int)this.x).ToString() + "\ny: " + ((int)this.y).ToString() + "\nlife: " + ((int)this.health).ToString(),
						new Font("Verdana", 8),
						new SolidBrush(Color.Black),
						this.r, this.r
					);
				}
				g.DrawLine(new Pen(Color.Black, 1), 0, 0, this.dx * this.r, this.dy * this.r);
			}
		}
	}
}
