using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryFilter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateDictionary() 
        {

            // load and split by newline - trim again later to remove the \r
            string[] bigdictionary = System.IO.File.ReadAllText(txtInputFile.Text).Split('\n');

            // load and cache lowered front filter
            string frontFilterLower = txtFrontFilter.Text.ToLower();

            // load any length filters
            int lengthFilter = -1;
            if (txtLimitLength.Text.Length != 0) 
            {
                lengthFilter = int.Parse(txtLimitLength.Text);
            }

            // load charset
            char[] charset = txtCharset.Text.ToCharArray();

            List<string> filteredList = new List<string>();

            // NOTE: filtering should ideally be done in ascending order of processing time

            foreach (string word in bigdictionary) 
            {
                string tidyWord = word.Trim();
                
                // ignore blank lines
                if (tidyWord.Length == 0) 
                { 
                    continue;
                }

                // ignore mismatched lengths if user sets so
                if (lengthFilter != -1) 
                {
                    if (tidyWord.Length != lengthFilter) 
                    {
                        continue;
                    }
                }

                // apply front filter if user sets so
                if (frontFilterLower.Length != 0) 
                {
                    if (Head(tidyWord, frontFilterLower.Length).ToLower() != frontFilterLower)
                    {
                        continue;
                    }
                }

                // check if word matches charset
                if (!StringIsWithinCharset(tidyWord, charset)) 
                {
                    continue;
                }

                
                filteredList.Add(tidyWord);
            }


            // generate the output
            List<string> outputFormattingList = new List<string>();

            foreach (string word in filteredList) 
            {
                if (cbOriginal.Checked) 
                {
                    outputFormattingList.Add(word);
                }

                if (cbUppercase.Checked)
                {
                    outputFormattingList.Add(word.ToUpper());
                }

                if (cbLowercase.Checked)
                {
                    outputFormattingList.Add(word.ToLower());
                }

                if (cbProperCase.Checked)
                {
                    outputFormattingList.Add(
                        Head(word.ToUpper()) + 
                        Tail(word.ToLower())
                    );
                }

            }

            // make unique if need
            if (cbUnique.Checked)
            {
                List<string> finalList = new List<string>();
                finalList = outputFormattingList.Select(word => word).Distinct().ToList();
                SaveListOfStringToWordlist(finalList, txtOutputFile.Text);
            }
            else 
            {
                SaveListOfStringToWordlist(outputFormattingList, txtOutputFile.Text);
            }
            

        }


        #region "String manipulation methods"

        // head/tail/init/last -> see http://learnyouahaskell.com/starting-out
        static string Head(string theWord, int headLength = 1) 
        {
            if (theWord.Length > headLength) 
            {
                return theWord.Remove(headLength);
            }
            return theWord;
        }

        static string Tail(string theWord, int headLength = 1) 
        {
            if (theWord.Length > headLength)
            {
                return theWord.Remove(0, headLength);
            }
            return "";
        }

        static void SaveListOfStringToWordlist(List<string> theWordlist, string path) 
        {
            StringBuilder sb = new StringBuilder();
            foreach (string word in theWordlist) 
            {
                sb.AppendLine(word);
            }
            System.IO.File.WriteAllText(path, sb.ToString());
        }

        private static bool StringIsWithinCharset(String str, char[] charset)
        {
            bool canPass = true;
            char[] charArray = str.ToCharArray();
            foreach (char c in charArray)
            {
                if (!ContainsValidChar(c, charset))
                {
                    canPass = false;
                }
            }

            return canPass;
        }

        private static bool ContainsValidChar(char theChar, char[] charset)
        {
            foreach (char c in charset)
            {
                if (theChar == c)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void btnSetInputFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()) 
            {
                if (ofd.ShowDialog() == DialogResult.OK) 
                {
                    txtInputFile.Text = ofd.FileName;
                }
            }
        }

        private void btnSetOutputFile_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog()) 
            {
                if (sfd.ShowDialog() == DialogResult.OK) 
                {
                    txtOutputFile.Text = sfd.FileName;
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            GenerateDictionary();
            MessageBox.Show("Completed!");
        }
    }
}
