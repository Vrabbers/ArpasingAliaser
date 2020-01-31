using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArpasingAliaser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dictionaryFileBrowseButton_Click(object sender, EventArgs e)
        {
            var result = dictionaryFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                dictionaryFileTextBox.Text = dictionaryFileDialog.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = otoFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                otoFileTextBox.Text = otoFileDialog.FileName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(otoFileTextBox.Text))
            {
                MessageBox.Show("Voice configuration file doesn't exist", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(dictionaryFileTextBox.Text))
            {
                MessageBox.Show("Dictionary file doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            button1.Enabled = false;
            button1.Text = "Making backup of oto file...";
            File.Copy(otoFileTextBox.Text, otoFileTextBox.Text + ".backup", true);
            
            //oto file is read as Shift-JIS (CP 932). the dictionary file is read as UTF-8
            button1.Text = "Reading Files...";
            var dicLines = File.ReadAllLines(dictionaryFileTextBox.Text, Encoding.UTF8);
            var otoLines = File.ReadAllLines(otoFileTextBox.Text, Encoding.GetEncoding(932));

            button1.Text = "Parsing Dictionary";
            var dictionary = new Dictionary<string, string>();
            for (var i = 0; i < dicLines.Length; i++)
            {
                var l = dicLines[i].Trim();
                if (l.StartsWith("#")) continue;
                var s = l.Split(' ');
                if (s.Length != 2)
                {
                    MessageBox.Show($"Invalid dictionary entry in line {i + 1}: {l}\nAborting", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    button1.Enabled = true;
                    button1.Text = "Alias";
                    return;
                }

                if (dictionary.ContainsKey(s[0]) || dictionary.ContainsValue(s[1]))
                {
                    MessageBox.Show($"Duplicate value in line {i + 1}: {l}\nAborting", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    button1.Enabled = true;
                    button1.Text = "Alias";
                    return;
                }
                dictionary.Add(s[0], s[1]);
                
            }
            
            button1.Text = "Parsing oto ...";
            var oldOtoEntries = new List<OtoEntry>();
            oldOtoEntries = otoLines.Select(s => new OtoEntry(s)).ToList();
            var newOtoEntries = new List<OtoEntry>();
            for (var i = 0; i < oldOtoEntries.Count; i++)
            {
                var o = oldOtoEntries[i];
                button1.Text = $"Aliasing {o.Alias} ({i + 1}/{oldOtoEntries.Count})...";
                var repeatedNumber = "";
                var aliasUnNumbered = o.Alias;
                if (char.IsDigit(o.Alias.Last()))
                {
                    var n = o.Alias.IndexOf(o.Alias.First(char.IsDigit));
                    aliasUnNumbered = o.Alias.Substring(0, n);
                    repeatedNumber = " " + o.Alias.Substring(n);
                }
                
                var newAlias = "";
                foreach (var oldPhon in aliasUnNumbered.Split(' '))
                {
                    if (dictionary.TryGetValue(oldPhon, out var newPhon))
                        newAlias += newPhon;
                    else
                    {
                        var r = MessageBox.Show(
                            $"Unknown phoneme found: [{oldPhon}] in {o.Alias}.\nDo you wish to skip this entry? (Otherwise, the unknown phoneme will be kept)",
                            "Unknown Phoneme", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (r == DialogResult.Yes)
                            continue;
                        
                        newAlias += $" {oldPhon} ";
                    }
                }

                newAlias += repeatedNumber;
                newOtoEntries.Add(new OtoEntry(o, newAlias));
            }

            button1.Text = "Saving new oto file...";

            var newOto = oldOtoEntries.Concat(newOtoEntries).Select(thereAreTooMany1LetterVariablesHere => thereAreTooMany1LetterVariablesHere.ToString()); //since when is e defined like bitch
            File.WriteAllLines(otoFileTextBox.Text, newOto, Encoding.GetEncoding(932));
            MessageBox.Show("Aliasing complete", "Arpasing Aliaser");
            button1.Enabled = true;
            button1.Text = "Alias";
        }
    }
}