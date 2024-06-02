using Microsoft.VisualBasic.ApplicationServices;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace texteditor
{
    public partial class Form1 : Form
    {
        private bool bTextHasChanged = false;
        private string sDocumentName = "Untitled";
        //-------------------------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SetWindowName("Untitled");
            DisplayInformationStatusBar();
            status_title.Text = "Text Editor";
        }
        //-------------------------------------------------------------------------------------------

        private void SetWindowName(string name)
        {
            sDocumentName = name;
            Text = name;
        }
        //-------------------------------------------------------------------------------------------

        private void mi_New_Click(object sender, EventArgs e)
        {
            if (bTextHasChanged == false && sDocumentName == "Untitled")
                return;

            DialogResult SavePrompt = MessageBox.Show("Do you want to save changes?", "New file", MessageBoxButtons.YesNoCancel);

            if (SavePrompt == DialogResult.No)
                return;

            mi_Save_Click(sender, e);
            rtb_Editor.Text = "";
            bTextHasChanged = false;
            SetWindowName("Untitled");
        }
        //-------------------------------------------------------------------------------------------

        private void mi_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Définissez les propriétés de l'openFileDialog
            openFileDialog1.Title = "Sélectionnez un fichier";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            // Ouvrez le fichier sélectionné
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                rtb_Editor.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                SetWindowName(filePath);
            }
        }
        //-------------------------------------------------------------------------------------------

        private void mi_Save_Click(object sender, EventArgs e)
        {
            if (File.Exists(sDocumentName) == false || sDocumentName == "Untitled")
            {
                mi_SaveAs_Click(sender, e);
                return;
            }

            StreamWriter writer = new StreamWriter(sDocumentName);
            writer.Write(rtb_Editor.Text);
            writer.Flush();
            writer.Close();
            MessageBox.Show("Fichier enregistré avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //-------------------------------------------------------------------------------------------

        private void mi_SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Fichiers texte (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveFileDialog1.FileName.ToString());
                file.WriteLine(rtb_Editor.Text);
                file.Flush();
                file.Close();
                MessageBox.Show("Fichier enregistré avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetWindowName(saveFileDialog1.FileName);
            }
        }
        //-------------------------------------------------------------------------------------------

        private void mi_Undo_Click(object sender, EventArgs e)
        {
            if (rtb_Editor.CanUndo == false)
                return;

            rtb_Editor.Undo();
            rtb_Editor.ClearUndo();
        }
        //-------------------------------------------------------------------------------------------

        private void mi_Cut_Click(object sender, EventArgs e)
        {
            if (rtb_Editor.SelectedText != "")
                rtb_Editor.Cut();
        }
        //-------------------------------------------------------------------------------------------

        private void mi_Copy_Click(object sender, EventArgs e)
        {
            if (rtb_Editor.SelectionLength > 0)
                rtb_Editor.Copy();
        }
        //-------------------------------------------------------------------------------------------

        private void mi_Paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                rtb_Editor.Paste();
        }
        //-------------------------------------------------------------------------------------------

        private void mi_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by ...", "About");
        }
        //-------------------------------------------------------------------------------------------

        private void rtb_Editor_TextChanged(object sender, EventArgs e)
        {
            DisplayInformationStatusBar();

            bTextHasChanged = false;

            if (rtb_Editor.Text.Length > 0)
                bTextHasChanged = true;
        }
        //-------------------------------------------------------------------------------------------

        private void DisplayInformationStatusBar()
        {
            // Get the line.
            int index = rtb_Editor.SelectionStart;
            int line = rtb_Editor.GetLineFromCharIndex(index);

            // Get the column.
            int firstChar = rtb_Editor.GetFirstCharIndexFromLine(line);
            int column = index - firstChar;

            
            status_LineCol.Text = "Line: " + line + ", Col: " + column;
            status_Character.Text = "Character: " + rtb_Editor.Text.Length; 
        }
        //-------------------------------------------------------------------------------------------

        private void mi_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;

            if (sDocumentName != "Untitled")
                mi_Save_Click(sender, e);

            Application.Exit();
        }
        //-------------------------------------------------------------------------------------------
    }
}