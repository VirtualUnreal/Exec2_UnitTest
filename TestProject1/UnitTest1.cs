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
		/// ���դ���P�w�O�_���T�^�ǥ��L��
		/// </summary>
		[Test]
		public void TaiwanStockuUtility()
		{
			var obj = new TaiwanStockUtility();

			Assert.Pass();
		}
	}
}