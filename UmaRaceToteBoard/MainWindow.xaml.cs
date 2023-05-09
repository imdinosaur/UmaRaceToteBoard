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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UmaRaceToteBoard
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //程式進入點
            MainContentWindow MonitorMainWINDOW = new MainContentWindow();
            //呼叫主頁面
            MonitorMainWINDOW.Show();
            this.Hide();

            //隱藏命令列
            ConsoleControll.Hide();

        }
    }
    public class ConsoleControll
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        protected static bool ConsoleExisted = true;
        public static bool HasConsole
        {
            get
            {
                return ConsoleExisted;
            }
        }

        public static void Show()
        {
            var Handle = GetConsoleWindow();
            ShowWindow(Handle, SW_SHOW);
            ConsoleExisted = true;
        }

        public static void Hide()
        {
            var Handle = GetConsoleWindow();
            ShowWindow(Handle, SW_HIDE);
            ConsoleExisted = false;
        }


    }



}
