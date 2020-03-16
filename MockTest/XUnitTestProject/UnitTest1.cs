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
            //Calc�N���X�̃��b�N���쐬
            var mock = new Mock<ICalc>();

            //Add���\�b�h��1��2�ŌĂ΂ꂽ��u3�v��Ԃ��ݒ�
            mock.Setup(m => m.Add(1, 2)).Returns(3);
            //Add���\�b�h��2��3�ŌĂ΂ꂽ��u5�v��Ԃ��ݒ�
            mock.Setup(m => m.Add(2, 3)).Returns(5);
            
            CalcViewModel cvm = new CalcViewModel(mock.Object);

            Assert.Equal(3, cvm.DoCalculation(1, 2));

            //���b�N�̐U�镑�����Ăяo���ꂽ�����m�F
            //mock.VerifyAll();
        }
    }
}
