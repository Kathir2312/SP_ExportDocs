namespace SP_ExportDocs
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.btnspfieldHelp = new System.Windows.Forms.Button();
            this.picSPField = new System.Windows.Forms.PictureBox();
            this.btnTermSetIdHelp = new System.Windows.Forms.Button();
            this.btnTermstoreHelp = new System.Windows.Forms.Button();
            this.picTermStoreName = new System.Windows.Forms.PictureBox();
            this.picTermSetId = new System.Windows.Forms.PictureBox();
            this.btnHierarchyPopulate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoENglish = new System.Windows.Forms.RadioButton();
            this.rdoArabic = new System.Windows.Forms.RadioButton();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFieldID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtListId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTermSetId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTermstoreName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSPField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermStoreName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermSetId)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Info;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(379, 798);
            this.treeView1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picSPField);
            this.splitContainer1.Panel2.Controls.Add(this.picTermSetId);
            this.splitContainer1.Panel2.Controls.Add(this.btnspfieldHelp);
            this.splitContainer1.Panel2.Controls.Add(this.btnTermSetIdHelp);
            this.splitContainer1.Panel2.Controls.Add(this.btnTermstoreHelp);
            this.splitContainer1.Panel2.Controls.Add(this.picTermStoreName);
            this.splitContainer1.Panel2.Controls.Add(this.btnHierarchyPopulate);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.lblExportPath);
            this.splitContainer1.Panel2.Controls.Add(this.btnSelectPath);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtFieldID);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtListId);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtWebId);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtSiteID);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtTermSetId);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtTermstoreName);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1375, 1060);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 5;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(569, 1060);
            this.treeView2.TabIndex = 0;
            // 
            // btnspfieldHelp
            // 
            this.btnspfieldHelp.Location = new System.Drawing.Point(567, 216);
            this.btnspfieldHelp.Name = "btnspfieldHelp";
            this.btnspfieldHelp.Size = new System.Drawing.Size(26, 23);
            this.btnspfieldHelp.TabIndex = 29;
            this.btnspfieldHelp.Text = "...";
            this.btnspfieldHelp.UseVisualStyleBackColor = true;
            this.btnspfieldHelp.Click += new System.EventHandler(this.btnspfieldHelp_Click);
            // 
            // picSPField
            // 
            this.picSPField.Image = global::SP_ExportDocs.imgs.imgFieldNameId;
            this.picSPField.Location = new System.Drawing.Point(16, 350);
            this.picSPField.Name = "picSPField";
            this.picSPField.Size = new System.Drawing.Size(787, 639);
            this.picSPField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSPField.TabIndex = 28;
            this.picSPField.TabStop = false;
            this.picSPField.Visible = false;
            // 
            // btnTermSetIdHelp
            // 
            this.btnTermSetIdHelp.Location = new System.Drawing.Point(567, 73);
            this.btnTermSetIdHelp.Name = "btnTermSetIdHelp";
            this.btnTermSetIdHelp.Size = new System.Drawing.Size(26, 23);
            this.btnTermSetIdHelp.TabIndex = 27;
            this.btnTermSetIdHelp.Text = "...";
            this.btnTermSetIdHelp.UseVisualStyleBackColor = true;
            this.btnTermSetIdHelp.Click += new System.EventHandler(this.btnTermSetIdHelp_Click);
            // 
            // btnTermstoreHelp
            // 
            this.btnTermstoreHelp.Location = new System.Drawing.Point(567, 34);
            this.btnTermstoreHelp.Name = "btnTermstoreHelp";
            this.btnTermstoreHelp.Size = new System.Drawing.Size(26, 23);
            this.btnTermstoreHelp.TabIndex = 26;
            this.btnTermstoreHelp.Text = "...";
            this.btnTermstoreHelp.UseVisualStyleBackColor = true;
            this.btnTermstoreHelp.Click += new System.EventHandler(this.btnTermstoreHelp_Click);
            // 
            // picTermStoreName
            // 
            this.picTermStoreName.Image = global::SP_ExportDocs.imgs.imgtermstore;
            this.picTermStoreName.Location = new System.Drawing.Point(16, 348);
            this.picTermStoreName.Name = "picTermStoreName";
            this.picTermStoreName.Size = new System.Drawing.Size(326, 330);
            this.picTermStoreName.TabIndex = 25;
            this.picTermStoreName.TabStop = false;
            this.picTermStoreName.Visible = false;
            // 
            // picTermSetId
            // 
            this.picTermSetId.Image = global::SP_ExportDocs.imgs.imgtermset;
            this.picTermSetId.Location = new System.Drawing.Point(16, 348);
            this.picTermSetId.Name = "picTermSetId";
            this.picTermSetId.Size = new System.Drawing.Size(759, 700);
            this.picTermSetId.TabIndex = 24;
            this.picTermSetId.TabStop = false;
            this.picTermSetId.Visible = false;
            // 
            // btnHierarchyPopulate
            // 
            this.btnHierarchyPopulate.Location = new System.Drawing.Point(42, 418);
            this.btnHierarchyPopulate.Name = "btnHierarchyPopulate";
            this.btnHierarchyPopulate.Size = new System.Drawing.Size(417, 50);
            this.btnHierarchyPopulate.TabIndex = 23;
            this.btnHierarchyPopulate.Text = "Popoulate Hierarchy[For Verification]";
            this.btnHierarchyPopulate.UseVisualStyleBackColor = true;
            this.btnHierarchyPopulate.Click += new System.EventHandler(this.btnHierarchyPopulate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Language";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoENglish);
            this.groupBox1.Controls.Add(this.rdoArabic);
            this.groupBox1.Location = new System.Drawing.Point(129, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 39);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // rdoENglish
            // 
            this.rdoENglish.AutoSize = true;
            this.rdoENglish.Location = new System.Drawing.Point(6, 15);
            this.rdoENglish.Name = "rdoENglish";
            this.rdoENglish.Size = new System.Drawing.Size(59, 17);
            this.rdoENglish.TabIndex = 19;
            this.rdoENglish.Text = "English";
            this.rdoENglish.UseVisualStyleBackColor = true;
            // 
            // rdoArabic
            // 
            this.rdoArabic.AutoSize = true;
            this.rdoArabic.Location = new System.Drawing.Point(97, 15);
            this.rdoArabic.Name = "rdoArabic";
            this.rdoArabic.Size = new System.Drawing.Size(55, 17);
            this.rdoArabic.TabIndex = 20;
            this.rdoArabic.Text = "Arabic";
            this.rdoArabic.UseVisualStyleBackColor = true;
            // 
            // lblExportPath
            // 
            this.lblExportPath.AutoSize = true;
            this.lblExportPath.Location = new System.Drawing.Point(126, 334);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Size = new System.Drawing.Size(74, 13);
            this.lblExportPath.TabIndex = 18;
            this.lblExportPath.Text = "Path to Export";
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(129, 299);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(330, 23);
            this.btnSelectPath.TabIndex = 17;
            this.btnSelectPath.Text = "Select Folder";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Path to Export";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Field Name(SharePoint Internal Name)";
            // 
            // txtFieldID
            // 
            this.txtFieldID.Location = new System.Drawing.Point(231, 219);
            this.txtFieldID.Name = "txtFieldID";
            this.txtFieldID.Size = new System.Drawing.Size(330, 20);
            this.txtFieldID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "List ID";
            // 
            // txtListId
            // 
            this.txtListId.Location = new System.Drawing.Point(231, 181);
            this.txtListId.Name = "txtListId";
            this.txtListId.Size = new System.Drawing.Size(330, 20);
            this.txtListId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Web Id";
            // 
            // txtWebId
            // 
            this.txtWebId.Location = new System.Drawing.Point(231, 145);
            this.txtWebId.Name = "txtWebId";
            this.txtWebId.Size = new System.Drawing.Size(330, 20);
            this.txtWebId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Site ID";
            // 
            // txtSiteID
            // 
            this.txtSiteID.Location = new System.Drawing.Point(231, 113);
            this.txtSiteID.Name = "txtSiteID";
            this.txtSiteID.Size = new System.Drawing.Size(330, 20);
            this.txtSiteID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TermSet ID";
            // 
            // txtTermSetId
            // 
            this.txtTermSetId.Location = new System.Drawing.Point(231, 75);
            this.txtTermSetId.Name = "txtTermSetId";
            this.txtTermSetId.Size = new System.Drawing.Size(330, 20);
            this.txtTermSetId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TermStoreName";
            // 
            // txtTermstoreName
            // 
            this.txtTermstoreName.Location = new System.Drawing.Point(231, 36);
            this.txtTermstoreName.Name = "txtTermstoreName";
            this.txtTermstoreName.Size = new System.Drawing.Size(330, 20);
            this.txtTermstoreName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 1060);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSPField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermStoreName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTermSetId)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTermstoreName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTermSetId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFieldID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtListId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWebId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiteID;
        private System.Windows.Forms.Label lblExportPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.RadioButton rdoArabic;
        private System.Windows.Forms.RadioButton rdoENglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHierarchyPopulate;
        private System.Windows.Forms.PictureBox picTermSetId;
        private System.Windows.Forms.Button btnTermstoreHelp;
        private System.Windows.Forms.PictureBox picTermStoreName;
        private System.Windows.Forms.Button btnTermSetIdHelp;
        private System.Windows.Forms.PictureBox picSPField;
        private System.Windows.Forms.Button btnspfieldHelp;
    }
}

