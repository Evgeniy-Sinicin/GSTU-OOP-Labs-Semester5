using Lab1.BussinessLogic.Interfaces;
using Lab1.BussinessLogic.Metrics;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelWithError.Text = String.Empty;

            try
            {
                var actualArray = textBoxActualArray.Text.Replace(" ", "").Split(',');
                var expectedArray = textBoxExpectedArray.Text.Replace(" ", "").Split(',');
                var actual = actualArray.Select(p => Int32.Parse(p)).ToArray();
                var expected = expectedArray.Select(p => Int32.Parse(p)).ToArray();

                IMeasurable measure = new FMeasure();
                var koef = 100;
                var quality = (measure.CalculateQuality(actual, expected) * koef).ToString();
                labelWithQuality.Text = $"Качество: {quality}%";
            }
            catch(Exception ex)
            {
                labelWithError.Text = ex.Message;
                labelWithQuality.Text = $"Качество: 0%";
                textBoxActualArray.Text = String.Empty;
                textBoxExpectedArray.Text = String.Empty;
            }
        }

        private void textBoxActualArray_KeyDown(object sender, KeyEventArgs e)
        {
            if(Char.IsDigit((char)e.KeyCode))
            {
                if(!textBoxActualArray.Text.Equals(String.Empty))
                {
                    textBoxActualArray.Text += ", ";
                    textBoxActualArray.SelectionStart = textBoxActualArray.Text.Length;
                }
            }
        }

        private void textBoxExpectedArray_KeyDown(object sender, KeyEventArgs e)
        {
            if (Char.IsDigit((char)e.KeyCode))
            {
                if (!textBoxExpectedArray.Text.Equals(String.Empty))
                {
                    textBoxExpectedArray.Text += ", ";
                    textBoxExpectedArray.SelectionStart = textBoxExpectedArray.Text.Length;
                }
            }
        }
    }
}
