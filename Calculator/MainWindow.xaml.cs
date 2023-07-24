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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		private float num1, Ans;
		private int count;

		public MainWindow()
        {
            InitializeComponent();
        }

		//Method Clear
		void Clear()
		{
			Txt_View.Text = " ";
		}


		//Buttons numbers
		private void Btn_One_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 1;
		}

		private void Btn_Two_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 2;
		}

		private void Btn_Three_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 3;
		}

		private void Btn_Four_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 4;
		}

		private void Btn_Five_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 5;
		}

		private void Btn_Six_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 6;

		}

		private void Btn_Seven_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 7;
		}

		private void Btn_Eight_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 8;
		}

		private void Btn_Nine_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 9;
		}

		private void Btn_Zero_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + 0;
		}

		//clear button
		private void Btn_Clear_Click(object sender, RoutedEventArgs e)
		{
			Clear();
		}



		//Operations
		private void Btn_plus_Click(object sender, RoutedEventArgs e)
		{
			num1 = float.Parse(Txt_View.Text);
			Txt_View.Clear();
			Txt_View.Focus();
			count = 2;
		}

		private void Btn_Minus_Click(object sender, RoutedEventArgs e)
		{
			if (Txt_View.Text != " ")
			{
				num1 = float.Parse(Txt_View.Text);
				Txt_View.Clear();
				Txt_View.Focus();
				count = 1;
			}
		}

		private void Btn_divide_Click(object sender, RoutedEventArgs e)
		{
			num1 = float.Parse(Txt_View.Text);
			Txt_View.Clear();
			Txt_View.Focus();
			count = 4;
		}

		private void Btn_Multiply_Click(object sender, RoutedEventArgs e)
		{
			num1 = float.Parse(Txt_View.Text);
			Txt_View.Clear();
			Txt_View.Focus();
			count = 3;
		}

		private void Btn_Equal_Click(object sender, RoutedEventArgs e)
		{
			compute(count);
		}
		void compute(int count)
		{
			switch (count)
			{
				case 1:
					Ans = num1 - float.Parse(Txt_View.Text);
					Txt_View.Text = Ans.ToString();
					break;
				case 2:
					Ans = num1 + float.Parse(Txt_View.Text);
					Txt_View.Text = Ans.ToString();
					break;
				case 3:
					Ans = num1 / float.Parse(Txt_View.Text);
					Txt_View.Text = Ans.ToString();
					break;
				case 4:
					Ans = num1 * float.Parse(Txt_View.Text);
					Txt_View.Text = Ans.ToString();
					break;

				default:

					break;
			}
		}

		private void Btn_Dot_Click(object sender, RoutedEventArgs e)
		{
			Txt_View.Text = Txt_View.Text + ".";
		}
	}
}
