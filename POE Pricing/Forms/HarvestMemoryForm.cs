using System.Net;

using static POE_Pricing.Globals;

namespace POE_Pricing
{

    public partial class HarvestMemoryForm : Form
    {
        Form main;

        bool[] CheckedBeasts = new bool[9];

        List<Item> BeastItems = new List<Item>();

        public HarvestMemoryForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void UpdateValues(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                CheckedBeasts[int.Parse((sender as CheckBox).Tag.ToString())] = (sender as CheckBox).Checked;

            float valuePP, valueP, valueH, memPerHr;

            memPerHr = 60f / (float)numericUpDownTimePerMemory.Value;

            valuePP = BeastItems.Where(x => CheckedBeasts[BeastItems.IndexOf(x)]).Sum(x => checkBoxUseDivine.Checked ? x.divineValue : x.chaosValue);
            valueP = BeastItems.Sum(x => checkBoxUseDivine.Checked ? x.divineValue : x.chaosValue) - valuePP;
            valuePP *= .2f;
            valueP *= .2f;

            valueH = BeastItems.Sum(x => checkBoxUseDivine.Checked ? x.divineValue : x.chaosValue) -
                (checkBoxUseDivine.Checked ? itemsByName["Memory"]["Einhar's Memory of Harvest Beasts"].divineValue : 
                itemsByName["Memory"]["Einhar's Memory of Harvest Beasts"].chaosValue);
            labelHostProfitOutputMem.Text = valueH.ToString("f2");
            labelHostProfitOutputHr.Text = (valueH * memPerHr).ToString("f2");
            labelPerPlayerProfitOutputMem.Text = (valuePP).ToString("f2");
            labelPerPlayerProfitOutputHr.Text = (valuePP * memPerHr).ToString("f2");
            labelTotalProfitOutputMem.Text = (valueH + valuePP * (float)numericUpDownExtraPlayers.Value).ToString("f2");
            labelTotalProfitOutputHr.Text = ((valueH + valuePP * (float)numericUpDownExtraPlayers.Value) * memPerHr).ToString("f2");
            labelPlayerProfitOutputMem.Text = valueP.ToString("f2");
            labelPlayerProfitOutputHr.Text = (valueP * memPerHr).ToString("f2");
        }

        private void HarvestMemoryForm_Load(object sender, EventArgs e)
        {
            checkBoxUseDivine.Image = Image.FromStream(new WebClient().OpenRead(itemsByName["Currency"]["Chaos Orb"].icon));
            BeastItems.Add(itemsByName["Beast"]["Vivid Vulture"]);
            BeastItems.Add(itemsByName["Beast"]["Vivid Watcher"]);
            BeastItems.Add(itemsByName["Beast"]["Vivid Abberarach"]);
            BeastItems.Add(itemsByName["Beast"]["Wild Bristle Matron"]);
            BeastItems.Add(itemsByName["Beast"]["Wild Hellion Alpha"]);
            BeastItems.Add(itemsByName["Beast"]["Wild Brambleback"]);
            BeastItems.Add(itemsByName["Beast"]["Primal Rhex Matriarch"]);
            BeastItems.Add(itemsByName["Beast"]["Primal Cystcaller"]);
            BeastItems.Add(itemsByName["Beast"]["Primal Crushclaw"]);
        }

        private void checkBoxUseDivine_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxUseDivine.Image = checkBoxUseDivine.Checked ? Image.FromStream(new WebClient().OpenRead(itemsByName["Currency"]["Divine Orb"].icon)) : Image.FromStream(new WebClient().OpenRead(itemsByName["Currency"]["Chaos Orb"].icon));
            UpdateValues(null, e);
        }
    }
}
