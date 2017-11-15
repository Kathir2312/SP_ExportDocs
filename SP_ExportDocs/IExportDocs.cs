using Microsoft.SharePoint;
using Microsoft.SharePoint.Taxonomy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_ExportDocs
{
    interface IExportDocs
    {
        void ExportDocuments(Composite termsetHierarchy, string LocalPathToExport);
    }

    interface IDownlodTaxonomy
    {
        bool isValidState { get; set; }
         Composite getTaxonomy(string termstore, Guid termsetId, int languageCode);
        Composite getTaxonomy(int languageCode);
    }
    public class DownloadTaxonomy : IDownlodTaxonomy
    {
        private SPSite _site = null;
        private TaxonomySession _TaxonomySession  = null;
        private string _termstoreName = "";
        Guid _termsetId= default(Guid), _termStoreId = default(Guid);
        private bool _isValidState = false;
        private TermStore _TermStore = null;

        public bool isValidState { get { return _isValidState; } set{ _isValidState = value; } }

        public DownloadTaxonomy(Guid SiteGuid, string termstoreName, Guid termsetId)
        {
            try
            {
                using (_site = new SPSite(SiteGuid))
                {
                    _site.OpenWeb();
                    // _site = new SPSite("http://spdev2013:2016");
                    if (_site == null) { _isValidState = false; throw (new Exception(String.Format("No Sites found for Guid {0}", SiteGuid.ToString()))); }

                    _TaxonomySession = new TaxonomySession(this._site);
                    if (_TaxonomySession == null) { _isValidState = false; throw (new Exception(String.Format("No Termstore Found Specified site {0}", _site.Url))); }
                    _termstoreName = termstoreName; _termsetId = termsetId; 


                    _isValidState = true;
                }
            }
            catch (Exception)
            {
                _isValidState = false;
                throw;
            }
        }
        public Composite getTaxonomy(int languageCode)
        {
            return (getTaxonomy(this._termstoreName, this._termsetId,languageCode));
        }


        public Composite  getTaxonomy(string termstore, Guid termsetId, int languageCode)
        {
            try
            {

                //TermSetItem ts = FIllTaxonomyLOV(termstore, termsetId, termgroupId);
            Composite cmp= FillandReturnHierarchy(termstore, termsetId, languageCode); //returnHierarchy(ts, languageCode);
                cmp.Display(1);
                return cmp;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private TermSetItem FIllTaxonomyLOV(string TermstoreName, Guid TermsId, Guid termGroupId)
        {
            try
            {
                _TermStore = _TaxonomySession.TermStores[TermstoreName];
                if (_TermStore == null) { _isValidState = false; throw (new Exception(String.Format("No Termstore Found Specified Name {0}", TermstoreName))); }
                TermSetItem tc = getTerCollByID(TermsId, TermstoreName, termGroupId);
                return tc;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private Composite FillandReturnHierarchy(string TermstoreName, Guid TermsId, int languageCode)
        {
            try
            {
                 _TermStore = _TaxonomySession.TermStores[TermstoreName];
                    if (_TermStore == null) { _isValidState = false; throw (new Exception(String.Format("No Termstore Found Specified Name {0}", TermstoreName))); }
                TermSet ts = _TermStore.GetTermSet(TermsId);
                return returnHierarchy((TermSetItem)ts, languageCode);
            }
            catch (Exception)
            {

                throw;
            }
        }


        private TermSetItem getTerCollByID(Guid termsetID, string TermstoreName, Guid termgroupId)
        {
            Term retColl = null;
            try
            {
                //TermStore _TermStore = _TaxonomySession.TermStores[TermstoreName];

                Group gp = _TermStore.GetGroup(termgroupId);
                _TermStore.GetTermSets(new[] { "Legislation" });
                foreach (TermSet item in _TermStore.GetTermSets(new[] { "Legislation" }) )//gp.TermSets)
                {
                        Term tr = findRecursive(item, termsetID);
                        if (tr != null)
                        {
                            return tr;
                        }
                    string s = item.Name;
                }
                return retColl;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Term findRecursive(TermSet termset, Guid CompId)
        {
            Term retTerm = null;
            try
            {
                if (termset.Terms.Count > 0)
                {
                    foreach (Term item in termset.Terms)
                    {
                        Term tr = findRecursiveterms(item, CompId);
                        if (tr != null)
                        {
                            return tr;
                        }
                        //return findRecursiveterms(item, CompId);
                    }
                }
                return retTerm;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Term findRecursiveterms(Term term, Guid CompId)
        {
            try
            {
                Term retTerm = null;
                if (term.Id.ToString() == CompId.ToString())
                {
                    return term;
                }
                else if (term.TermsCount > 0)
                {
                    foreach (Term item in term.Terms)
                    {
                        Term tr = findRecursiveterms(item, CompId);
                        if (tr != null)
                        {
                            return tr;
                        }
                        //else 
                    }
                }
                //else {
                return retTerm;
                //}

            }
            catch (Exception)
            {

                throw;
            }
        }


        private Composite returnHierarchy(TermSetItem tsi, int languageCode)
        {
            try
            {
                int[] s = (tsi.GetType() == typeof(TermSet))?new[] { 0 }:GetWSSIds(((Term)tsi).Id, ((Term)tsi).TermSet.Id);
                string labelName1 = (tsi.GetType() == typeof(TermSet))?tsi.Name:GetLabelValue((Term)tsi, languageCode);

                Composite cmpRoot = new Composite(tsi.Id, labelName1, labelName1); cmpRoot.wssid = s.Length > 0 ? s[0] : 0; ;

                foreach (TermSetItem item in tsi.Terms)
                {
                    int[] ls = GetWSSIds(((Term)item).Id, ((Term)item).TermSet.Id);
                    if (item.Terms.Count > 0)
                    {
                        cmpRoot.Add(returnHierarchy(item, languageCode));
                    }
                    else
                    {
                        string labelName = GetLabelValue((Term)item, languageCode);
                        Leaf leaf = new Leaf(item.Id, labelName, labelName);
                        leaf.wssid = ls.Length > 0 ? ls[0] : 0; 
                        cmpRoot.Add(leaf);
                    }
                }
                return cmpRoot;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private string GetLabelValue(Term term, int languageCode)
        {
            try
            {
                //if(term.Labels.Count>0)
                //return term.Labels.Where((x) => x.Language == languageCode).FirstOrDefault().Value;
                //else
                return String.IsNullOrEmpty(term.GetDefaultLabel(languageCode))?term.Name:term.GetDefaultLabel(languageCode);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private int[] GetWSSIds(Guid termId, Guid termSetId)
        {
            //Guid termsetId = new Guid("8803681f-9301-4578-9d7b-a5a0eecd10ea");
            return TaxonomyField.GetWssIdsOfTerm(this._site, _TermStore.Id, termSetId, termId, false, 500);
            //return TaxonomyField.GetWssIdsOfTerm(this._site, _TermStore.Id, new Guid("f8fb708a-097d-4571-9a0e-5629206d7949"), new Guid("bcd32d39-6858-4000-bdfd-fcc7037285fa"), true, 500);

        }


    }



    public class ExportDocs : IExportDocs
    {
        
        private bool _isValidState = false;

        Guid _SiteId, _WebId, _ListId;
        string _FieldName;
        public bool isValidState { get { return _isValidState; } set { _isValidState = value; } }

        public ExportDocs(Guid SiteGuid, Guid WebGuId, Guid ListGuId, string FieldName)
        {
            _SiteId = SiteGuid;
            _WebId = WebGuId;
            _ListId = ListGuId;
            _FieldName = FieldName;
        }

        public void ExportDocuments(Composite termsetHierarchy, string LocalPathToExport)
        {
            try
            {
                using (SPSite _site = new SPSite(_SiteId))
                {
                    using (SPWeb _web = _site.OpenWeb(_WebId))
                    {
                        SPList _list = _web.Lists[_ListId];
                        createFolderStructure((Component)termsetHierarchy,LocalPathToExport, _list);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ExportDocuments1(Component termsetHierarchy, string LocalPathToExport, SPList _MyDocLibrary)
        {
            try
            {
                string SPQuery = getCAMLQuery(new[] { termsetHierarchy.wssid }, _FieldName);
                SPListItemCollection items = getDocuments(SPQuery, _MyDocLibrary);
                foreach (SPListItem curItem in items)
                {
                    SaveFile(curItem.File, LocalPathToExport);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private bool SaveFile(SPFile file, string Path)
        {
            try
            {
                byte[] b = file.OpenBinary();
                FileStream fs = new FileStream(Path + "\\" + file.Name, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(b);
                bw.Close();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void createFolderStructure(Component cmpObj, string Path, SPList mylist)
        {
            try
            {
                DirectoryInfo RootDir = Directory.CreateDirectory(string.Format("{0}\\{1}", Path, cmpObj.PropName));

                if (typeof(Composite).FullName == cmpObj.GetType().FullName)
                {
                    Composite comp = (Composite)cmpObj;
                    foreach (Component item in comp.CMChilds)
                    {
                        DirectoryInfo leaf;
                        if (typeof(Composite).FullName == item.GetType().FullName)
                        {
                            createFolderStructure(item, RootDir.FullName, mylist);
                            //ExportDocs(item, RootDir.FullName);
                        }
                        else
                        {
                            leaf= Directory.CreateDirectory(String.Format("{0}\\{1}", RootDir.FullName, item.PropName));
                            ExportDocuments1(item, leaf.FullName, mylist);
                        }
                    }
                }
                else
                {
                    Directory.CreateDirectory(String.Format("{0}\\{1}", RootDir.FullName, cmpObj.PropName));
                }
                //return "" ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string getCAMLQuery(int[] wssids, string metafield)
        {
            String CAML_QUERY = @"<Where><In><FieldRef LookupId=""True"" Name=""{1}"" /><Values>{0}</Values></In></Where>";
            String VALUES = @"<Value Type=""Lookup"">{0}</Value>";

            StringBuilder strValues = new StringBuilder();

            foreach (int intVal in wssids)
            {
                strValues.AppendLine(String.Format(VALUES, intVal));
            }
            String strQuery = String.Format(CAML_QUERY, strValues.ToString(), metafield);
            return strQuery;
        }

        private SPListItemCollection getDocuments(string query, SPList _MyDocLibrary)
        {
            SPQuery sPQuery = new SPQuery();
            sPQuery.Query = query;
            return _MyDocLibrary.GetItems(sPQuery);
        }


    }

}
