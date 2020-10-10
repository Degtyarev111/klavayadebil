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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int colorful_keys = 0;
        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            colorful_keys = 1;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            colorful_keys = 0;
        }
        public Brush brush;
        void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (colorful_keys == 1) { 
            string key = e.Key.ToString();
                switch (key)
                {
                    case "Oem3":
                        brush = Border_tilda.Background;
                        Border_tilda.Background = Brushes.White;
                        break;
                    case "D1":
                        brush = Border_1.Background;
                        Border_1.Background = Brushes.White;
                        break;
                    case "D2":
                        brush = Border_2.Background;
                        Border_2.Background = Brushes.White;
                        break;
                    case "D3":
                        brush = Border_3.Background;
                        Border_3.Background = Brushes.White;
                        break;
                    case "D4":
                        brush = Border_4.Background;
                        Border_4.Background = Brushes.White;
                        break;
                    case "D5":
                        brush = Border_5.Background;
                        Border_5.Background = Brushes.White;
                        break;
                    case "D6":
                        brush = Border_6.Background;
                        Border_6.Background = Brushes.White;
                        break;
                    case "D7":
                        brush = Border_7.Background;
                        Border_7.Background = Brushes.White;
                        break;
                    case "D8":
                        brush = Border_8.Background;
                        Border_8.Background = Brushes.White;
                        break;
                    case "D9":
                        brush = Border_9.Background;
                        Border_9.Background = Brushes.White;
                        break;
                    case "D0":
                        brush = Border_0.Background;
                        Border_0.Background = Brushes.White;
                        break;
                    case "OemMinus":
                        brush = Border_minus.Background;
                        Border_minus.Background = Brushes.White;
                        break;
                    case "OemPlus":
                        brush = Border_equals.Background;
                        Border_equals.Background = Brushes.White;
                        break;
                    case "Q":
                        brush = Border_q.Background;
                        Border_q.Background = Brushes.White;
                        break;
                    case "W":
                        brush = Border_w.Background;
                        Border_w.Background = Brushes.White;
                        break;
                    case "E":
                        brush = Border_e.Background;
                        Border_e.Background = Brushes.White;
                        break;
                    case "R":
                        brush = Border_r.Background;
                        Border_r.Background = Brushes.White;
                        break;
                    case "T":
                        brush = Border_t.Background;
                        Border_t.Background = Brushes.White;
                        break;
                    case "Y":
                        brush = Border_y.Background;
                        Border_y.Background = Brushes.White;
                        break;
                    case "U":
                        brush = Border_u.Background;
                        Border_u.Background = Brushes.White;
                        break;
                    case "I":
                        brush = Border_i.Background;
                        Border_i.Background = Brushes.White;
                        break;
                    case "O":
                        brush = Border_o.Background;
                        Border_o.Background = Brushes.White;
                        break;
                    case "P":
                        brush = Border_p.Background;
                        Border_p.Background = Brushes.White;
                        break;
                    case "OemOpenBrackets":
                        brush = Border_open.Background;
                        Border_open.Background = Brushes.White;
                        break;
                    case "Oem6":
                        brush = Border_close.Background;
                        Border_close.Background = Brushes.White;
                        break;
                    case "Oem5":
                        brush = Border_reverseslash.Background;
                        Border_reverseslash.Background = Brushes.White;
                        break;
                    case "A":
                        brush = Border_a.Background;
                        Border_a.Background = Brushes.White;
                        break;
                    case "S":
                        brush = Border_s.Background;
                        Border_s.Background = Brushes.White;
                        break;
                    case "D":
                        brush = Border_d.Background;
                        Border_d.Background = Brushes.White;
                        break;
                    case "F":
                        brush = Border_f.Background;
                        Border_f.Background = Brushes.White;
                        break;
                    case "G":
                        brush = Border_g.Background;
                        Border_g.Background = Brushes.White;
                        break;
                    case "H":
                        brush = Border_h.Background;
                        Border_h.Background = Brushes.White;
                        break;
                    case "J":
                        brush = Border_j.Background;
                        Border_j.Background = Brushes.White;
                        break;
                    case "K":
                        brush = Border_k.Background;
                        Border_k.Background = Brushes.White;
                        break;
                    case "L":
                        brush = Border_l.Background;
                        Border_l.Background = Brushes.White;
                        break;
                    case "Oem1":
                        brush = Border_dotcomma.Background;
                        Border_dotcomma.Background = Brushes.White;
                        break;
                    case "OemQuotes":
                        brush = Border_char.Background;
                        Border_char.Background = Brushes.White;
                        break;
                    case "Z":
                        brush = Border_z.Background;
                        Border_z.Background = Brushes.White;
                        break;
                    case "X":
                        brush = Border_x.Background;
                        Border_x.Background = Brushes.White;
                        break;
                    case "C":
                        brush = Border_c.Background;
                        Border_c.Background = Brushes.White;
                        break;
                    case "V":
                        brush = Border_v.Background;
                        Border_v.Background = Brushes.White;
                        break;
                    case "B":
                        brush = Border_b.Background;
                        Border_b.Background = Brushes.White;
                        break;
                    case "N":
                        brush = Border_n.Background;
                        Border_n.Background = Brushes.White;
                        break;
                    case "M":
                        brush = Border_m.Background;
                        Border_m.Background = Brushes.White;
                        break;
                    case "OemComma":
                        brush = Border_comma.Background;
                        Border_comma.Background = Brushes.White;
                        break;
                    case "OemPeriod":
                        brush = Border_dot.Background;
                        Border_dot.Background = Brushes.White;
                        break;
                    case "OemQuestion":
                        brush = Border_slash.Background;
                        Border_slash.Background = Brushes.White;
                        break;
                }
            }
        }
        void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (colorful_keys == 1) { 
            string key = e.Key.ToString();
                switch (key)
                {
                    case "Oem3":
                        Border_tilda.Background = brush;
                        break;
                    case "D1":
                        Border_1.Background = brush;
                        break;
                    case "D2":
                        Border_2.Background = brush;
                        break;
                    case "D3":
                        Border_3.Background = brush;
                        break;
                    case "D4":
                        Border_4.Background = brush;
                        break;
                    case "D5":
                        Border_5.Background = brush;
                        break;
                    case "D6":
                        Border_6.Background = brush;
                        break;
                    case "D7":
                        Border_7.Background = brush;
                        break;
                    case "D8":
                        Border_8.Background = brush;
                        break;
                    case "D9":
                        Border_9.Background = brush;
                        break;
                    case "D0":
                        Border_0.Background = brush;
                        break;
                    case "OemMinus":
                        Border_minus.Background = brush;
                        break;
                    case "OemPlus":
                        Border_equals.Background = brush;
                        break;
                    case "Q":
                        Border_q.Background = brush;
                        break;
                    case "W":
                        Border_w.Background = brush;
                        break;
                    case "E":
                        Border_e.Background = brush;
                        break;
                    case "R":
                        Border_r.Background = brush;
                        break;
                    case "T":
                        Border_t.Background = brush;
                        break;
                    case "Y":
                        Border_y.Background = brush;
                        break;
                    case "U":
                        Border_u.Background = brush;
                        break;
                    case "I":
                        Border_i.Background = brush;
                        break;
                    case "O":
                        Border_o.Background = brush;
                        break;
                    case "P":
                        Border_p.Background = brush;
                        break;
                    case "OemOpenBrackets":
                        Border_open.Background = brush;
                        break;
                    case "Oem6":
                        Border_close.Background = brush;
                        break;
                    case "Oem5":
                        Border_reverseslash.Background = brush;
                        break;
                    case "A":
                        Border_a.Background = brush;
                        break;
                    case "S":
                        Border_s.Background = brush;
                        break;
                    case "D":
                        Border_d.Background = brush;
                        break;
                    case "F":
                        Border_f.Background = brush;
                        break;
                    case "G":
                        Border_g.Background = brush;
                        break;
                    case "H":
                        Border_h.Background = brush;
                        break;
                    case "J":
                        Border_j.Background = brush;
                        break;
                    case "K":
                        Border_k.Background = brush;
                        break;
                    case "L":
                        Border_l.Background = brush;
                        break;
                    case "Oem1":
                        Border_dotcomma.Background = brush;
                        break;
                    case "OemQuotes":
                        Border_char.Background = brush;
                        break;
                    case "Z":
                        Border_z.Background = brush;
                        break;
                    case "X":
                        Border_x.Background = brush;
                        break;
                    case "C":
                        Border_c.Background = brush;
                        break;
                    case "V":
                        Border_v.Background = brush;
                        break;
                    case "B":
                        Border_b.Background = brush;
                        break;
                    case "N":
                        Border_n.Background = brush;
                        break;
                    case "M":
                        Border_m.Background = brush;
                        break;
                    case "OemComma":
                        Border_comma.Background = brush;
                        break;
                    case "OemPeriod":
                        Border_dot.Background = brush;
                        break;
                    case "OemQuestion":
                        Border_slash.Background = brush;
                        break;
                }
            }
        }
    }
}
