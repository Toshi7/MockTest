using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestMethod()]
        public void FirstMock()
        {
            //Calc�N���X�̃��b�N���쐬
            Mock<Calc> mock = new Mock<Calc>();

            //Add���\�b�h��1��2�ŌĂ΂ꂽ��u3�v��Ԃ��ݒ�
            mock.Setup(m => m.Add(1, 2)).Returns(3);
            //Add���\�b�h��2��3�ŌĂ΂ꂽ��u5�v��Ԃ��ݒ�
            mock.Setup(m => m.Add(2, 3)).Returns(5);

            //���b�N���������������m�F
            Calc c = mock.Object;
            Assert.AreEqual(3, c.Add(1, 2));
            Assert.AreEqual(5, c.Add(2, 3));
            //�ݒ肵�Ă��Ȃ��ꍇ��0
            Assert.AreEqual(0, c.Add(3, 4));
        }
}