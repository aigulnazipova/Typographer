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
            string inputText = "Это      тест.";

            // Act
            string result = TypographerForm.RemoveExtraSpaces(inputText);

            // Assert
            Assert.AreEqual("Это тест.", result);
        }

        [TestMethod]
        public void MergedHyphen_Test()
        {
            // Arrange
            string inputText = "Это - второй - тест";

            // Act
            string result = TypographerForm.MergedHyphen(inputText);

            // Assert
            Assert.AreEqual("Это-второй-тест", result);
        }

        [TestMethod]
        public void PlusMinus_Test()
        {
            // Arrange
            string inputText = "2 +- 3";

            // Act
            string result = TypographerForm.PlusMinus(inputText);

            // Assert
            Assert.AreEqual("2 ±  3", result);
        }

        [TestMethod]
        public void UnitsOfMeasurement_Test()
        {
            // Arrange
            string inputText = "5.7 ± 3.2 см";

            // Act
            string result = TypographerForm.UnitsOfMeasurement(inputText);

            // Assert
            Assert.AreEqual("(5.7 ± 3.2) см", result);
        }

        [TestMethod]
        public void Ellipsis_Test()
        {
            // Arrange
            string inputText = "Это третий тест...";

            // Act
            string result = TypographerForm.Ellipsis(inputText);

            // Assert
            Assert.AreEqual("Это третий тест…", result);
        }
        
        [TestMethod]
        public void TestApplyHyphenationRules()
        {
            // Arrange
            string inputText = "Где то кто нибудь зачем нибудь";

            // Act
            string result = TypographerForm.ApplyHyphenationRules(inputText);

            // Assert
            Assert.AreEqual("Где-то кто-нибудь зачем-нибудь", result);
        }

        [TestMethod]
        public void TestAbsurdRule()
        {
            // Arrange
            string inputText = "Как дела?";
            string expected = "Как дела?!";

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