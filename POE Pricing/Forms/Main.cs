using System.Diagnostics;
using System.Text.Json;

using static POE_Pricing.Globals;

namespace POE_Pricing
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();

            foreach (string type in TYPES)
                tasks.Add(GetItems(type));

            await Task.WhenAll(tasks);

            DivineValue = itemsByName["Currency"]["Divine Orb"].chaosValue; //set the divine value

            foreach (var item in itemsByName["Currency"])
                item.Value.divineValue = item.Value.chaosValue / DivineValue;

            foreach (var item in itemsByName["Fragment"])
                item.Value.divineValue = item.Value.chaosValue / DivineValue;

            Einhar_Memory_Calc.GetMemoryValue();

            InitializeMainMenu();
            //InitializeHandlers();

        }

        public void InitializeMainMenu()
        {
            panelPriceChecking.Visible = false;
            panelMoneyStrats.Visible = false;
            panelExit.Visible = false;
        }

        /// <summary>
        /// Pull from the poe ninja API for a given type
        /// </summary>
        /// <param name="type">the object type to pull from the api</param>
        /// <returns></returns>
        public async Task GetItems(string type)
        {
            bool cur = false;
            if (type == "Currency" || type == "Fragment")
                cur = true;

            string apiUrl;
            if (cur)
                apiUrl = $"https://poe.ninja/api/data/currencyoverview?league={LEAGUE}&type={type}";
            else
                apiUrl = $"https://poe.ninja/api/data/itemoverview?league={LEAGUE}&type={type}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        var document = await JsonDocument.ParseAsync(responseStream);
                        var itemsArray = document.RootElement.GetProperty("lines").ToString();
                        List<Item> itemsList = JsonSerializer.Deserialize<List<Item>>(itemsArray);

                        if (itemsList != null)
                        {
                            Dictionary<string, Item> itemsDict = new Dictionary<string, Item>();
                            Dictionary<int, Item> itemsDictID = new Dictionary<int, Item>();

                            if (cur)
                            {
                                foreach (var item in itemsList)
                                {

                                    item.name = item.currencyTypeName;
                                    item.chaosValue = item.chaosEquivalent;
                                }
                            }

                            itemsList.Sort();

                            foreach (var item in itemsList)
                            {
                                itemsDict[item.name] = item;
                                itemsDictID[item.id] = item;
                            }
                            lock (itemsByName)
                            {
                                itemsByName[type] = itemsDict;
                                itemsByID[type] = itemsDictID;
                            }
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message} of type {type}");
                }
            }
        }

        private void buttonPriceChecking_Click(object sender, EventArgs e)
        {
            panelPriceChecking.Visible = !panelPriceChecking.Visible;
        }

        private void buttonMoneyStrats_Click(object sender, EventArgs e)
        {
            panelMoneyStrats.Visible = !panelMoneyStrats.Visible;
        }

        private void buttonHervestMemory_Click(object sender, EventArgs e)
        {
            openChildForm(new HarvestMemoryForm(this), "HarvestMemory");
        }

        private Dictionary<string, Form> activeForms = new Dictionary<string, Form>();
        private string activeForm = "";
        private void openChildForm(Form childForm, string type)
        {
            if (!activeForms.ContainsKey(type))
                activeForms[type] = childForm;
            else
                childForm.Close();
            activeForm = type;
            activeForms[type].TopLevel = false;
            activeForms[type].FormBorderStyle = FormBorderStyle.None;
            activeForms[type].Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(activeForms[type]);
            panelChildForm.Tag = activeForms[type];
            activeForms[type].BringToFront();
            activeForms[type].Show();
        }

        public void closeTopForm()
        {
            activeForms[activeForm].Close();
            activeForms.Remove(activeForm);
        }

        #region Exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            panelExit.Visible = !panelExit.Visible;
            if (panelMenu.AutoScroll && panelExit.Visible)
                panelMenu.ScrollControlIntoView(panelExit);
        }

        private void buttonExitWithoutSaving_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveAndExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void buttonInvesting_Click(object sender, EventArgs e)
        {
            openChildForm(new InvestForm(this), "Invest");

        }

        private void buttonArbitrage_Click(object sender, EventArgs e)
        {

        }
    }
}
