using Word = Microsoft.Office.Interop.Word;
namespace LR26
{
    public partial class Form1 : Form
    {
        string fn = "D:\\Games\\c++\\LR26\\LR26\\Довідка про навчання.dotx";
        Word.Application word = new Word.Application();
        Word.Document doc = new Word.Document();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object missingobj = System.Reflection.Missing.Value;
            Object trueObj = true;
            Object falseObj = false;
            Object templatePathObj = fn;
            doc = word.Documents.Add(ref templatePathObj, ref missingobj, ref missingobj, ref missingobj);
            doc.Activate();
            foreach( Word.FormField f in doc.FormFields)
            {
                switch (f.Name)
                {
                    case "fio":
                        f.Range.Text = "\t" + fioBox.Text + "\t";
                        break;
                    case "uni":
                        f.Range.Text = "\t" + uniBox.Text + "\t";
                        break;
                    case "course":
                        f.Range.Text = courseBox.Text;
                        break;
                    case "principal":
                        f.Range.Text = principalBox.Text;
                        break;
                    default:
                        break;

                }
            }
            word.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            doc.Close();
            word.Quit();
            doc = null;
            word = null;
        }
    }
}