using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rorshah
{
    public partial class Form1 : Form
    {
        public double[] Chances;
        public bool[,] Picture;
        private static Random Random = new Random();
        private Color Col = Color.Black;

        public Form1()
        {
            InitializeComponent();
            Chances = new []{45.0,60,90,100};
            N1ChanceInput.Text = Chances[0].ToString();
            N2ChanceInput.Text = Chances[1].ToString();
            N3ChanceInput.Text = Chances[2].ToString();
            N4ChanceInput.Text = Chances[3].ToString();
        }

        private void Generate()
        {
            ///var x = Random.Next(Picture.GetLength(0));
            var x = Picture.GetLength(0) - 1;
            var y = Random.Next(Picture.GetLength(1));
            PutPixelRecursive(x,y);
        }

        private void PutPixelRecursive(int x, int y, int i = 0)
        {
            if (x < 0 || y < 0 || x >= Picture.GetLength(0) || y >= Picture.GetLength(1) 
                || Picture[x, y]) return;
            if (i > MinIterationBar.Value && !IsMarked(GetNeighborsCount(x, y))) return;
            Picture[x, y] = true;
            i++;
            PutPixelRecursive(x - 1, y, i);
            PutPixelRecursive(x + 1, y, i);
            PutPixelRecursive(x, y - 1, i);
            PutPixelRecursive(x, y + 1, i);
        }

        private void Clear()
        {
            Picture = new bool[100, 100];
        }

        private void Draw()
        {
            var wDublicate = 2;
            var hDublicate = 2;
            pictureBox1.Image = new Bitmap(Picture.GetLength(0)*2* wDublicate, Picture.GetLength(1)* hDublicate);
            var width = pictureBox1.Image.Width;
            var g = Graphics.FromImage(pictureBox1.Image);
            for (var i = 0; i < Picture.GetLength(0); i++)
            for (var j = 0; j < Picture.GetLength(1); j++)
            {
                var brush = new SolidBrush(Picture[i, j] ? Col : Color.White);
                g.FillRectangle(brush, i* wDublicate, j* hDublicate, wDublicate, hDublicate);
                g.FillRectangle(brush, width - i* wDublicate - wDublicate, j * hDublicate, wDublicate, hDublicate); //symmetric 
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            GenerateBtn.Enabled = false;
            Clear();
            Generate();
            Draw();
            GenerateBtn.Enabled = true;
        }

        private int GetNeighborsCount(int x, int y)
        {
            var count = 0;
            if (x > 0 && Picture[x - 1, y]) count++;
            if (y > 0 && Picture[x, y - 1]) count++;
            if (x < Picture.GetLength(0) - 1 && Picture[x + 1, y]) count++;
            if (y < Picture.GetLength(1) - 1 && Picture[x, y + 1]) count++;
            return count;
        }

        private bool IsMarked(int neighborCount)
        {
            if (neighborCount == 0) return true;
            var chance = Chances[neighborCount - 1];
            var rand = Random.Next(10000);
            return chance * 100 > rand;
        }

        private bool CheckInput(string text, out double? value)
        {
            value = null;
            var correct = true;
            double temp = 0;
            try
            {
                temp = Convert.ToDouble(text);
            }
            catch (Exception exception)
            {
                correct = false;
            }

            if (temp < 0 || temp > 100) correct = false;
            if (correct) value = temp;
            return correct;
        }

        private void Input4_TextChanged(object sender, EventArgs e)
        {
            var check = CheckInput(N4ChanceInput.Text, out var value);
            if (value != null) Chances[3] = value.Value;
            N4ChanceInput.BackColor = check ? Color.White : Color.FromArgb(255, 200, 200);
        }
        private void Input3_TextChanged(object sender, EventArgs e)
        {
            var check = CheckInput(N3ChanceInput.Text, out var value);
            if (value != null) Chances[2] = value.Value;
            N3ChanceInput.BackColor = check ? Color.White : Color.FromArgb(255, 200, 200);
        }
        private void Input2_TextChanged(object sender, EventArgs e)
        {
            var check = CheckInput(N2ChanceInput.Text, out var value);
            if (value != null) Chances[1] = value.Value;
            N2ChanceInput.BackColor = check ? Color.White : Color.FromArgb(255, 200, 200);
        }
        private void Input1_TextChanged(object sender, EventArgs e)
        {
            var check = CheckInput(N1ChanceInput.Text, out var value);
            if (value != null) Chances[0] = value.Value;
            N1ChanceInput.BackColor = check ? Color.White : Color.FromArgb(255, 200, 200);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Col = colorDialog1.Color;
            ColorBtn.BackColor = Col;
        }

        private void MinIterationBar_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = "Minimal size " + MinIterationBar.Value;
        }
    }
}
