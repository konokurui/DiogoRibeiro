using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiogoRibeiro
{
    public partial class DiogoRibeiro : Form
    {
        public DiogoRibeiro()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Arquivos txt |*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                rtbTexto.Text = leitor.ReadToEnd();
                leitor.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar arquivo";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Arquivo txt | *.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(rtbTexto.Text);
                gravar.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar arquivo";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Arquivo txt | *.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(rtbTexto.Text);
                gravar.Close();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexto.SelectedText == "")
            {
                MessageBox.Show("SASUKEEEEEE");
            }
            else
            {
                Clipboard.SetText(rtbTexto.SelectedText);
                rtbTexto.SelectedText = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbTexto.SelectedText == "")
            {
                

            }
            Clipboard.SetText(rtbTexto.SelectedText);

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectedText = Clipboard.GetText();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectAll();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                rtbTexto.SelectionFont = fontDialog1.Font;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog().Equals(DialogResult.OK))

            {
                rtbTexto.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
