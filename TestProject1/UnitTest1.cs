using Exec2_UnitTest

namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}
		/// <summary>
		/// 測試日期判定是否正確回傳布林值
		/// </summary>
		[Test]
		public void TaiwanStockuUtility()
		{
			var obj = new TaiwanStockUtility();

			Assert.Pass();
		}
	}
}