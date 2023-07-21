using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmaRaceToteBoard.Models
{
    public class HorseRaceParameterModel
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int HorseNumber { get; set; }

        /// <summary>
        /// 名次
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public double Position { get; set; }
    }
}
