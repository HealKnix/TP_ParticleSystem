using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Particles.Objects {
	internal class Emitter : BaseObject {
		static public List<Emitter> emitters = new List<Emitter>(); // список эмиттеров
		public float alpha; // alpha канал argb
		public string? type; // тип эммитера

		public Emitter(float x, float y, float r) {
			this.x = x;
			this.y = y;
			this.r = r;
			this.alpha = 0;
			this.type = null;
			this.color = Color.FromArgb(
				new Random().Next(50, 200), 
				new Random().Next(150, 255), 
				new Random().Next(150, 255), 
				new Random().Next(150, 255)
			);
		}

		public Emitter(float x, float y, float r, Color color) {
			this.x = x;
			this.y = y;
			this.r = r;
			this.type = null;
			this.color = color;
		}

		public Emitter(float x, float y, float r, Color color, string? type) {
			this.x = x;
			this.y = y;
			this.r = r;
			this.type = type;
			this.color = color;
		}

		/*
		 Метод добавляет в список эмиттеров новый эмиттер
		*/
		static public void Set(float x, float y, float r) {
			emitters.Add(new Emitter(x, y, r));
		}
        /*
		 Метод добавляет в список эмиттеров новый эмиттер с заданным цветом
		*/
        static public void Set(float x, float y, float r, Color color) {
			emitters.Add(new Emitter(x, y, r, color));
		}
        /*
		 Метод добавляет в список эмиттеров новый эмиттер с заданным цветов и типом
		*/
        static public void Set(float x, float y, float r, Color color, string? type) {
			emitters.Add(new Emitter(x, y, r, color, type));
		}

        /*
		 Метод удаляет текущий эмиттер из списка эмиттеров
		*/
        public void Remove() {
			emitters.Remove(this);
		}

        /*
		 Метод отрисовывает эмитер
		*/
        public void Render(Graphics g, bool isDebug, float mouseX, float mouseY) {
			g.Transform = GetTransform();

			if (this.type == "sun") {
				g.FillEllipse(new SolidBrush(Color.FromArgb(150, color)), -r, -r, r * 2, r * 2);
			}

			if (isDebug) {
				g.DrawEllipse(new Pen(Color.FromArgb(255, color), 2), -r, -r, r * 2, r * 2);
				float length = MathF.Sqrt((mouseX - this.x) * (mouseX - this.x) + (mouseY - this.y) * (mouseY - this.y));
				if (length <= this.r) {
					g.DrawEllipse(new Pen(Color.Gray, 2), -r, -r, r * 2, r * 2);
				}
			}
		}
	}
}
