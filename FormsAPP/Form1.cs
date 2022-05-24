using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZadanieRekrutacyjne.Database;

namespace ZadanieRekrutacyjne
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LokaleQuery lokale = new LokaleQuery();

            var listaLokali = lokale.GetLokaleList();

            lokaleComboBox.DataSource = listaLokali;


            
           
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string pickedLokal = lokaleComboBox.Text;

            if (toDate.DateTime < fromDate.DateTime)
            {
                MessageBox.Show($"Wybrano nieprawidłowy zakres dat");
            }
            else
            {


                string pickedFromDate = fromDate.DateTime.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
                string pickedfinalDate = toDate.DateTime.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);



                selectDataQuery selectDataQuery = new selectDataQuery();

                var dane = selectDataQuery.GetRaport(pickedLokal, pickedFromDate, pickedfinalDate);

                
                    myDataGrid.DataSource = dane;
                    
                
                
            }

        }
    }
}
