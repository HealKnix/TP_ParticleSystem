using Particles.Objects;
using System.Diagnostics;

namespace Particles {
	public partial class Form1 : Form {
		bool mouseIsDown = false;
		bool mouseRightClick = false;
		float mouseX = 0;
		float mouseY = 0;

		public Form1() {
			InitializeComponent();
		}

        /*
		 Событие отрисовки PaintBox'а
		*/
        private void pbMain_Paint(object sender, PaintEventArgs e) {
			Graphics g = e.Graphics;
			g.Clear(Color.White);
			g.FillRectangle(new SolidBrush(Color.FromArgb(75, 0, 239, 255)), 0, 0, pbMain.Width, pbMain.Height);

			panel1.BackColor = colorDialog1.Color;

			if (Particle.speed != 0) {
                particleAndEmitterLogic(pbMain.Width, pbMain.Height);
			}

			if (checkBox1.Checked) {
				Particle.speed = 0;
				button1.Enabled = true;
			} else {
				Particle.speed = trackBar4.Value / 20f;
				button1.Enabled = false;
			}

			particleRender(g);
            portalRenderAndLogic(g);

			if (checkBox3.Checked) {
				ParticleRadar.x = mouseX;
				ParticleRadar.y = mouseY;
				ParticleRadar.particleInside(Particle.particles, g);
				ParticleRadar.Render(g);
			}

			label1.Text = "Кол-во частиц: " + Particle.particles.Count;
		}

        /*
		 Метод отрисовки и логики порталов
		*/
        private void portalRenderAndLogic(Graphics g) {
			for (int i = 0; i < Portal.portals.Count; i++) {
				Portal.portals[i].Render(g);
			}
            for (int i = 0; i < Particle.particles.Count; i++)
            {
                for (int j = 0; j < Portal.portals.Count; j++)
                {
                    Portal.portals[j].ParticleIntersect(Particle.particles[i]);
                }
                Particle.particles[i].Render(g, checkBox2.Checked, mouseX, mouseY);
            }
        }

        /*
		 Метод отрисовки частиц
		*/
        private void particleRender(Graphics g) {
			for (int i = 0; i < Emitter.emitters.Count; i++) {
				Emitter.emitters[i].Render(g, checkBox2.Checked, mouseX, mouseY);
			}
		}

        /*
		 Метод с логикой частиц у солнца
		*/
        private void particleSunLogic(int i) {
			for (float j = 0; j < MathF.PI * 2; j += 0.25f) {
				Particle.particles.Add(
					new Particle(
						Emitter.emitters[i].x + Emitter.emitters[i].r * MathF.Cos(j),
						Emitter.emitters[i].y + Emitter.emitters[i].r * MathF.Sin(j),
						10,
						Emitter.emitters[i].color,
						Emitter.emitters[i].type
					)
				);
			}
		}

        /*
		 Метод с логикой частиц у волн
		*/
        private void particleWaveLogic(int i) {
			Emitter.emitters[i].alpha += 0.05f;
			for (int j = 0; j < 5; j++) {
				Particle.particles.Add(
					new Particle(
						Emitter.emitters[i].x + Emitter.emitters[i].r * MathF.Cos(Emitter.emitters[i].alpha),
						Emitter.emitters[i].y + Emitter.emitters[i].r * MathF.Sin(Emitter.emitters[i].alpha),
						20,
						Emitter.emitters[i].color,
						Emitter.emitters[i].type
					)
				);
			}
		}

