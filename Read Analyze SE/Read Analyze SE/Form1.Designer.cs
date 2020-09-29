namespace Read_Analyze_SE
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tls_Main = new System.Windows.Forms.ToolStrip();
            this.btn_Import = new System.Windows.Forms.ToolStripButton();
            this.btn_Export = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Help = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_ImportedDoc = new System.Windows.Forms.TabPage();
            this.rtx_ImportedFile = new System.Windows.Forms.RichTextBox();
            this.tab_Overview = new System.Windows.Forms.TabPage();
            this.rtx_OverView = new System.Windows.Forms.RichTextBox();
            this.tab_WORDV = new System.Windows.Forms.TabPage();
            this.rtxt_WordVariety = new System.Windows.Forms.RichTextBox();
            this.tab_Sentence = new System.Windows.Forms.TabPage();
            this.rtx_SentenceAna = new System.Windows.Forms.RichTextBox();
            this.tab_Search = new System.Windows.Forms.TabPage();
            this.rtx_SEARCH = new System.Windows.Forms.RichTextBox();
            this.dlg_OPEN = new System.Windows.Forms.OpenFileDialog();
            this.dlg_SAVE = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.prg_status = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_status = new System.Windows.Forms.ToolStripLabel();
            this.lbl_SEARCH = new System.Windows.Forms.ToolStripLabel();
            this.txt_SEARCH = new System.Windows.Forms.ToolStripTextBox();
            this.btn_FIND = new System.Windows.Forms.ToolStripButton();
            this.tls_SEARCHFIND = new System.Windows.Forms.ToolStripComboBox();
            this.tmr_FADE = new System.Windows.Forms.Timer(this.components);
            this.tmr_UX = new System.Windows.Forms.Timer(this.components);
            this.tls_Main.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_ImportedDoc.SuspendLayout();
            this.tab_Overview.SuspendLayout();
            this.tab_WORDV.SuspendLayout();
            this.tab_Sentence.SuspendLayout();
            this.tab_Search.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tls_Main
            // 
            this.tls_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tls_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Import,
            this.btn_Export,
            this.toolStripSeparator1,
            this.btn_Help,
            this.toolStripSeparator2,
            this.btn_Exit});
            this.tls_Main.Location = new System.Drawing.Point(0, 0);
            this.tls_Main.Name = "tls_Main";
            this.tls_Main.Size = new System.Drawing.Size(782, 27);
            this.tls_Main.TabIndex = 1;
            this.tls_Main.Text = "toolStrip1";
            // 
            // btn_Import
            // 
            this.btn_Import.Image = ((System.Drawing.Image)(resources.GetObject("btn_Import.Image")));
            this.btn_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(105, 24);
            this.btn_Import.Text = "Import File";
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.Image")));
            this.btn_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(158, 24);
            this.btn_Export.Text = "Export Information";
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Help
            // 
            this.btn_Help.Image = ((System.Drawing.Image)(resources.GetObject("btn_Help.Image")));
            this.btn_Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(65, 24);
            this.btn_Help.Text = "Help";
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(57, 24);
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ImportedDoc);
            this.tabControl1.Controls.Add(this.tab_Overview);
            this.tabControl1.Controls.Add(this.tab_WORDV);
            this.tabControl1.Controls.Add(this.tab_Sentence);
            this.tabControl1.Controls.Add(this.tab_Search);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 498);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            this.tabControl1.TabStopChanged += new System.EventHandler(this.tabControl1_TabStopChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tab_ImportedDoc
            // 
            this.tab_ImportedDoc.Controls.Add(this.rtx_ImportedFile);
            this.tab_ImportedDoc.Location = new System.Drawing.Point(4, 25);
            this.tab_ImportedDoc.Name = "tab_ImportedDoc";
            this.tab_ImportedDoc.Size = new System.Drawing.Size(774, 469);
            this.tab_ImportedDoc.TabIndex = 3;
            this.tab_ImportedDoc.Text = "Imported File";
            this.tab_ImportedDoc.UseVisualStyleBackColor = true;
            // 
            // rtx_ImportedFile
            // 
            this.rtx_ImportedFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtx_ImportedFile.Location = new System.Drawing.Point(0, 0);
            this.rtx_ImportedFile.Name = "rtx_ImportedFile";
            this.rtx_ImportedFile.Size = new System.Drawing.Size(774, 469);
            this.rtx_ImportedFile.TabIndex = 0;
            this.rtx_ImportedFile.Text = "";
            // 
            // tab_Overview
            // 
            this.tab_Overview.Controls.Add(this.rtx_OverView);
            this.tab_Overview.Location = new System.Drawing.Point(4, 25);
            this.tab_Overview.Name = "tab_Overview";
            this.tab_Overview.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Overview.Size = new System.Drawing.Size(774, 469);
            this.tab_Overview.TabIndex = 1;
            this.tab_Overview.Text = "Overview";
            this.tab_Overview.UseVisualStyleBackColor = true;
            // 
            // rtx_OverView
            // 
            this.rtx_OverView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtx_OverView.Location = new System.Drawing.Point(3, 3);
            this.rtx_OverView.Name = "rtx_OverView";
            this.rtx_OverView.Size = new System.Drawing.Size(768, 463);
            this.rtx_OverView.TabIndex = 0;
            this.rtx_OverView.Text = "";
            // 
            // tab_WORDV
            // 
            this.tab_WORDV.Controls.Add(this.rtxt_WordVariety);
            this.tab_WORDV.Location = new System.Drawing.Point(4, 25);
            this.tab_WORDV.Name = "tab_WORDV";
            this.tab_WORDV.Padding = new System.Windows.Forms.Padding(3);
            this.tab_WORDV.Size = new System.Drawing.Size(774, 469);
            this.tab_WORDV.TabIndex = 0;
            this.tab_WORDV.Text = "Word Variety";
            this.tab_WORDV.UseVisualStyleBackColor = true;
            // 
            // rtxt_WordVariety
            // 
            this.rtxt_WordVariety.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_WordVariety.Location = new System.Drawing.Point(3, 3);
            this.rtxt_WordVariety.Name = "rtxt_WordVariety";
            this.rtxt_WordVariety.Size = new System.Drawing.Size(768, 463);
            this.rtxt_WordVariety.TabIndex = 0;
            this.rtxt_WordVariety.Text = "";
            // 
            // tab_Sentence
            // 
            this.tab_Sentence.Controls.Add(this.rtx_SentenceAna);
            this.tab_Sentence.Location = new System.Drawing.Point(4, 25);
            this.tab_Sentence.Name = "tab_Sentence";
            this.tab_Sentence.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Sentence.Size = new System.Drawing.Size(774, 469);
            this.tab_Sentence.TabIndex = 2;
            this.tab_Sentence.Text = "Sentence Analyze";
            this.tab_Sentence.UseVisualStyleBackColor = true;
            // 
            // rtx_SentenceAna
            // 
            this.rtx_SentenceAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtx_SentenceAna.Location = new System.Drawing.Point(3, 3);
            this.rtx_SentenceAna.Name = "rtx_SentenceAna";
            this.rtx_SentenceAna.Size = new System.Drawing.Size(768, 463);
            this.rtx_SentenceAna.TabIndex = 0;
            this.rtx_SentenceAna.Text = "";
            // 
            // tab_Search
            // 
            this.tab_Search.Controls.Add(this.rtx_SEARCH);
            this.tab_Search.Location = new System.Drawing.Point(4, 25);
            this.tab_Search.Name = "tab_Search";
            this.tab_Search.Size = new System.Drawing.Size(774, 469);
            this.tab_Search.TabIndex = 4;
            this.tab_Search.Text = "Search";
            this.tab_Search.UseVisualStyleBackColor = true;
            // 
            // rtx_SEARCH
            // 
            this.rtx_SEARCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtx_SEARCH.Location = new System.Drawing.Point(0, 0);
            this.rtx_SEARCH.Name = "rtx_SEARCH";
            this.rtx_SEARCH.Size = new System.Drawing.Size(774, 469);
            this.rtx_SEARCH.TabIndex = 1;
            this.rtx_SEARCH.Text = resources.GetString("rtx_SEARCH.Text");
            // 
            // dlg_OPEN
            // 
            this.dlg_OPEN.FileName = "openFileDialog1";
            // 
            // dlg_SAVE
            // 
            this.dlg_SAVE.Filter = "Text files|*.txt|All files|*.*";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prg_status,
            this.lbl_status,
            this.lbl_SEARCH,
            this.txt_SEARCH,
            this.btn_FIND,
            this.tls_SEARCHFIND});
            this.toolStrip1.Location = new System.Drawing.Point(0, 525);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 28);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // prg_status
            // 
            this.prg_status.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.prg_status.Name = "prg_status";
            this.prg_status.Size = new System.Drawing.Size(100, 25);
            // 
            // lbl_status
            // 
            this.lbl_status.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(52, 25);
            this.lbl_status.Text = "Status:";
            // 
            // lbl_SEARCH
            // 
            this.lbl_SEARCH.AutoSize = false;
            this.lbl_SEARCH.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_SEARCH.Name = "lbl_SEARCH";
            this.lbl_SEARCH.Size = new System.Drawing.Size(119, 25);
            this.lbl_SEARCH.Text = "Search (NO FILE)";
            // 
            // txt_SEARCH
            // 
            this.txt_SEARCH.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SEARCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SEARCH.Name = "txt_SEARCH";
            this.txt_SEARCH.Size = new System.Drawing.Size(100, 28);
            this.txt_SEARCH.Click += new System.EventHandler(this.txt_SEARCH_Click);
            this.txt_SEARCH.TextChanged += new System.EventHandler(this.txt_SEARCH_TextChanged);
            // 
            // btn_FIND
            // 
            this.btn_FIND.BackColor = System.Drawing.SystemColors.Control;
            this.btn_FIND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_FIND.Image = ((System.Drawing.Image)(resources.GetObject("btn_FIND.Image")));
            this.btn_FIND.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_FIND.Name = "btn_FIND";
            this.btn_FIND.Size = new System.Drawing.Size(46, 25);
            this.btn_FIND.Text = "FIND";
            this.btn_FIND.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tls_SEARCHFIND
            // 
            this.tls_SEARCHFIND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tls_SEARCHFIND.Items.AddRange(new object[] {
            "FIND",
            "SEARCH"});
            this.tls_SEARCHFIND.Name = "tls_SEARCHFIND";
            this.tls_SEARCHFIND.Size = new System.Drawing.Size(121, 28);
            this.tls_SEARCHFIND.DropDownClosed += new System.EventHandler(this.tls_SEARCHFIND_DropDownClosed);
            this.tls_SEARCHFIND.Click += new System.EventHandler(this.tls_SEARCHFIND_Click);
            this.tls_SEARCHFIND.TextChanged += new System.EventHandler(this.tls_SEARCHFIND_TextChanged);
            // 
            // tmr_FADE
            // 
            this.tmr_FADE.Interval = 4000;
            this.tmr_FADE.Tick += new System.EventHandler(this.tmr_FADE_Tick);
            // 
            // tmr_UX
            // 
            this.tmr_UX.Interval = 500;
            this.tmr_UX.Tick += new System.EventHandler(this.tmr_UX_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tls_Main);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.Text = "RASE--NEW.TXT";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.tls_Main.ResumeLayout(false);
            this.tls_Main.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_ImportedDoc.ResumeLayout(false);
            this.tab_Overview.ResumeLayout(false);
            this.tab_WORDV.ResumeLayout(false);
            this.tab_Sentence.ResumeLayout(false);
            this.tab_Search.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls_Main;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_WORDV;
        private System.Windows.Forms.TabPage tab_Overview;
        private System.Windows.Forms.ToolStripButton btn_Import;
        private System.Windows.Forms.ToolStripButton btn_Export;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Exit;
        private System.Windows.Forms.TabPage tab_Sentence;
        private System.Windows.Forms.TabPage tab_ImportedDoc;
        private System.Windows.Forms.OpenFileDialog dlg_OPEN;
        private System.Windows.Forms.SaveFileDialog dlg_SAVE;
        private System.Windows.Forms.RichTextBox rtx_ImportedFile;
        private System.Windows.Forms.RichTextBox rtx_OverView;
        private System.Windows.Forms.RichTextBox rtxt_WordVariety;
        private System.Windows.Forms.RichTextBox rtx_SentenceAna;
        private System.Windows.Forms.TabPage tab_Search;
        private System.Windows.Forms.RichTextBox rtx_SEARCH;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar prg_status;
        private System.Windows.Forms.ToolStripLabel lbl_status;
        private System.Windows.Forms.ToolStripLabel lbl_SEARCH;
        private System.Windows.Forms.ToolStripTextBox txt_SEARCH;
        private System.Windows.Forms.Timer tmr_FADE;
        private System.Windows.Forms.ToolStripButton btn_FIND;
        private System.Windows.Forms.Timer tmr_UX;
        private System.Windows.Forms.ToolStripComboBox tls_SEARCHFIND;

    }
}

