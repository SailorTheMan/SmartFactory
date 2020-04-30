using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartFactory.Scripts;

namespace SmartFactory.Pages
{
    public partial class StorePage : Form
    {
        public StorePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Данные буду загружены после закрытия этого окна. Вы получите уведомление об успешном завершении.");
                new StoreToDB().Convert(openFileDialog1.FileName);
                MessageBox.Show("Данные успешно были загружены");
            }
        }
    }
}
