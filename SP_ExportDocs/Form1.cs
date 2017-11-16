using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_ExportDocs
{
    public partial class Form1 : Form
    {
        private string TERMSTORE_NAME= "Managed Metadata Service";
        private string TERMSET_ID = "f8fb708a-097d-4571-9a0e-5629206d7949";//"bcd32d39-6858-4000-bdfd-fcc7037285fa";//f8fb708a-097d-4571-9a0e-5629206d7949
        private string SITEGUID = "79d17e9d-84c8-4fcd-be6a-26a05590c28e";
        private string WEBGUID = "45632176-0a7d-4d98-88ca-b51e2e79c6e3";//"8a8ac521-bab0-4df4-a98f-e2714a5df927"
        private string LISTGUID = "b9f7a85e-cb35-4645-bae0-5c70b4a9494b";//"57760c8a-7d86-4f4c-b399-56d6205d5aaa";
        private string FieldName = "Document_x0020_Type";
        private string FILE_PATH = @"F:\IALEG";
        private int languageCode = 1033;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info("************************************************************************    INTITIATED EXPORT ************************************");
                treeView2.Nodes.Clear();
                assingtoConstants();
                IDownlodTaxonomy objDDl;
                Composite objCmp;
                IExportDocs objEXP;
                objDDl = new DownloadTaxonomy(new Guid(SITEGUID), TERMSTORE_NAME, new Guid(TERMSET_ID));
                
                    objEXP = new ExportDocs(new Guid(SITEGUID), new Guid(WEBGUID), new Guid(LISTGUID), FieldName);

                if (objDDl.isValidState)
                {
                    objCmp = objDDl.getTaxonomy(languageCode);
                    log.Info(objCmp.CMChilds);
                    treeView2.Nodes.Add(bindHierarchy(objCmp));
                    objEXP.ExportDocuments(objCmp,FILE_PATH);

                }
                log.Info("************************************************************************    Completed EXPORT ************************************"); 
            }
            catch (Exception w)
            {
                log.Error(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name), w);
                throw;
            }
        }

        private void btnHierarchyPopulate_Click(object sender, EventArgs e)
        {
            try
            {
                treeView2.Nodes.Clear();
                assingtoConstants();
                IDownlodTaxonomy objDDl;
                Composite objCmp;
                objDDl = new DownloadTaxonomy(new Guid(SITEGUID), TERMSTORE_NAME, new Guid(TERMSET_ID));
                if (objDDl.isValidState)
                {
                    log.Info("Inovkiing");
                    
                    objCmp = objDDl.getTaxonomy(languageCode);
                    log.Info(objCmp.CMChilds);
                    treeView2.Nodes.Add(bindHierarchy(objCmp));
                }
            }
            catch (Exception w)
            {
                log.Error(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name), w);
                throw;
            }
        }
        private void assingtoConstants()
        {
            try
            {
                TERMSTORE_NAME = txtTermstoreName.Text;
                TERMSET_ID = txtTermSetId.Text;
                SITEGUID = txtSiteID.Text;
                WEBGUID = txtWebId.Text;
                LISTGUID = txtListId.Text;
                FieldName = txtFieldID.Text;
                languageCode = rdoENglish.Checked ? 1033 : 1025;
                FILE_PATH = lblExportPath.Text;
                //languageCode
            }
            catch (Exception w)
            {
                log.Error(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name), w);
                throw;
            }
        }

        private void assingtoUI()
        {
            try
            {
                txtTermstoreName.Text = TERMSTORE_NAME;
                txtTermSetId.Text = TERMSET_ID;
                txtSiteID.Text = SITEGUID;
                txtWebId.Text = WEBGUID;
                txtListId.Text = LISTGUID;
                txtFieldID.Text = FieldName;
                rdoENglish.Checked = languageCode == 1033 ? true : false;
               // rdoArabic.Checked = !(rdoENglish.Checked);
                lblExportPath.Text = FILE_PATH;
                folderBrowserDialog1.SelectedPath = FILE_PATH;
                //languageCode
            }
            catch (Exception w)
            {
                log.Error(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name), w);
                throw;
            }
        }
        private TreeNode bindHierarchy(Component cmpObj)
        {
            try
            {
                TreeNode tn = new TreeNode(cmpObj.PropName);

                if (typeof(Composite).FullName == cmpObj.GetType().FullName)
                {
                    Composite comp = (Composite)cmpObj;
                    foreach (Component item in comp.CMChilds)
                    {
                        TreeNode leaf;
                        if (typeof(Composite).FullName == item.GetType().FullName)
                        {
                            tn.Nodes.Add(bindHierarchy(item));
                        }
                        else
                        {
                            leaf = new TreeNode(item.PropName);
                            tn.Nodes.Add(leaf);
                        }
                    }
                }
                else
                {
                    TreeNode leaf;
                    leaf = new TreeNode(cmpObj.PropName);
                    tn.Nodes.Add(leaf);
                }
                return tn;    
            }
            //return cmpRoot;
            catch (Exception w)
            {
                log.Error(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name), w);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = folderBrowserDialog1.ShowDialog();
                lblExportPath.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
            catch (Exception w)
            {
                log.Error(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name), w);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                assingtoUI();
            }
            catch (Exception w)
            {
                log.Error(string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name), w);
                throw;
            }
        }

      
        

        private void btnTermSetIdHelp_Click(object sender, EventArgs e)
        {
            picTermSetId.Visible = !picTermSetId.Visible;
        }

        private void btnTermstoreHelp_Click(object sender, EventArgs e)
        {
            
            picTermStoreName.Visible = !picTermStoreName.Visible;
            
        }

        private void btnspfieldHelp_Click(object sender, EventArgs e)
        {
            picSPField.Visible = !picSPField.Visible;
        }

    }
}
