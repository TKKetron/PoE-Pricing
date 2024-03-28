using System.Windows.Forms.VisualStyles;

namespace POE_Pricing
{

    public partial class HarvestMemoryForm : Form
    {
        Form main;

        bool[] CheckedBeasts = new bool[9];

        public HarvestMemoryForm(Form main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void UpdateValues(object sender, EventArgs e)
        {
            if (sender is CheckBox)
                CheckedBeasts[int.Parse((sender as CheckBox).Tag.ToString())] = (sender as CheckBox).Checked;

        }

    }
}
