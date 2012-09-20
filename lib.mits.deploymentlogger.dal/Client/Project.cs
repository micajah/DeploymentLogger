﻿/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.1.5.1)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DL_DAL.Client
{
	public abstract class _Project : SqlClientEntity
	{
		public _Project()
		{
			this.QuerySource = "Project";
			this.MappingName = "Project";

		}

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();

		}


		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}

		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll()
		{
			ListDictionary parameters = null;

			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "LoadAllProject]", parameters);
		}

		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ProjectID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ProjectID, ProjectID);


			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "LoadProjectByPrimaryKey]", parameters);
		}

		#region Parameters
		protected class Parameters
		{

			public static SqlParameter ProjectID
			{
				get
				{
					return new SqlParameter("@ProjectID", SqlDbType.Int, 0);
				}
			}

			public static SqlParameter ProjectGroupID
			{
				get
				{
					return new SqlParameter("@ProjectGroupID", SqlDbType.Int, 0);
				}
			}

			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.VarChar, 255);
				}
			}

			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.VarChar, 1024);
				}
			}

			public static SqlParameter StartDate
			{
				get
				{
					return new SqlParameter("@StartDate", SqlDbType.DateTime, 0);
				}
			}

			public static SqlParameter FinishDate
			{
				get
				{
					return new SqlParameter("@FinishDate", SqlDbType.DateTime, 0);
				}
			}

			public static SqlParameter ProjectStatusID
			{
				get
				{
					return new SqlParameter("@ProjectStatusID", SqlDbType.Int, 0);
				}
			}

			public static SqlParameter ProjectCategoryID
			{
				get
				{
					return new SqlParameter("@ProjectCategoryID", SqlDbType.Int, 0);
				}
			}

			public static SqlParameter PublicName
			{
				get
				{
					return new SqlParameter("@PublicName", SqlDbType.VarChar, 255);
				}
			}

			public static SqlParameter OrganizationID
			{
				get
				{
					return new SqlParameter("@OrganizationID", SqlDbType.Int, 0);
				}
			}

		}
		#endregion

		#region ColumnNames
		public class ColumnNames
		{
			public const string ProjectID = "ProjectID";
			public const string ProjectGroupID = "ProjectGroupID";
			public const string Name = "Name";
			public const string Description = "Description";
			public const string StartDate = "StartDate";
			public const string FinishDate = "FinishDate";
			public const string ProjectStatusID = "ProjectStatusID";
			public const string ProjectCategoryID = "ProjectCategoryID";
			public const string PublicName = "PublicName";
			public const string OrganizationID = "OrganizationID";

			static public string ToPropertyName(string columnName)
			{
				if (ht == null)
				{
					ht = new Hashtable();

					ht[ProjectID] = _Project.PropertyNames.ProjectID;
					ht[ProjectGroupID] = _Project.PropertyNames.ProjectGroupID;
					ht[Name] = _Project.PropertyNames.Name;
					ht[Description] = _Project.PropertyNames.Description;
					ht[StartDate] = _Project.PropertyNames.StartDate;
					ht[FinishDate] = _Project.PropertyNames.FinishDate;
					ht[ProjectStatusID] = _Project.PropertyNames.ProjectStatusID;
					ht[ProjectCategoryID] = _Project.PropertyNames.ProjectCategoryID;
					ht[PublicName] = _Project.PropertyNames.PublicName;
					ht[OrganizationID] = _Project.PropertyNames.OrganizationID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string ProjectID = "ProjectID";
			public const string ProjectGroupID = "ProjectGroupID";
			public const string Name = "Name";
			public const string Description = "Description";
			public const string StartDate = "StartDate";
			public const string FinishDate = "FinishDate";
			public const string ProjectStatusID = "ProjectStatusID";
			public const string ProjectCategoryID = "ProjectCategoryID";
			public const string PublicName = "PublicName";
			public const string OrganizationID = "OrganizationID";

			static public string ToColumnName(string propertyName)
			{
				if (ht == null)
				{
					ht = new Hashtable();

					ht[ProjectID] = _Project.ColumnNames.ProjectID;
					ht[ProjectGroupID] = _Project.ColumnNames.ProjectGroupID;
					ht[Name] = _Project.ColumnNames.Name;
					ht[Description] = _Project.ColumnNames.Description;
					ht[StartDate] = _Project.ColumnNames.StartDate;
					ht[FinishDate] = _Project.ColumnNames.FinishDate;
					ht[ProjectStatusID] = _Project.ColumnNames.ProjectStatusID;
					ht[ProjectCategoryID] = _Project.ColumnNames.ProjectCategoryID;
					ht[PublicName] = _Project.ColumnNames.PublicName;
					ht[OrganizationID] = _Project.ColumnNames.OrganizationID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;
		}
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{
			public const string ProjectID = "s_ProjectID";
			public const string ProjectGroupID = "s_ProjectGroupID";
			public const string Name = "s_Name";
			public const string Description = "s_Description";
			public const string StartDate = "s_StartDate";
			public const string FinishDate = "s_FinishDate";
			public const string ProjectStatusID = "s_ProjectStatusID";
			public const string ProjectCategoryID = "s_ProjectCategoryID";
			public const string PublicName = "s_PublicName";
			public const string OrganizationID = "s_OrganizationID";

		}
		#endregion

		#region Properties

		public virtual int ProjectID
		{
			get
			{
				return base.Getint(ColumnNames.ProjectID);
			}
			set
			{
				base.Setint(ColumnNames.ProjectID, value);
			}
		}

		public virtual int ProjectGroupID
		{
			get
			{
				return base.Getint(ColumnNames.ProjectGroupID);
			}
			set
			{
				base.Setint(ColumnNames.ProjectGroupID, value);
			}
		}

		public virtual string Name
		{
			get
			{
				return base.Getstring(ColumnNames.Name);
			}
			set
			{
				base.Setstring(ColumnNames.Name, value);
			}
		}

		public virtual string Description
		{
			get
			{
				return base.Getstring(ColumnNames.Description);
			}
			set
			{
				base.Setstring(ColumnNames.Description, value);
			}
		}

		public virtual DateTime StartDate
		{
			get
			{
				return base.GetDateTime(ColumnNames.StartDate);
			}
			set
			{
				base.SetDateTime(ColumnNames.StartDate, value);
			}
		}

		public virtual DateTime FinishDate
		{
			get
			{
				return base.GetDateTime(ColumnNames.FinishDate);
			}
			set
			{
				base.SetDateTime(ColumnNames.FinishDate, value);
			}
		}

		public virtual int ProjectStatusID
		{
			get
			{
				return base.Getint(ColumnNames.ProjectStatusID);
			}
			set
			{
				base.Setint(ColumnNames.ProjectStatusID, value);
			}
		}

		public virtual int ProjectCategoryID
		{
			get
			{
				return base.Getint(ColumnNames.ProjectCategoryID);
			}
			set
			{
				base.Setint(ColumnNames.ProjectCategoryID, value);
			}
		}

		public virtual string PublicName
		{
			get
			{
				return base.Getstring(ColumnNames.PublicName);
			}
			set
			{
				base.Setstring(ColumnNames.PublicName, value);
			}
		}

		public virtual int OrganizationID
		{
			get
			{
				return base.Getint(ColumnNames.OrganizationID);
			}
			set
			{
				base.Setint(ColumnNames.OrganizationID, value);
			}
		}


		#endregion

		#region String Properties

		public virtual string s_ProjectID
		{
			get
			{
				return this.IsColumnNull(ColumnNames.ProjectID) ? string.Empty : base.GetintAsString(ColumnNames.ProjectID);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectID);
				else
					this.ProjectID = base.SetintAsString(ColumnNames.ProjectID, value);
			}
		}

		public virtual string s_ProjectGroupID
		{
			get
			{
				return this.IsColumnNull(ColumnNames.ProjectGroupID) ? string.Empty : base.GetintAsString(ColumnNames.ProjectGroupID);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectGroupID);
				else
					this.ProjectGroupID = base.SetintAsString(ColumnNames.ProjectGroupID, value);
			}
		}

		public virtual string s_Name
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Name) ? string.Empty : base.GetstringAsString(ColumnNames.Name);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.Name);
				else
					this.Name = base.SetstringAsString(ColumnNames.Name, value);
			}
		}

		public virtual string s_Description
		{
			get
			{
				return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_StartDate
		{
			get
			{
				return this.IsColumnNull(ColumnNames.StartDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.StartDate);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.StartDate);
				else
					this.StartDate = base.SetDateTimeAsString(ColumnNames.StartDate, value);
			}
		}

		public virtual string s_FinishDate
		{
			get
			{
				return this.IsColumnNull(ColumnNames.FinishDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.FinishDate);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.FinishDate);
				else
					this.FinishDate = base.SetDateTimeAsString(ColumnNames.FinishDate, value);
			}
		}

		public virtual string s_ProjectStatusID
		{
			get
			{
				return this.IsColumnNull(ColumnNames.ProjectStatusID) ? string.Empty : base.GetintAsString(ColumnNames.ProjectStatusID);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectStatusID);
				else
					this.ProjectStatusID = base.SetintAsString(ColumnNames.ProjectStatusID, value);
			}
		}

		public virtual string s_ProjectCategoryID
		{
			get
			{
				return this.IsColumnNull(ColumnNames.ProjectCategoryID) ? string.Empty : base.GetintAsString(ColumnNames.ProjectCategoryID);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectCategoryID);
				else
					this.ProjectCategoryID = base.SetintAsString(ColumnNames.ProjectCategoryID, value);
			}
		}

		public virtual string s_PublicName
		{
			get
			{
				return this.IsColumnNull(ColumnNames.PublicName) ? string.Empty : base.GetstringAsString(ColumnNames.PublicName);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.PublicName);
				else
					this.PublicName = base.SetstringAsString(ColumnNames.PublicName, value);
			}
		}

		public virtual string s_OrganizationID
		{
			get
			{
				return this.IsColumnNull(ColumnNames.OrganizationID) ? string.Empty : base.GetintAsString(ColumnNames.OrganizationID);
			}
			set
			{
				if (string.Empty == value)
					this.SetColumnNull(ColumnNames.OrganizationID);
				else
					this.OrganizationID = base.SetintAsString(ColumnNames.OrganizationID, value);
			}
		}


		#endregion

		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}

			public TearOffWhereParameter TearOff
			{
				get
				{
					if (_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}


				public WhereParameter ProjectID
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.ProjectID, Parameters.ProjectID);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter ProjectGroupID
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.ProjectGroupID, Parameters.ProjectGroupID);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Name
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter Description
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter StartDate
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.StartDate, Parameters.StartDate);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter FinishDate
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.FinishDate, Parameters.FinishDate);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter ProjectStatusID
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.ProjectStatusID, Parameters.ProjectStatusID);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter ProjectCategoryID
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.ProjectCategoryID, Parameters.ProjectCategoryID);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter PublicName
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.PublicName, Parameters.PublicName);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}

				public WhereParameter OrganizationID
				{
					get
					{
						WhereParameter where = new WhereParameter(ColumnNames.OrganizationID, Parameters.OrganizationID);
						this._clause._entity.Query.AddWhereParameter(where);
						return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion

			public WhereParameter ProjectID
			{
				get
				{
					if (_ProjectID_W == null)
					{
						_ProjectID_W = TearOff.ProjectID;
					}
					return _ProjectID_W;
				}
			}

			public WhereParameter ProjectGroupID
			{
				get
				{
					if (_ProjectGroupID_W == null)
					{
						_ProjectGroupID_W = TearOff.ProjectGroupID;
					}
					return _ProjectGroupID_W;
				}
			}

			public WhereParameter Name
			{
				get
				{
					if (_Name_W == null)
					{
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public WhereParameter Description
			{
				get
				{
					if (_Description_W == null)
					{
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter StartDate
			{
				get
				{
					if (_StartDate_W == null)
					{
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public WhereParameter FinishDate
			{
				get
				{
					if (_FinishDate_W == null)
					{
						_FinishDate_W = TearOff.FinishDate;
					}
					return _FinishDate_W;
				}
			}

			public WhereParameter ProjectStatusID
			{
				get
				{
					if (_ProjectStatusID_W == null)
					{
						_ProjectStatusID_W = TearOff.ProjectStatusID;
					}
					return _ProjectStatusID_W;
				}
			}

			public WhereParameter ProjectCategoryID
			{
				get
				{
					if (_ProjectCategoryID_W == null)
					{
						_ProjectCategoryID_W = TearOff.ProjectCategoryID;
					}
					return _ProjectCategoryID_W;
				}
			}

			public WhereParameter PublicName
			{
				get
				{
					if (_PublicName_W == null)
					{
						_PublicName_W = TearOff.PublicName;
					}
					return _PublicName_W;
				}
			}

			public WhereParameter OrganizationID
			{
				get
				{
					if (_OrganizationID_W == null)
					{
						_OrganizationID_W = TearOff.OrganizationID;
					}
					return _OrganizationID_W;
				}
			}

			private WhereParameter _ProjectID_W = null;
			private WhereParameter _ProjectGroupID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _StartDate_W = null;
			private WhereParameter _FinishDate_W = null;
			private WhereParameter _ProjectStatusID_W = null;
			private WhereParameter _ProjectCategoryID_W = null;
			private WhereParameter _PublicName_W = null;
			private WhereParameter _OrganizationID_W = null;

			public void WhereClauseReset()
			{
				_ProjectID_W = null;
				_ProjectGroupID_W = null;
				_Name_W = null;
				_Description_W = null;
				_StartDate_W = null;
				_FinishDate_W = null;
				_ProjectStatusID_W = null;
				_ProjectCategoryID_W = null;
				_PublicName_W = null;
				_OrganizationID_W = null;

				this._entity.Query.FlushWhereParameters();

			}

			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;

		}

		public WhereClause Where
		{
			get
			{
				if (_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}

				return _whereClause;
			}
		}

		private WhereClause _whereClause = null;
		#endregion

		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}

			public TearOffAggregateParameter TearOff
			{
				get
				{
					if (_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}


				public AggregateParameter ProjectID
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProjectID, Parameters.ProjectID);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter ProjectGroupID
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProjectGroupID, Parameters.ProjectGroupID);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Name
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter Description
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter StartDate
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.StartDate, Parameters.StartDate);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter FinishDate
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.FinishDate, Parameters.FinishDate);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter ProjectStatusID
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProjectStatusID, Parameters.ProjectStatusID);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter ProjectCategoryID
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProjectCategoryID, Parameters.ProjectCategoryID);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter PublicName
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.PublicName, Parameters.PublicName);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}

				public AggregateParameter OrganizationID
				{
					get
					{
						AggregateParameter aggregate = new AggregateParameter(ColumnNames.OrganizationID, Parameters.OrganizationID);
						this._clause._entity.Query.AddAggregateParameter(aggregate);
						return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion

			public AggregateParameter ProjectID
			{
				get
				{
					if (_ProjectID_W == null)
					{
						_ProjectID_W = TearOff.ProjectID;
					}
					return _ProjectID_W;
				}
			}

			public AggregateParameter ProjectGroupID
			{
				get
				{
					if (_ProjectGroupID_W == null)
					{
						_ProjectGroupID_W = TearOff.ProjectGroupID;
					}
					return _ProjectGroupID_W;
				}
			}

			public AggregateParameter Name
			{
				get
				{
					if (_Name_W == null)
					{
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public AggregateParameter Description
			{
				get
				{
					if (_Description_W == null)
					{
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter StartDate
			{
				get
				{
					if (_StartDate_W == null)
					{
						_StartDate_W = TearOff.StartDate;
					}
					return _StartDate_W;
				}
			}

			public AggregateParameter FinishDate
			{
				get
				{
					if (_FinishDate_W == null)
					{
						_FinishDate_W = TearOff.FinishDate;
					}
					return _FinishDate_W;
				}
			}

			public AggregateParameter ProjectStatusID
			{
				get
				{
					if (_ProjectStatusID_W == null)
					{
						_ProjectStatusID_W = TearOff.ProjectStatusID;
					}
					return _ProjectStatusID_W;
				}
			}

			public AggregateParameter ProjectCategoryID
			{
				get
				{
					if (_ProjectCategoryID_W == null)
					{
						_ProjectCategoryID_W = TearOff.ProjectCategoryID;
					}
					return _ProjectCategoryID_W;
				}
			}

			public AggregateParameter PublicName
			{
				get
				{
					if (_PublicName_W == null)
					{
						_PublicName_W = TearOff.PublicName;
					}
					return _PublicName_W;
				}
			}

			public AggregateParameter OrganizationID
			{
				get
				{
					if (_OrganizationID_W == null)
					{
						_OrganizationID_W = TearOff.OrganizationID;
					}
					return _OrganizationID_W;
				}
			}

			private AggregateParameter _ProjectID_W = null;
			private AggregateParameter _ProjectGroupID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _StartDate_W = null;
			private AggregateParameter _FinishDate_W = null;
			private AggregateParameter _ProjectStatusID_W = null;
			private AggregateParameter _ProjectCategoryID_W = null;
			private AggregateParameter _PublicName_W = null;
			private AggregateParameter _OrganizationID_W = null;

			public void AggregateClauseReset()
			{
				_ProjectID_W = null;
				_ProjectGroupID_W = null;
				_Name_W = null;
				_Description_W = null;
				_StartDate_W = null;
				_FinishDate_W = null;
				_ProjectStatusID_W = null;
				_ProjectCategoryID_W = null;
				_PublicName_W = null;
				_OrganizationID_W = null;

				this._entity.Query.FlushAggregateParameters();

			}

			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;

		}

		public AggregateClause Aggregate
		{
			get
			{
				if (_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}

				return _aggregateClause;
			}
		}

		private AggregateClause _aggregateClause = null;
		#endregion

		protected override IDbCommand GetInsertCommand()
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "InsertProject]";

			CreateParameters(cmd);

			SqlParameter p;
			p = cmd.Parameters[Parameters.ProjectID.ParameterName];
			p.Direction = ParameterDirection.Output;

			return cmd;
		}

		protected override IDbCommand GetUpdateCommand()
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "UpdateProject]";

			CreateParameters(cmd);

			return cmd;
		}

		protected override IDbCommand GetDeleteCommand()
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "DeleteProject]";

			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ProjectID);
			p.SourceColumn = ColumnNames.ProjectID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}

		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;

			p = cmd.Parameters.Add(Parameters.ProjectID);
			p.SourceColumn = ColumnNames.ProjectID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProjectGroupID);
			p.SourceColumn = ColumnNames.ProjectGroupID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StartDate);
			p.SourceColumn = ColumnNames.StartDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.FinishDate);
			p.SourceColumn = ColumnNames.FinishDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProjectStatusID);
			p.SourceColumn = ColumnNames.ProjectStatusID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProjectCategoryID);
			p.SourceColumn = ColumnNames.ProjectCategoryID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PublicName);
			p.SourceColumn = ColumnNames.PublicName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.OrganizationID);
			p.SourceColumn = ColumnNames.OrganizationID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}