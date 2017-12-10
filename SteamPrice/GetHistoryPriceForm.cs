using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPrice
{
    /// <summary>
    /// 
    /// </summary>
    public partial class GetHistoryPriceForm : Form
    {

        List<Game> GameList = new List<Game>();
        /// <summary>
        /// 
        /// </summary>
        public GetHistoryPriceForm()
        {
            InitializeComponent();

            GameList.Add(new Game() {Id=440,Name="Team Fortes 2"});
            GameListComboBox.DataSource = GameList;
        }

        private void LoadHistoryPriceButton_Click(object sender, EventArgs e)
        {
            var selectedGame = (Game)GameListComboBox.SelectedItem;
            var lot = LotTextBox.Text.Trim();
            if (selectedGame == null)
            {
                MessageBox.Show("Игра не задана","Ошибка");
                return;
            }
            if (string.IsNullOrEmpty(lot))
            {
                MessageBox.Show("Не задан лот", "Ошибка");
                return;
            }

            var json = SteamWebClient.GetResponse(selectedGame, lot);
            if (string.IsNullOrEmpty(json))
            {
                MessageBox.Show(string.Format("Лот '{0}' не найден", lot), "Ошибка");
                return;
            }

        }
    }
}
