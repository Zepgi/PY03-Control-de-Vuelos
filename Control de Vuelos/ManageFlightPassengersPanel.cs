using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Vuelos {
	public partial class ManageFlightPassengersPanel : Form {
		public ManageFlightPassengersPanel() {
			InitializeComponent();
		}

		private int x = 4;
		private int y = 10;
		private int number = 1;
		int yPos = 102;
		int xPos = 10;

		private void buttonGrid() {
			for (int i = 1; i<= y; i++) {
				int xPosition = xPos;
				for (int j = 1; j <= x; j++) {
					Button b = new Button();
					b.Text = number.ToString();
					b.Size = new Size(30, 30);
					if (j == 3) {
						xPosition += 15;
					}
					b.Location = new Point(xPosition + 30 * j, yPos);
					Controls.Add(b);
					number++;
				}
				yPos += 31;
			}
			this.pictureBox1.SendToBack();
		}
	}

}
