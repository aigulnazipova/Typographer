using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Typographer
{
    public partial class TypographerForm : Form
    {
        public TypographerForm()
        {
            InitializeComponent();
            inputTextbox.Focus();
        }

        public void copyButton_Click(object sender, EventArgs e)
        {
            if (outputTextbox.SelectionLength > 0)
            {
                Clipboard.SetText(outputTextbox.SelectedText);
            }
            else
            {
                Clipboard.SetText(outputTextbox.Text);
            }
        }

        public void EditTextButton_Click(object sender, EventArgs e)
        {
            string text = inputTextbox.Text;
            text = TypographerForm.RunAllMethods(text);

            outputTextbox.Text = text;

            copyButton.Visible = true;
        }
        public void ClearButton_Click(object sender, EventArgs e)
        {
            inputTextbox.Text = string.Empty;
            outputTextbox.Text = string.Empty;
        }

        /// <summary>
        /// Два и более пробела заменяются, остается только один пробел (нельзя писать подряд более одного пробела).
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по правилу, описанным в этом методе.</param>
        public static string RemoveExtraSpaces(string inputText)
        {
            string result = Regex.Replace(inputText, @"\s+", " ");
            return result;
        }

        /// <summary>
        /// Дефис пробелами не отбивается и всегда пишется слитно с частями слова или цифр, которые он разделяет.
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по правилу, описанным в этом методе.</param>
        public static string MergedHyphen(string inputText)
        {
            string result = Regex.Replace(inputText, @"\s*-\s*", "-");
            return result;
        }

        /// <summary>
        /// Символ «плюс-минус» задаётся так: ±.
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по правилу, описанным в этом методе.</param>
        public static string PlusMinus(string inputText)
        {
            string result = inputText.Replace("+-", "± ");
            return result;
        }

        /// <summary>
        /// Если пишется некое значение, а затем от него плюс-минус и единица измерения, то все числовые значения 
        /// относительно единицы измерения заносятся в скобки.
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по правилу, описанным в этом методе.</param>
        public static string UnitsOfMeasurement(string inputText)
        {
            string result = Regex.Replace(inputText, @"(\d+(?:[.,]\d+)?)\s*±\s*(\d+(?:[.,]\d+)?)\s*(\w+)", "($1 ± $2) $3");
            return result;
        }

        /// <summary>
        /// Везде где имеется троеточие, его следует писать не тремя точками, а знаком … 
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по правилу, описанным в этом методе.</param>
        public static string Ellipsis(string inputText)
        {
            Regex regexThreeDots = new Regex(@"\.{3}", RegexOptions.Compiled);
            string threeDotsReplacement = "…";
            inputText = regexThreeDots.Replace(inputText, threeDotsReplacement);
            return inputText;
        }

        /// <summary>
        /// Расстановка дефисов в обезличенных местоимениях и междометиях (напр.: кто то → кто-то, где то → где-то и так далее). 
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по правилу, описанным в этом методе.</param>
        public static string ApplyHyphenationRules(string inputText)
        {
            Dictionary<string, string> rules = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        {"кто то", "кто-то"}, {"что то", "что-то"}, {"где то", "где-то"}, {"когда то", "когда-то"},
        {"откуда то", "откуда-то"}, {"куда то", "куда-то"}, {"зачем то", "зачем-то"}, {"почему то", "почему-то"},
        {"кто нибудь", "кто-нибудь"}, {"что нибудь", "что-нибудь"}, {"где нибудь", "где-нибудь"},
        {"когда нибудь", "когда-нибудь"}, {"откуда нибудь", "откуда-нибудь"}, {"куда нибудь", "куда-нибудь"},
        {"зачем нибудь", "зачем-нибудь"}, {"почему нибудь", "почему-нибудь"}
    };

            foreach (var rule in rules)
            {
                string pattern = "\\b" + Regex.Escape(rule.Key) + "\\b";
                inputText = Regex.Replace(inputText, pattern, match =>
                {
                    string matchedText = match.Value;
                    if (char.IsUpper(matchedText[0]))
                    {
                        string hyphenated = rule.Value;
                        return char.ToUpper(hyphenated[0]) + hyphenated.Substring(1);
                    }
                    else
                    {
                        return rule.Value;
                    }
                }, RegexOptions.IgnoreCase);
            }

            return inputText;
        }
        /// <summary>
        /// Абсурдное правило: типограф заменяет символ «?» на «?!». 
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по всем правилам, описанным в этом приложении.</param>
        public static string AbsurdRule(string inputText)
        {
            return inputText.Replace("?", "?!");
        }

        /// <summary>
        /// Выполняет все правила типографа. 
        /// </summary>
        /// <param name="inputText">Текст, который будет отредактирован по всем правилам, описанным в этом приложении.</param>
        public static string RunAllMethods(string text)
        {
            text = RemoveExtraSpaces(text);
            text = MergedHyphen(text);
            text = PlusMinus(text);
            text = UnitsOfMeasurement(text);
            text = Ellipsis(text);
            text = ApplyHyphenationRules(text);
            text = AbsurdRule(text);

            return text;
        }

        
    }
}
