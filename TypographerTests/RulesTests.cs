using System.Windows.Forms;
using Typographer;

namespace TypographerTests
{
    [TestClass]
    public class RulesTests
    {

        [TestMethod]
        public void RemoveExtraSpaces_Test()
        {
            // Arrange
            string inputText = "���      ����.";

            // Act
            string result = TypographerForm.RemoveExtraSpaces(inputText);

            // Assert
            Assert.AreEqual("��� ����.", result);
        }

        [TestMethod]
        public void MergedHyphen_Test()
        {
            // Arrange
            string inputText = "��� - ������ - ����";

            // Act
            string result = TypographerForm.MergedHyphen(inputText);

            // Assert
            Assert.AreEqual("���-������-����", result);
        }

        [TestMethod]
        public void PlusMinus_Test()
        {
            // Arrange
            string inputText = "2 +- 3";

            // Act
            string result = TypographerForm.PlusMinus(inputText);

            // Assert
            Assert.AreEqual("2 �  3", result);
        }

        [TestMethod]
        public void UnitsOfMeasurement_Test()
        {
            // Arrange
            string inputText = "5.7 � 3.2 ��";

            // Act
            string result = TypographerForm.UnitsOfMeasurement(inputText);

            // Assert
            Assert.AreEqual("(5.7 � 3.2) ��", result);
        }

        [TestMethod]
        public void Ellipsis_Test()
        {
            // Arrange
            string inputText = "��� ������ ����...";

            // Act
            string result = TypographerForm.Ellipsis(inputText);

            // Assert
            Assert.AreEqual("��� ������ ����", result);
        }
        
        [TestMethod]
        public void TestApplyHyphenationRules()
        {
            // Arrange
            string inputText = "��� �� ��� ������ ����� ������";

            // Act
            string result = TypographerForm.ApplyHyphenationRules(inputText);

            // Assert
            Assert.AreEqual("���-�� ���-������ �����-������", result);
        }

        [TestMethod]
        public void TestAbsurdRule()
        {
            // Arrange
            string inputText = "��� ����?";
            string expected = "��� ����?!";

            // Act
            string result = TypographerForm.AbsurdRule(inputText);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestEditTextButton_Click()
        {
            // Arrange
            TypographerForm form = new TypographerForm();
            form.inputTextbox.Text = "Test";

            // Act
            form.EditTextButton_Click(null, null);

            // Assert
            Assert.AreEqual("Test", form.outputTextbox.Text);
        }

        [TestMethod]
        public void TestClearButton_Click()
        {
            // Arrange
            TypographerForm form = new TypographerForm();
            form.inputTextbox.Text = "Test";
            form.outputTextbox.Text = "Test";

            // Act
            form.ClearButton_Click(null, null);

            // Assert
            Assert.AreEqual(string.Empty, form.inputTextbox.Text);
            Assert.AreEqual(string.Empty, form.outputTextbox.Text);
        }
    }
}