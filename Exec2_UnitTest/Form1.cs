using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_UnitTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			/*判斷某一DateTime 是否在股票交易營業日以及時間
			class TaiwainStockUtility
			bool IsTradingTime(DateTime dt)
			日期必需在星期一 ~星期五
			時間必需介於9:00 ~ 13:30*/


			string input = TextBoxIn.Text;


			bool verified = DateTime.TryParse(input, out DateTime result);

			if (verified == false || string.IsNullOrEmpty(input) == true)
			{
				MessageBox.Show("請輸入正確的時間格式:年,月,日 時:分:秒");
				return;
			}
			TaiwanStockuUtility tw = new TaiwanStockuUtility();
			

			verified = tw.IsTradingTime(result);


			if (verified == true)
			{
				MessageBox.Show("在台股營業時間內");
			}
			else
			{
				MessageBox.Show("不在台股營業時間內");
			} 
		}


		public class TaiwanStockuUtility
		{
			public bool IsTradingTime(DateTime dt)
			{
				DateTime tradeBegin = new DateTime(2022, 10, 31, 09, 00, 00);
				DateTime tradeEnd = new DateTime(2022, 11, 04, 13, 30, 00);
				bool verified;

				if (dt.DayOfWeek >= tradeBegin.DayOfWeek && dt.DayOfWeek <= tradeEnd.DayOfWeek)
				{
					if (dt.Hour >= tradeBegin.Hour && dt.Hour <= tradeEnd.Hour)
					{
						verified = true;
						return true;
					}
					else
					{
						verified = false;
						return false;
					}

				}
				else
				{
					verified = false;
					return false;
				}

			if (verified == true && dt.Hour != 13)
					{
					verified= true;
					}

			if (dt.Hour == 13 && dt.Minute <= 30)
				{
					return true;
				}
				
				{
					return false;
				}
			}
		}
	}
	
}		
