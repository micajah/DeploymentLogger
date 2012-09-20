﻿
// Generated by MyGeneration Version # (1.1.5.0)

using System;
using System.Data;
using DL_DAL.Master;

namespace DL_WEB.DAL.Master
{
    public class Organization : _Organization
    {
        #region Cached Organizations

        protected DataTable m_dtOrganizations = null;

        public DataTable Organizations
        {
            get
            {
                if (null == m_dtOrganizations)
                {
                    ReloadCache();
                }

                return m_dtOrganizations;
            }
        }

        #endregion

        #region Instance

        protected static Organization m_Organization = null;

        public static Organization Instance
        {
            get
            {
                if (null == m_Organization)
                {
                    m_Organization = new Organization();
                }
                return m_Organization;
            }
        }

        #endregion

        #region Public Properties

        private string m_sConnectionString = string.Empty;

        public string DBConnectionString
        {
            get
            {
                if (string.Empty == m_sConnectionString)
                {
                    Database db = new Database();
                    db.LoadByPrimaryKey(base.DatabaseID);

                    m_sConnectionString = db.DBConnectionString;
                }
                return m_sConnectionString;
            }
        }


        #endregion

        #region Constructor

        public Organization()
        {
            base.ConnectionString = Master.DBConnectionString;
        }

        #endregion

        #region Overriden methods

        public override bool LoadByPrimaryKey(int organizationID)
        {
            bool bResult = base.LoadByPrimaryKey(organizationID);
            if (null == ConnectionString)
                throw new Exception("There is no database for this organization. Please contact system administrator about this problem.");
            return bResult;
        }

        #endregion

        #region Public Methods

        public DataView LoadOrganizationByPrimaryKey(int organizationID)
        {
            if (organizationID > 0)
                this.LoadByPrimaryKey(organizationID);
            else
            {
                base.AddNew();
                base.OrganizationID = base.DatabaseID = 0;
                base.IsDeleted = false;
            }

            return base.DefaultView;
        }

        public DataView LoadAllOrganizations()
        {
            base.LoadAll();
            return base.DefaultView;
        }

        public DataView LoadAllNonDeletedOrganizations()
        {
            base.Where.IsDeleted.Value = false;
            base.Where.IsDeleted.Operator = MyGeneration.dOOdads.WhereParameter.Operand.Equal;
            base.Query.Load();
            return base.DefaultView;
        }

        public int Update(int organizationID, string name, string description, int databaseID)
        {
            this.LoadOrganizationByPrimaryKey(organizationID);

            base.Name = string.Empty;
            if (name != null)
                base.Name = name;
            base.Description = string.Empty;
            if (description != null)
                base.Description = description;
            base.DatabaseID = databaseID;

            base.Save();

            return base.OrganizationID;
        }

        #endregion

        #region Private Methods

        protected void ReloadCache()
        {
            this.LoadAll();
            m_dtOrganizations = this.DefaultView.Table;
        }

        #endregion

        #region Static Methods

        public string GetOrganizationName(int iOrganizationID)
        {
            return GetOrganizationName(iOrganizationID, false);
        }

        public static int GetOrganizationDataBaseID(int organizationID)
        {
            Organization org = new Organization();
            if (org.LoadByPrimaryKey(organizationID))
                return org.DatabaseID;
            else
                return 0;
        }

        private string GetOrganizationName(int iOrganizationID, bool bSecondInvoke)
        {
            foreach (DataRow dr in Organizations.Rows)
            {
                if (Micajah.Common.Helper.Convert.o2i(dr["OrganizationID"]) == iOrganizationID)
                {
                    return Micajah.Common.Helper.Convert.o2s(dr["Name"]);
                }
            }
            if (!bSecondInvoke)
            {
                ReloadCache();

                return GetOrganizationName(iOrganizationID, true);
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion
    }
}