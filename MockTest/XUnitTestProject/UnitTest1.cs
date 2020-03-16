using MockTest;
using Moq;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void FirstMock()
        {
            //Calcクラスのモックを作成
            var mock = new Mock<ICalc>();

            //Addメソッドが1と2で呼ばれたら「3」を返す設定
            mock.Setup(m => m.Add(1, 2)).Returns(3);
            //Addメソッドが2と3で呼ばれたら「5」を返す設定
            mock.Setup(m => m.Add(2, 3)).Returns(5);
            
            CalcViewModel cvm = new CalcViewModel(mock.Object);

            Assert.Equal(3, cvm.DoCalculation(1, 2));

            //モックの振る舞いが呼び出されたかを確認
            //mock.VerifyAll();
        }
    }
}
