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

            DivineValue = items["Currency"]["Divine Orb"].chaosValue; //set the divine value

            foreach (var item in items["Currency"])
                item.Value.divineValue = item.Value.chaosValue / DivineValue;

            foreach (var item in items["Fragment"])
                item.Value.divineValue = item.Value.chaosValue / DivineValue;

            Einhar_Memory_Calc.GetMemoryValue();

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
                            }
                            lock (items)
                            {
                                items[type] = itemsDict;
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
        /*
        public void WriteItemsToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var kvp in items)
                {
                    writer.WriteLine($"Items for type '{kvp.Key}':");
                    foreach (var item in kvp.Value.Values)
                    {
                        string itemName = item.name.Length > STR_LEN ? item.name.Substring(0, STR_LEN) : item.name;
                        writer.WriteLine($"Item Name: {itemName.PadRight(STR_LEN + 5)}Chaos Value: {item.chaosValue.ToString().PadRight(10)}Divine Value: {item.divineValue}");
                    }
                    writer.WriteLine();
                }
            }
        }
        */
    }
}
