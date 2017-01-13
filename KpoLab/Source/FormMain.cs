using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KpoLab.Lib;

namespace KpoLab.Main
{
    public partial class FormMain : Form
    {
        private List<MetalViscosity> _MetalViscosityList = null;

        private BindingSource _BsMetalViscosityData = new BindingSource();

        public FormMain()
        {
            InitializeComponent();
        }

        private void MsiFileQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MsiFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var dataProvider = new MockMetalViscosityDataProvider();
                dataProvider.Execute();

                _MetalViscosityList = dataProvider.DataList;
                _BsMetalViscosityData.DataSource = _MetalViscosityList;

                DgvMetalViscosity.DataSource = _BsMetalViscosityData;
            }
            //обработка остальных исключений
            catch (Exception ex)
            {
                LogHelper.ErrorLog(ex.Message);
                MessageBox.Show("Ошибка: " + ex.Message);
            } 
        }

        private void MsiMetalViscosityShowInfo_Click(object sender, EventArgs e)
        {
            var formMetalViscosity = new FormMetalViscosity();
            try
            {
                var currentItem = (MetalViscosity) _BsMetalViscosityData.Current;
                formMetalViscosity.SetActiveItem(currentItem);
                formMetalViscosity.ShowDialog();
            }
            catch (Exception ex)
            {
                LogHelper.ErrorLog(ex.Message);
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
