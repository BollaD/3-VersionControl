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

        public Form1()
        {
            InitializeComponent();
            Rates_DGW.DataSource = Rates;
            chartRateData.DataSource = Rates;
            xmlFeldolgozás();
            ChartSetup();
        }

        public string SzolgaltatasLehivas()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            return result;
        }

        public void xmlFeldolgozás()
        {
            var xml = new XmlDocument();
            xml.LoadXml(SzolgaltatasLehivas());

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                rate.Date = DateTime.Parse(element.GetAttribute("date"));
                var xml_element = (XmlElement)element.ChildNodes[0];
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
    }
}
