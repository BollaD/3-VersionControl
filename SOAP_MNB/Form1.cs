using SOAP_MNB.Entities;
using SOAP_MNB.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace SOAP_MNB
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();

        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            ValutaLekerdezes(GetCurrencies());
            RefreshData();
        }

        private void RefreshData()
        {
            Rates.Clear();

            Rates_DGW.DataSource = Rates;
            chartRateData.DataSource = Rates;
            comboBox1.DataSource = Currencies;
            xmlFeldolgozás(SzolgaltatasLehivas());
            ChartSetup();
        }

        public string SzolgaltatasLehivas()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = Convert.ToString(comboBox1.SelectedItem),
                startDate = Convert.ToString(dateTimePicker1.Value),
                endDate = Convert.ToString(dateTimePicker2.Value)
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            return result;
        }

        public void xmlFeldolgozás(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                rate.Date = DateTime.Parse(element.GetAttribute("date"));
                var xml_element = (XmlElement)element.ChildNodes[0];
                if (xml_element == null) continue;
                rate.Currency = xml_element.GetAttribute("curr");
                var unit = decimal.Parse(xml_element.GetAttribute("unit"));
                var inner = decimal.Parse(xml_element.InnerText);
                if (unit != 0)
                {
                    rate.Value = inner;
                }
                else
                {
                    rate.Value = unit;
                }
                Rates.Add(rate);
            }
        }

        public void ChartSetup()
        {
            var series = chartRateData.Series[0];
            var legend = chartRateData.Legends[0];
            var chartArea = chartRateData.ChartAreas[0];

            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            legend.Enabled = false;

            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void ValutaLekerdezes(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                foreach (XmlElement xml_element in element.ChildNodes)
                {
                    Currencies.Add(xml_element.InnerText);
                }
            }
        }

        public string GetCurrencies()
        {
            var mnbArfolyam = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrenciesRequestBody();

            var response = mnbArfolyam.GetCurrencies(request);

            var result = response.GetCurrenciesResult;

            return result;
        }
    }
}
