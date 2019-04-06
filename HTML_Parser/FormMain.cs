using HTML_Parser.core;
using HTML_Parser.core.avito;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HTML_Parser
{
    public partial class FormMain : Form
    {
        ParserWorker<string[]> parser;

        public FormMain()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new AvitoParser());

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            List<string> lst = new List<string>(arg2.Length);
            foreach (var item in arg2)
                lst.Add("https://www.avito.ru" + item);
            
            var arg = lst.ToArray();
            ListTitles.Items.AddRange(arg);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All work done");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ListTitles.Items.Clear();
            parser.ParserSettings = new AvitoParserSettings((int)NumericStart.Value, (int)NumericEnd.Value,
                                                            lowercost.Text, uppercost.Text);
            parser?.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void ListTitles_MouseClick(object sender, MouseEventArgs e)
        {
            string line = "";
            int count = ListTitles.SelectedIndices.Count;
            for (int i = 0; i < count; i++)
            {
                line = line + ListTitles.SelectedItems[i].ToString() + "\n";
                Clipboard.SetText(line);
            }
        }
    }
}
