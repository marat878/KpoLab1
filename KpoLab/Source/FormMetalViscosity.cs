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
    public partial class FormMetalViscosity : Form
    {
        private MetalViscosity _ActiveItem;
        public MetalViscosity ActiveItem
        {
            get
            {
                return _ActiveItem;
            }
        }

        public void SetActiveItem(MetalViscosity item)
        {
            if (item == null) 
            {
                throw new ArgumentNullException("item");
            }

            _ActiveItem = item;

            TbName.Text = _ActiveItem.Name;
            TbAtomicNumber.Text = _ActiveItem.AtomicNumber.ToString();
            TbTemperature.Text = _ActiveItem.Temperature.ToString();
            TbViscosity.Text = _ActiveItem.Viscosity.ToString();
        }

        public FormMetalViscosity()
        {
            InitializeComponent();
        }

        private void FormMetalViscosity_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormMetalViscosity_FormClosing(object sender, FormClosingEventArgs e)
        {
            try 
            {
                _ActiveItem.Name = TbName.Text;
                _ActiveItem.AtomicNumber = Int32.Parse(TbAtomicNumber.Text);
                _ActiveItem.Temperature = Int32.Parse(TbTemperature.Text);
                _ActiveItem.Viscosity = Double.Parse(TbViscosity.Text, System.Globalization.CultureInfo.InvariantCulture);

                if (!MetalViscosityHelper.ValidateFields(_ActiveItem)) 
                {
                    throw new Exception("Указаны некорректные значения полей!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                LogHelper.ErrorLog(ex);
                e.Cancel = true;
            }
        }
    }
}