using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particles.Objects {
	internal class Portal : BaseObject {
		public static List<Portal> portals = new List<Portal>(); // список всех порталов
		private Portal? nextPortal; // следующий портал

		public Portal(float x, float y, float r) {
			this.x = x;
			this.y = y;
			this.r = r;
		}

		/*
		 Метод ищет пересечение частицы с порталом
		*/
		public void ParticleIntersect(Particle particle) {
			if (this.nextPortal != null) {
				float length = MathF.Sqrt((x - particle.x) * (x - particle.x) + (y - particle.y) * (y - particle.y));
				if (length <= r) {
					// переносим частицу к следующему порталу
					particle.x = nextPortal.x + new Random().Next((int)-nextPortal.r, (int)nextPortal.r);
					particle.y = nextPortal.y + new Random().Next((int)-nextPortal.r, (int)nextPortal.r);
				}
			}
		}

		/*
		 Метод добавляет следующий портал к текущему порталу
		*/
		public void AddNeighbourPortal(Portal portal) {
            nextPortal = portal;
		}

		/*
		 Метод отрисовывает порталы
		*/
		public void Render(Graphics g) {
			g.Transform = GetTransform();
			if (this.nextPortal != null) {
				g.DrawLine(new Pen(Color.Red), 0, 0, nextPortal.x - x, nextPortal.y - y);
			}
			g.DrawEllipse(new Pen(Color.Green, 3), -r, -r, r * 2, r * 2);
		}
	}
}
