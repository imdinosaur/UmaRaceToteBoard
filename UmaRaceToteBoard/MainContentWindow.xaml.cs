using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace UmaRaceToteBoard
{
    /// <summary>
    /// MainContentWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainContentWindow : Window
    {

        static readonly Brush UmaRedBrush = Application.Current.FindResource("UmaRedBrush") as SolidColorBrush;
        static readonly Brush UmaBlueBrush = Application.Current.FindResource("UmaBlueBrush") as SolidColorBrush;
        static readonly Brush UmaGrayBrush = Application.Current.FindResource("UmaGrayBrush") as SolidColorBrush;


        //#1F1F1F->#595151

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch { }
        }

        public void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//偵測視窗有沒有被關掉
        {
            //Application.Current.StartupUri
            Application.Current.Shutdown();
        }

        public MainContentWindow()
        {
            InitializeComponent();



            //各種參數設定
            Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
            {
                /*Dispaly_LocationName_F.Text = "箱";
                Dispaly_LocationName_S.Text = "車";


                Display_RaceRound.Text = "1";

                Dispaly_Rank_1st_Ten.Text = "";
                Dispaly_Rank_1st_Digits.Text = "1";

                Dispaly_Rank_2nd_Ten.Text = "1";
                Dispaly_Rank_2nd_Digits.Text = "1";

                Dispaly_Rank_3rd_Ten.Text = "";
                Dispaly_Rank_3rd_Digits.Text = "2";

                Dispaly_Rank_4th_Ten.Text = "";
                Dispaly_Rank_4th_Digits.Text = "6";

                Dispaly_Rank_5th_Ten.Text = "";
                Dispaly_Rank_5th_Digits.Text = "7";*/

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

                //Display_RankStatusText.Text = "審議";




                //Display_RankStatusCard.Background = Brushes.Red;
                //Display_RankStatusCard.Background = (Brush)new BrushConverter().ConvertFrom("#595151");
                //Display_RankStatusCard.Background = UmaBlueBrush;

            }));










        }
    }
}
