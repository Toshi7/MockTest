using Moq;
using System;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void FirstMock()
        {
            //Calcクラスのモックを作成
            Mock<Calc> mock = new Mock<Calc>();

            //Addメソッドが1と2で呼ばれたら「3」を返す設定
            mock.Setup(m => m.Add(1, 2)).Returns(3);
            //Addメソッドが2と3で呼ばれたら「5」を返す設定
            mock.Setup(m => m.Add(2, 3)).Returns(5);

            //モックが正しく動くか確認
            Calc c = mock.Object;
            Assert.AreEqual(3, c.Add(1, 2));
            Assert.AreEqual(5, c.Add(2, 3));
            //設定していない場合は0
            Assert.AreEqual(0, c.Add(3, 4));

            //モックの振る舞いが呼び出されたかを確認
            mock.VerifyAll();
        }
    }
}
