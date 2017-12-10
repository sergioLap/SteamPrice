using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamPrice
{
    /// <summary>
    /// Игра
    /// </summary>
    public class Game
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
