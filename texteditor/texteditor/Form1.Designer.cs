

namespace texteditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menu_Strip = new MenuStrip();
            mi_File = new ToolStripMenuItem();
            mi_New = new ToolStripMenuItem();
            mi_Open = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            mi_Save = new ToolStripMenuItem();
            mi_SaveAs = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mi_Print = new ToolStripMenuItem();
            mi_Preview = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mi_Exit = new ToolStripMenuItem();
            mi_Edit = new ToolStripMenuItem();
            mi_Undo = new ToolStripMenuItem();
            mi_Cut = new ToolStripMenuItem();
            mi_Copy = new ToolStripMenuItem();
            mi_Paste = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mi_Color = new ToolStripMenuItem();
            mi_Font = new ToolStripMenuItem();
            mi_Help = new ToolStripMenuItem();
            mi_About = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            rtb_Editor = new RichTextBox();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            status_Strip = new StatusStrip();
            status_LineCol = new ToolStripStatusLabel();
            status_Character = new ToolStripStatusLabel();
            status_title = new ToolStripStatusLabel();
            menu_Strip.SuspendLayout();
            status_Strip.SuspendLayout();
            SuspendLayout();
            // 
            // menu_Strip
            // 
            menu_Strip.Font = new Font("Segoe UI", 12F);
            menu_Strip.Items.AddRange(new ToolStripItem[] { mi_File, mi_Edit, mi_Help });
            menu_Strip.Location = new Point(0, 0);
            menu_Strip.Name = "menu_Strip";
            menu_Strip.Padding = new Padding(8, 3, 0, 3);
            menu_Strip.RenderMode = ToolStripRenderMode.System;
            menu_Strip.Size = new Size(1024, 31);
            menu_Strip.TabIndex = 2;
            // 
            // mi_File
            // 
            mi_File.DropDownItems.AddRange(new ToolStripItem[] { mi_New, mi_Open, toolStripSeparator, mi_Save, mi_SaveAs, toolStripSeparator1, mi_Print, mi_Preview, toolStripSeparator2, mi_Exit });
            mi_File.ForeColor = SystemColors.ActiveCaptionText;
            mi_File.Name = "mi_File";
            mi_File.Size = new Size(46, 25);
            mi_File.Text = "File";
            // 
            // mi_New
            // 
            mi_New.Image = (Image)resources.GetObject("mi_New.Image");
            mi_New.ImageTransparentColor = Color.Magenta;
            mi_New.Name = "mi_New";
            mi_New.Size = new Size(141, 26);
            mi_New.Text = "New";
            mi_New.Click += mi_New_Click;
            // 
            // mi_Open
            // 
            mi_Open.Image = (Image)resources.GetObject("mi_Open.Image");
            mi_Open.ImageTransparentColor = Color.Magenta;
            mi_Open.Name = "mi_Open";
            mi_Open.Size = new Size(141, 26);
            mi_Open.Text = "Open";
            mi_Open.Click += mi_Open_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(138, 6);
            // 
            // mi_Save
            // 
            mi_Save.Image = (Image)resources.GetObject("mi_Save.Image");
            mi_Save.ImageTransparentColor = Color.Magenta;
            mi_Save.Name = "mi_Save";
            mi_Save.Size = new Size(141, 26);
            mi_Save.Text = "Save";
            mi_Save.Click += mi_Save_Click;
            // 
            // mi_SaveAs
            // 
            mi_SaveAs.Name = "mi_SaveAs";
            mi_SaveAs.Size = new Size(141, 26);
            mi_SaveAs.Text = "Save as...";
            mi_SaveAs.Click += mi_SaveAs_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(138, 6);
            // 
            // mi_Print
            // 
            mi_Print.Image = (Image)resources.GetObject("mi_Print.Image");
            mi_Print.ImageTransparentColor = Color.Magenta;
            mi_Print.Name = "mi_Print";
            mi_Print.Size = new Size(141, 26);
            mi_Print.Text = "Print";
            // 
            // mi_Preview
            // 
            mi_Preview.Image = (Image)resources.GetObject("mi_Preview.Image");
            mi_Preview.ImageTransparentColor = Color.Magenta;
            mi_Preview.Name = "mi_Preview";
            mi_Preview.Size = new Size(141, 26);
            mi_Preview.Text = "Preview";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(138, 6);
            // 
            // mi_Exit
            // 
            mi_Exit.Name = "mi_Exit";
            mi_Exit.Size = new Size(141, 26);
            mi_Exit.Text = "Exit";
            mi_Exit.Click += mi_Exit_Click;
            // 
            // mi_Edit
            // 
            mi_Edit.DropDownItems.AddRange(new ToolStripItem[] { mi_Undo, mi_Cut, mi_Copy, mi_Paste, toolStripMenuItem1, mi_Color, mi_Font });
            mi_Edit.ForeColor = SystemColors.ActiveCaptionText;
            mi_Edit.Name = "mi_Edit";
            mi_Edit.Size = new Size(48, 25);
            mi_Edit.Text = "Edit";
            // 
            // mi_Undo
            // 
            mi_Undo.Name = "mi_Undo";
            mi_Undo.Size = new Size(118, 26);
            mi_Undo.Text = "Undo";
            mi_Undo.Click += mi_Undo_Click;
            // 
            // mi_Cut
            // 
            mi_Cut.Image = (Image)resources.GetObject("mi_Cut.Image");
            mi_Cut.ImageTransparentColor = Color.Magenta;
            mi_Cut.Name = "mi_Cut";
            mi_Cut.Size = new Size(118, 26);
            mi_Cut.Text = "Cut";
            mi_Cut.Click += mi_Cut_Click;
            // 
            // mi_Copy
            // 
            mi_Copy.Image = (Image)resources.GetObject("mi_Copy.Image");
            mi_Copy.ImageTransparentColor = Color.Magenta;
            mi_Copy.Name = "mi_Copy";
            mi_Copy.Size = new Size(118, 26);
            mi_Copy.Text = "Copy";
            mi_Copy.Click += mi_Copy_Click;
            // 
            // mi_Paste
            // 
            mi_Paste.Image = (Image)resources.GetObject("mi_Paste.Image");
            mi_Paste.ImageTransparentColor = Color.Magenta;
            mi_Paste.Name = "mi_Paste";
            mi_Paste.Size = new Size(118, 26);
            mi_Paste.Text = "Paste";
            mi_Paste.Click += mi_Paste_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(115, 6);
            // 
            // mi_Color
            // 
            mi_Color.Name = "mi_Color";
            mi_Color.Size = new Size(118, 26);
            mi_Color.Text = "Color";
            // 
            // mi_Font
            // 
            mi_Font.Name = "mi_Font";
            mi_Font.Size = new Size(118, 26);
            mi_Font.Text = "Font";
            // 
            // mi_Help
            // 
            mi_Help.DropDownItems.AddRange(new ToolStripItem[] { mi_About });
            mi_Help.Font = new Font("Segoe UI", 12F);
            mi_Help.ForeColor = SystemColors.ActiveCaptionText;
            mi_Help.Name = "mi_Help";
            mi_Help.Size = new Size(54, 25);
            mi_Help.Text = "Help";
            // 
            // mi_About
            // 
            mi_About.Name = "mi_About";
            mi_About.Size = new Size(122, 26);
            mi_About.Text = "About";
            mi_About.Click += mi_About_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtb_Editor
            // 
            rtb_Editor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_Editor.BorderStyle = BorderStyle.None;
            rtb_Editor.Location = new Point(0, 29);
            rtb_Editor.Name = "rtb_Editor";
            rtb_Editor.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtb_Editor.Size = new Size(1024, 717);
            rtb_Editor.TabIndex = 3;
            rtb_Editor.Text = "";
            rtb_Editor.TextChanged += rtb_Editor_TextChanged;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // status_Strip
            // 
            status_Strip.Items.AddRange(new ToolStripItem[] { status_LineCol, status_Character, status_title });
            status_Strip.Location = new Point(0, 746);
            status_Strip.Name = "status_Strip";
            status_Strip.Size = new Size(1024, 22);
            status_Strip.TabIndex = 5;
            // 
            // status_LineCol
            // 
            status_LineCol.ForeColor = SystemColors.ActiveCaptionText;
            status_LineCol.Name = "status_LineCol";
            status_LineCol.Size = new Size(50, 17);
            status_LineCol.Text = "Line,Col";
            status_LineCol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // status_Character
            // 
            status_Character.ForeColor = SystemColors.ActiveCaptionText;
            status_Character.Name = "status_Character";
            status_Character.Size = new Size(58, 17);
            status_Character.Text = "Character";
            status_Character.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // status_title
            // 
            status_title.ForeColor = SystemColors.ActiveCaptionText;
            status_title.ImageAlign = ContentAlignment.MiddleRight;
            status_title.Name = "status_title";
            status_title.RightToLeft = RightToLeft.No;
            status_title.Size = new Size(29, 17);
            status_title.Text = "Title";
            status_title.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1024, 768);
            Controls.Add(status_Strip);
            Controls.Add(rtb_Editor);
            Controls.Add(menu_Strip);
            Font = new Font("Segoe UI", 12F);
            ForeColor = SystemColors.Control;
            MainMenuStrip = menu_Strip;
            Margin = new Padding(4);
            MinimumSize = new Size(1024, 768);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menu_Strip.ResumeLayout(false);
            menu_Strip.PerformLayout();
            status_Strip.ResumeLayout(false);
            status_Strip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu_Strip;
        private ToolStripMenuItem mi_Edit;
        private ToolStripMenuItem mi_Undo;
        private ToolStripMenuItem mi_Cut;
        private ToolStripMenuItem mi_Copy;
        private ToolStripMenuItem mi_Paste;
        private ToolStripMenuItem mi_Help;
        private ToolStripMenuItem mi_About;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox rtb_Editor;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem mi_File;
        private ToolStripMenuItem mi_New;
        private ToolStripMenuItem mi_Open;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem mi_Save;
        private ToolStripMenuItem mi_SaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mi_Print;
        private ToolStripMenuItem mi_Preview;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mi_Exit;
        private ToolStripMenuItem mi_Color;
        private ToolStripMenuItem mi_Font;
        private FontDialog fontDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private StatusStrip status_Strip;
        private ToolStripStatusLabel status_LineCol;
        private ToolStripStatusLabel status_Character;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripStatusLabel status_title;
    }
}