        /*
		 Метод с логикой частиц и эмиттеров
		*/
        private void particleAndEmitterLogic(float width, float height) {
            if (checkBox2.Checked) {
                for (int i = 0; i < Emitter.emitters.Count; i++) {
                    float length = MathF.Sqrt(
                        (mouseX - Emitter.emitters[i].x) * (mouseX - Emitter.emitters[i].x)
                        +
                        (mouseY - Emitter.emitters[i].y) * (mouseY - Emitter.emitters[i].y)
                    );
                    if (length <= Emitter.emitters[i].r) {
                        if (mouseRightClick) {
                            Emitter.emitters[i].Remove();
                        }
                        else if (mouseIsDown) {
                            Emitter.emitters[i].x = mouseX;
                            Emitter.emitters[i].y = mouseY;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < Emitter.emitters.Count; i++) {
				if (Emitter.emitters[i].type == null) {
					Emitter.emitters[i].alpha += 0.01f * trackBar2.Value;
					Emitter.emitters[i].r = trackBar3.Value;
					Particle.particles.Add(
						new Particle(
							Emitter.emitters[i].x + Emitter.emitters[i].r * MathF.Cos(Emitter.emitters[i].alpha),
							Emitter.emitters[i].y + Emitter.emitters[i].r * MathF.Sin(Emitter.emitters[i].alpha),
							10,
							Emitter.emitters[i].color,
							Emitter.emitters[i].type
						)
					);
				} else if (Emitter.emitters[i].type == "sun") {
					particleSunLogic(i);
				} else if (Emitter.emitters[i].type == "wave") {
					particleWaveLogic(i);
				}
				if (Emitter.emitters[i].alpha >= MathF.PI * 2) {
					Emitter.emitters[i].alpha = 0;
				}
			}

			for (int i = 0; i < Particle.particles.Count; i++) {
				if (Particle.particles[i].health <= 0) {
					Particle.particles.RemoveAt(i);
					continue;
				}

				Particle.particles[i].GetUnitDirectionVector();

				if (Particle.particles[i].type == null) {
					Particle.particles[i].gravitation = trackBar1.Value / 10f;

					if (Particle.particles[i].y + Particle.particles[i].r >= height + Particle.particles[i].r * 2) {
						Particle.particles.RemoveAt(i);
						continue;
					} else if (Particle.particles[i].y - Particle.particles[i].r <= 0) {
						Particle.particles[i].y = Particle.particles[i].r;
						Particle.particles[i].dy *= -1; ;
					}

					if (Particle.particles[i].x + Particle.particles[i].r >= width) {
						Particle.particles[i].dx *= -1;
					} else if (Particle.particles[i].x - Particle.particles[i].r <= 0) {
						Particle.particles[i].dx *= -1;
					}

					Particle.particles[i].vx = Particle.particles[i].dx * Particle.speed;
					Particle.particles[i].vy = Particle.particles[i].dy * Particle.speed + Particle.particles[i].gravitation;
					Particle.particles[i].health -= 1f;
				} else if (Particle.particles[i].type == "sun") {
					Particle.particles[i].vx = Particle.particles[i].dx * 2.5f;
					Particle.particles[i].vy = Particle.particles[i].dy * 2.5f;
					Particle.particles[i].health -= 3f;
				} else if (Particle.particles[i].type == "wave") {
					Particle.particles[i].vx = Particle.particles[i].dx * 5f;
					Particle.particles[i].vy = Particle.particles[i].dy * 2.5f;
					Particle.particles[i].health -= 0.5f;
				}

				Particle.particles[i].x += Particle.particles[i].vx;
				Particle.particles[i].y += Particle.particles[i].vy;
			}
		}

        /*
		 Событие таймера для отрисовки PaintBox'a
		*/
        private void timer1_Tick(object sender, EventArgs e) {
			pbMain.Invalidate();
		}

        /*
		 Событие кнопок мыши
		 Добавляем эмиттер или портал
		*/
        private void pbMain_MouseClick(object sender, MouseEventArgs e) {
			if (!checkBox2.Checked) {
				Emitter.Set(e.X, e.Y, 50, colorDialog1.Color);
			}
			if (checkBox4.Checked) {
				Portal.portals.Add(new Portal(e.X, e.Y, 50));
				for (int i = 0; i < Portal.portals.Count - 1; i++) {
					Portal.portals[i].AddNeighbourPortal(Portal.portals[i + 1]);
				}
			}
		}

        /*
		 Событие перемещения мыши
		*/
        private void pbMain_MouseMove(object sender, MouseEventArgs e) {
			mouseX = e.X;
			mouseY = e.Y;
		}

        /*
		 Событие колёсика мыши
		 Меняем радиус радара
		*/
        private void pbMain_MouseWheel (object sender, MouseEventArgs e) {
			ParticleRadar.r += e.Delta / 15;
			if (ParticleRadar.r <= 0) {
				ParticleRadar.r = 0;
			}
		}

        /*
		 Событие нажатия кнопки мыши
		*/
        private void pbMain_MouseDown(object sender, MouseEventArgs e) {
			mouseIsDown = true;
			if (e.Button == MouseButtons.Right) {
				mouseRightClick = true;
			}
		}

        /*
		 Событие отпускания кнопки мыши
		*/
        private void pbMain_MouseUp(object sender, MouseEventArgs e) {
			mouseIsDown = false;
			mouseRightClick = false;
		}

        /*
		 Событие нажатия кнопки button1
		 Делаем 1 шаг в симуляции
		*/
        private void button1_Click(object sender, EventArgs e) {
			Particle.speed = trackBar4.Value / 20f;
		}

        /*
		 Событие нажатия кнопки button2
		 Выводим диалоговое окно с выбором цвета
		*/
        private void button2_Click(object sender, EventArgs e) {
			colorDialog1.ShowDialog();
		}

        /*
		 Событие нажатия кнопки button3
		 Добавляем пейзаж на PaintBox
		*/
        private void button3_Click(object sender, EventArgs e) {
			Emitter.Set(pbMain.Width - 75, 75, 50, Color.Yellow, "sun");
			Emitter.Set(pbMain.Width - (pbMain.Width / 4), pbMain.Height - 25, 50, Color.Blue, "wave");
			Emitter.Set(pbMain.Width / 2, pbMain.Height - 50, 50, Color.Blue, "wave");
			Emitter.Set(pbMain.Width / 4, pbMain.Height - 75, 50, Color.Blue, "wave");
			Emitter.Set(800, pbMain.Height - 100, 50, Color.Blue, "wave");
		}

        /*
		 Событие нажатия кнопки button4
		 Очищаем списки эмиттеров и порталов
		*/
        private void button4_Click(object sender, EventArgs e) {
			Emitter.emitters.Clear();
			Portal.portals.Clear();
		}
	}
}