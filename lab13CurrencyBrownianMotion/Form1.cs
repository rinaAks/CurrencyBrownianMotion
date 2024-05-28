using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13CurrencyBrownianMotion
{
    public partial class Form1 : Form
    {
        bool buttonValue;
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonValue = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        double priceEuro, priceDollar;
        int day;
        double dt = 1;

        // sigma - volatility, is measured by the day-to-day percentage difference in the price of the commodity 
        // mu - drift, gradual and usually directionless change without a direct or obvious cause
        double sigmaEuro, muEuro;
        double sigmaDollar, muDollar;

        Random rnd = new Random(); //от 0 до 1
        private void btStart_Click(object sender, EventArgs e)
        {
            day = 0;
            buttonValue = true;
            priceEuro = (double)edPriceEuro.Value;
            priceDollar = (double)edPriceDollar.Value;

            sigmaEuro = (double)edSigmaEuro.Value;
            muEuro = (double)edMuEuro.Value;
            sigmaDollar = (double)edSigmaDollar.Value;
            muDollar = (double)edMuDollar.Value;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.AddXY(0, priceEuro);
            chart1.Series[1].Points.AddXY(0, priceDollar);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (buttonValue)
            {
                day++;
                priceEuro = geometricBrownianMotionValue(priceEuro, sigmaEuro, muEuro);
                priceDollar = geometricBrownianMotionValue(priceDollar, sigmaDollar, muDollar);
                chart1.Series[0].Points.AddXY(day, priceEuro);
                chart1.Series[1].Points.AddXY(day, priceDollar);
            }

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            buttonValue = false;
            timer1.Stop();
        }

        double wienerProcess = 0;
        double geometricBrownianMotionValue(double oldPrice, double sigma, double mu)
        {
            double normalValue = newNormalValue();
            wienerProcess = wienerProcess + Math.Sqrt(dt) * normalValue;
            double newPrice = oldPrice * Math.Exp((mu - sigma * sigma / 2) * dt + sigma * wienerProcess);
            return newPrice;
            
        }

        double newNormalValue()
        {
            // Generator based on Box-Muller transform
            double rnd1 = (double)rnd.NextDouble();
            double rnd2 = (double)rnd.NextDouble();
            double normalValue = Math.Sqrt(-2.0 * Math.Log10(rnd1)) * Math.Cos(2.0 * Math.PI * rnd2); 

            return normalValue;
        }
    }
}
