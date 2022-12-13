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
using System.Xml;

namespace SOAP_MNB
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();

        public Form1()
        {
            InitializeComponent();
            SzolgaltatasLehivas();
            Rates_DGW.DataSource = Rates;
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
    }
}
