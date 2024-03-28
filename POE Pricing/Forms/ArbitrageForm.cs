using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static POE_Pricing.Globals;

namespace POE_Pricing
{
    public partial class ArbitrageForm : Form
    {
        Form main;
        class VendorItem : Item
        {
            public float altValue { get; set; }
        }
        List<VendorItem> vendor;
        public ArbitrageForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void ArbitrageForm_Load(object sender, EventArgs e)
        {
            vendor = new List<VendorItem>();
            //vendor.Add(new VendorItem(itemsByName["Currency"]["orb of Alchemy"])
        }
    }
}
