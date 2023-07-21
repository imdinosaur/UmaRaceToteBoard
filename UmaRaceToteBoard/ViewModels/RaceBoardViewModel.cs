using GD_CommonLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmaRaceToteBoard.Models;

namespace UmaRaceToteBoard.ViewModels
{
    public class RaceBoardViewModel:GD_CommonLibrary.BaseViewModel
    {
        ObservableCollection<HorseRaceParameterModel> HorseList { get; set; } = new ObservableCollection<HorseRaceParameterModel>();

        private string _raceTrackName = "東京";
        public string RaceTrackName 
        {
            get => _raceTrackName;
            set
            {
                _raceTrackName = value;
                OnPropertyChanged();
            }
        }



        private int _horseNumber_1 = 15;
        public int HorseNumber_1
        {
            get
            {
                return _horseNumber_1;
            }
            set
            {
                _horseNumber_1 = value;
                OnPropertyChanged();
            }
        }

        private int _horseNumber_2 = 0;
        public int HorseNumber_2
        {
            get
            {
                return _horseNumber_2;
            }
            set
            {
                _horseNumber_2 = value;
                OnPropertyChanged();
            }
        }
        private int _horseNumber_3 = 0;
        public int HorseNumber_3
        {
            get
            {
                return _horseNumber_3;
            }
            set
            {
                _horseNumber_3 = value;
                OnPropertyChanged();
            }
        }
        private int _horseNumber_4 = 0;
        public int HorseNumber_4
        {
            get
            {
                return _horseNumber_4;
            }
            set
            {
                _horseNumber_4 = value;
                OnPropertyChanged();
            }
        }
        private int _horseNumber_5 = 0;
        public int HorseNumber_5
        {
            get
            {
                return _horseNumber_5;
            }
            set
            {
                _horseNumber_5 = value;
                OnPropertyChanged();
            }
        }



        //確定 審議 写真
        //同着 ハナ ｱﾀﾏ クビ 大差
        //½ ¼ ¾ ⅛

        /*  Dispaly_HorseLength_1_2.Text = "クビ";
          Dispaly_HorseLength_2_3.Text = "ｱﾀﾏ";
          Dispaly_HorseLength_3_4.Text = "4";
          Dispaly_HorseLength_4_5.Text = "3";

          Dispaly_RecordTime.Visibility = Visibility.Hidden;
          Dispaly_RoadStatus_Grass.Text = "良";
          Dispaly_RoadStatus_Dirt.Text = "良";

          Dispaly_Timer_Minute.Text ="1";
          Dispaly_Timer_Second.Text = "24";
          Dispaly_Timer_Decile.Text = "1";

          Dispaly_Timer_Four_Furlong.Text = "34";
          Dispaly_Timer_Four_Furlong_Decile.Text = "3";

          Dispaly_Timer_Three_Furlong.Text = "24";
          Dispaly_Timer_Three_Furlong_Decile.Text = "2";*/
















    }
}
