using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaDolarHG {
    public partial class FrmConsultaDolar : Form {
        public FrmConsultaDolar() {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void btnSeanch_Click(object sender, EventArgs e) {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=abcf7ca9";

            using (HttpClient client = new HttpClient()) {
                var response = client.GetAsync(strURL).Result;

                try {

                    if (response.IsSuccessStatusCode) {
                        var result = response.Content.ReadAsStringAsync().Result;

                        Market market = JsonConvert.DeserializeObject<Market>(result);

                        lblBay.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lblSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lblVar.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);
                    } else {
                        lblBay.Text = "-";
                        lblSell.Text = "-";
                        lblVar.Text = "-";

                    }

                } catch (Exception ex) {
                    lblBay.Text = "-";
                    lblSell.Text = "-";
                    lblVar.Text = "-";

                    MessageBox.Show(ex.Message);
                }

                
            }
        }
    }
}
