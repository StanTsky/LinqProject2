using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace LinqProject2
{
    public partial class Form1 : Form
    {
        List<Player> allPlayers = new List<Player>();
        List<Pokemon> allPokemons = new List<Pokemon>();
        List<Owner> allOwners = new List<Owner>();
        List<Owner> allJoined = new List<Owner>();

        public Form1()
        {
            InitializeComponent();
            LoadData();             //populate grids
            PopulateCombos();       //populate combo boxes
            //LoadXmlResources();         //for test purposes
        }

        private void LoadXmlResources()
        {
            var name = "LinqProject2.Resources.pokedata.xml";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
            using (StreamReader file = new StreamReader(stream))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Xml2CSharp.Pokedata));
                Xml2CSharp.Pokedata pokeData = (Xml2CSharp.Pokedata)ser.Deserialize(file);

                playersGridView.AutoGenerateColumns = true;                 //populate grid views
                playersGridView.DataSource = pokeData.Players.Player;
                playersGridView.Columns[5].Visible = false;                 //hide temp field

                pokemonGridView.AutoGenerateColumns = true;
                pokemonGridView.DataSource = pokeData.PokemonTypes.Pokemon;

                ownerGridView.AutoGenerateColumns = true;
                ownerGridView.DataSource = pokeData.OwnershipData.Ownership;
            }
        }

        void LoadData()
        {   //player data
            string[] players = Properties.Resources.Players.Trim().Split('\n');
            foreach (string player in players)                  //loop through players
            {
                string[] fields = player.Trim().Split(',');     //split into fields
                Player p = new Player
                {
                    ID = Convert.ToInt32(fields[1]),
                    Name = fields[0],
                    Nickname = fields[2],
                    City = fields[3],
                    PaidUp = Convert.ToBoolean(fields[4])
                };
                allPlayers.Add(p);                              //save it
            }
            var playersInOrder = allPlayers.OrderByDescending(p => Convert.ToBoolean(p.PaidUp)).ToList();
            playersGridView.AutoGenerateColumns = true;         //populate grid view
            playersGridView.DataSource = playersInOrder;
            playersGridView.Columns[3].Visible = false;         //hide city
            playersGridView.Columns[4].HeaderText = "Paid";
            //pokemon data
            string[] pokemons = Properties.Resources.Pokemon.Trim().Split('\n');
            foreach (string pokemon in pokemons)                //loop through pokemons
            {
                string[] fields = pokemon.Trim().Split(',');    //split into fields
                Pokemon pm = new Pokemon
                {
                    ID = Convert.ToInt32(fields[0]),
                    Name = fields[1],
                    Attack = Convert.ToInt32(fields[2]),
                    Defense = Convert.ToInt32(fields[3])
                };
                allPokemons.Add(pm); //save it
            }
            pokemonGridView.AutoGenerateColumns = true;         //populate grid view
            pokemonGridView.DataSource = allPokemons;
            //owner data
            string[] owners = Properties.Resources.Ownership.Trim().Split('\n');
            foreach (string owner in owners)                    //loop through owners
            {
                string[] fields = owner.Trim().Split(',');      //split into fields
                Owner o = new Owner
                {
                    PlayerId = Convert.ToInt32(fields[0]),
                    PokemonId = Convert.ToInt32(fields[1]),
                    Level = Convert.ToInt32(fields[2]),
                    NumberOwned = Convert.ToInt32(fields[3])
                };
                allOwners.Add(o); //save it
            }
            //joined data
            var all = from o in allOwners
                      join p in allPlayers on o.PlayerId equals p.ID
                      join pm in allPokemons on o.PokemonId equals pm.ID
                      select new
                      {
                          PlayerId = o.PlayerId,
                          PlayerName = p.Name,
                          PokemonId = o.PokemonId,
                          PokemonName = pm.Name,
                          Level = o.Level,
                          NumberOwned = o.NumberOwned
                      };
            foreach (var item in all)
            {
                Owner o = new Owner
                {
                    PlayerId = item.PlayerId,
                    PlayerName = item.PlayerName,
                    PokemonId = item.PokemonId,
                    PokemonName = item.PokemonName,
                    Level = item.Level,
                    NumberOwned = item.NumberOwned
                };
                allJoined.Add(o);                                   //save it
            }
            ownerGridView.AutoGenerateColumns = true;               //populate grid view
            ownerGridView.DataSource = allJoined;                   //or all.ToList();
            ownerGridView.Columns[0].HeaderText = "Player Id";
            ownerGridView.Columns[0].Visible = false;               //hide player id
            ownerGridView.Columns[1].HeaderText = "Player Name";
            //ownerGridView.Columns[1].Visible = false;             //hide player name
            ownerGridView.Columns[2].HeaderText = "Pokemon Id";
            ownerGridView.Columns[2].Visible = false;               //hide pokemon id
            ownerGridView.Columns[3].HeaderText = "Pokemon Name";
            //ownerGridView.Columns[3].Visible = false;             //hide pokemon name
            ownerGridView.Columns[5].HeaderText = "Number Owned";
        } //end load data

        void PopulateCombos()
        {   //cities
            var cities = from p in allPlayers
                         orderby p.City
                         select p.City;
            HashSet<string> pset = new HashSet<string>(cities);         //removed duplicates
            cityComboBox.Items.AddRange(pset.ToArray());
            cityComboBox.Items.Insert(0, "(All Cities)");                      //allow to reset selection
            //attacks
            var attacks = from pm in allPokemons
                          orderby pm.Attack
                          select pm.Attack.ToString();
            HashSet<string> pmAset = new HashSet<string>(attacks);      //removed duplicates
            attackComboBox.Items.AddRange(pmAset.ToArray());
            //defenses
            var defenses = from pm in allPokemons
                           orderby pm.Defense
                           select pm.Defense.ToString();
            HashSet<string> pmDset = new HashSet<string>(defenses);     //removed duplicates
            defenseComboBox.Items.AddRange(pmDset.ToArray());
            //players
            var players = from p in allPlayers
                          join j in allJoined on p.Name equals j.PlayerName
                          orderby p.Name
                          select p.Name;
            HashSet<string> plset = new HashSet<string>(players);       //removed duplicates
            playerComboBox.Items.AddRange(plset.ToArray());
            playerComboBox.Items.Insert(0, "(All Players)");                    //allow to reset selection
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = cityComboBox.SelectedItem.ToString();
            var cities = from p in allPlayers
                         orderby p.PaidUp descending
                         select new { p.ID, p.Nickname, p.Name, p.PaidUp };
            if (city != "(All Cities)")
            {
                cities = from p in allPlayers
                         where p.City == city
                         orderby p.PaidUp descending
                         select new { p.ID, p.Nickname, p.Name, p.PaidUp };
            }
            playersGridView.AutoGenerateColumns = true;
            playersGridView.DataSource = new BindingSource(cities, null);
        }

        private void comboAttackValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attackComboBox.SelectedIndex < 0) return;   // ignore processing if combobox is resetting
            if (defenseComboBox.SelectedIndex > -1)
            {
                defenseComboBox.SelectedIndex = -1;         //clear the defense combobox selection
            }
            int attack = Convert.ToInt32(attackComboBox.SelectedItem);
            var pokemonAttack = from pm in allPokemons
                           where pm.Attack >= attack
                           orderby pm.Attack descending
                           select new { pm.ID, pm.Name, pm.Attack, pm.Defense };
            pokemonGridView.AutoGenerateColumns = true;
            pokemonGridView.DataSource = new BindingSource(pokemonAttack, null);
        }

        private void defenseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defenseComboBox.SelectedIndex < 0) return;  // ignore processing if combobox is resetting
            if (attackComboBox.SelectedIndex > -1)
            {
                attackComboBox.SelectedIndex = -1;          //clear the attack combobox selection
            }
            int defense = Convert.ToInt32(defenseComboBox.SelectedItem);
            var pokemonDefense = from pm in allPokemons
                           where pm.Defense >= defense
                           orderby pm.Defense descending
                           select new { pm.ID, pm.Name, pm.Attack, pm.Defense };
            pokemonGridView.AutoGenerateColumns = true;
            pokemonGridView.DataSource = new BindingSource(pokemonDefense, null);
        }

        private void playerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string player = playerComboBox.SelectedItem.ToString();
            var owners = from j in allJoined
                         orderby j.PlayerId
                         select new
                         {
                             j.PlayerId,
                             j.PlayerName,
                             j.PokemonId,
                             j.PokemonName,
                             j.Level,
                             j.NumberOwned
                         };
            if (player != "(All Players)")
            {
                owners = from j in allJoined
                         where j.PlayerName == player
                         orderby j.PlayerId
                         select new
                         {
                             j.PlayerId,
                             j.PlayerName,
                             j.PokemonId,
                             j.PokemonName,
                             j.Level,
                             j.NumberOwned
                         };
            }
            ownerGridView.AutoGenerateColumns = true;
            ownerGridView.DataSource = new BindingSource(owners, null);
        }
    }
}
