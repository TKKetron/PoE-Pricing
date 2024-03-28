using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

using static POE_Pricing.Globals;

namespace POE_Pricing
{
    public partial class InvestForm : Form
    {
        Form main;
        private static DataTable table;
        private static bool chaos;
        public InvestForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void InvestForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            chaos = true;
            table.Columns.Add("Icon", typeof(Image));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Value", typeof(float));
            table.Columns.Add("Listed", typeof(int));
            
            AddItem(itemsByID["ClusterJewel"][63971]);
            AddItem(itemsByID["ClusterJewel"][71084]);
            AddItem(itemsByID["ClusterJewel"][64015]);
            AddItem(itemsByID["ClusterJewel"][64012]);
            AddItem(itemsByID["UniqueJewel"][40773]);
            AddItem(itemsByName["UniqueRelic"]["The Original Scripture"]);
            AddItem(itemsByName["UniqueJewel"]["The Adorned"]);
            AddItem(itemsByName["Beast"]["Primal Crushclaw"]);
            
            dataGridViewInvest.DataSource = table;
            dataGridViewInvest.ReadOnly = true;
            dataGridViewInvest.RowTemplate.Height = 50;
            dataGridViewInvest.AutoResizeColumns();
            dataGridViewInvest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewInvest.RowHeadersVisible = false;

        }

        private static int AddItem(Item item)
        {
            Image image = Image.FromStream(new WebClient().OpenRead(item.icon));
            
            table.Rows.Add(image,item.name,chaos ? item.chaosValue: item.divineValue, item.listingCount);
            return image.Height;
        }
    }
}
