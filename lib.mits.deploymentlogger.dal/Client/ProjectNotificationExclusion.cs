﻿
/*
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

// Generated by MyGeneration Version # (1.1.5.0)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DL_DAL.Client
{
	public abstract class _ProjectNotificationExclusion : SqlClientEntity
	{
		public _ProjectNotificationExclusion()
		{
			this.QuerySource = "ProjectNotificationExclusion";
			this.MappingName = "ProjectNotificationExclusion";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "LoadAllProjectNotificationExclusion]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ProjectNotificationExclusionID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ProjectNotificationExclusionID, ProjectNotificationExclusionID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "LoadProjectNotificationExclusionByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ProjectNotificationExclusionID
			{
				get
				{
					return new SqlParameter("@ProjectNotificationExclusionID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter AddressBookEntryID
			{
				get
				{
					return new SqlParameter("@AddressBookEntryID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter NotificationTypeID
			{
				get
				{
					return new SqlParameter("@NotificationTypeID", SqlDbType.Int, 0);
				}
			}
			
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
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ProjectNotificationExclusionID = "ProjectNotificationExclusionID";
            public const string UserID = "UserID";
            public const string AddressBookEntryID = "AddressBookEntryID";
            public const string NotificationTypeID = "NotificationTypeID";
            public const string ProjectID = "ProjectID";
            public const string ProjectGroupID = "ProjectGroupID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ProjectNotificationExclusionID] = _ProjectNotificationExclusion.PropertyNames.ProjectNotificationExclusionID;
					ht[UserID] = _ProjectNotificationExclusion.PropertyNames.UserID;
					ht[AddressBookEntryID] = _ProjectNotificationExclusion.PropertyNames.AddressBookEntryID;
					ht[NotificationTypeID] = _ProjectNotificationExclusion.PropertyNames.NotificationTypeID;
					ht[ProjectID] = _ProjectNotificationExclusion.PropertyNames.ProjectID;
					ht[ProjectGroupID] = _ProjectNotificationExclusion.PropertyNames.ProjectGroupID;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ProjectNotificationExclusionID = "ProjectNotificationExclusionID";
            public const string UserID = "UserID";
            public const string AddressBookEntryID = "AddressBookEntryID";
            public const string NotificationTypeID = "NotificationTypeID";
            public const string ProjectID = "ProjectID";
            public const string ProjectGroupID = "ProjectGroupID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ProjectNotificationExclusionID] = _ProjectNotificationExclusion.ColumnNames.ProjectNotificationExclusionID;
					ht[UserID] = _ProjectNotificationExclusion.ColumnNames.UserID;
					ht[AddressBookEntryID] = _ProjectNotificationExclusion.ColumnNames.AddressBookEntryID;
					ht[NotificationTypeID] = _ProjectNotificationExclusion.ColumnNames.NotificationTypeID;
					ht[ProjectID] = _ProjectNotificationExclusion.ColumnNames.ProjectID;
					ht[ProjectGroupID] = _ProjectNotificationExclusion.ColumnNames.ProjectGroupID;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ProjectNotificationExclusionID = "s_ProjectNotificationExclusionID";
            public const string UserID = "s_UserID";
            public const string AddressBookEntryID = "s_AddressBookEntryID";
            public const string NotificationTypeID = "s_NotificationTypeID";
            public const string ProjectID = "s_ProjectID";
            public const string ProjectGroupID = "s_ProjectGroupID";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ProjectNotificationExclusionID
	    {
			get
	        {
				return base.Getint(ColumnNames.ProjectNotificationExclusionID);
			}
			set
	        {
				base.Setint(ColumnNames.ProjectNotificationExclusionID, value);
			}
		}

		public virtual int UserID
	    {
			get
	        {
				return base.Getint(ColumnNames.UserID);
			}
			set
	        {
				base.Setint(ColumnNames.UserID, value);
			}
		}

		public virtual int AddressBookEntryID
	    {
			get
	        {
				return base.Getint(ColumnNames.AddressBookEntryID);
			}
			set
	        {
				base.Setint(ColumnNames.AddressBookEntryID, value);
			}
		}

		public virtual int NotificationTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.NotificationTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.NotificationTypeID, value);
			}
		}

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


		#endregion
		
		#region String Properties
	
		public virtual string s_ProjectNotificationExclusionID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ProjectNotificationExclusionID) ? string.Empty : base.GetintAsString(ColumnNames.ProjectNotificationExclusionID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectNotificationExclusionID);
				else
					this.ProjectNotificationExclusionID = base.SetintAsString(ColumnNames.ProjectNotificationExclusionID, value);
			}
		}

		public virtual string s_UserID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserID) ? string.Empty : base.GetintAsString(ColumnNames.UserID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserID);
				else
					this.UserID = base.SetintAsString(ColumnNames.UserID, value);
			}
		}

		public virtual string s_AddressBookEntryID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.AddressBookEntryID) ? string.Empty : base.GetintAsString(ColumnNames.AddressBookEntryID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.AddressBookEntryID);
				else
					this.AddressBookEntryID = base.SetintAsString(ColumnNames.AddressBookEntryID, value);
			}
		}

		public virtual string s_NotificationTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.NotificationTypeID) ? string.Empty : base.GetintAsString(ColumnNames.NotificationTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.NotificationTypeID);
				else
					this.NotificationTypeID = base.SetintAsString(ColumnNames.NotificationTypeID, value);
			}
		}

		public virtual string s_ProjectID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ProjectID) ? string.Empty : base.GetintAsString(ColumnNames.ProjectID);
			}
			set
	        {
				if(string.Empty == value)
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
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ProjectGroupID);
				else
					this.ProjectGroupID = base.SetintAsString(ColumnNames.ProjectGroupID, value);
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
					if(_tearOff == null)
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
				
				
				public WhereParameter ProjectNotificationExclusionID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ProjectNotificationExclusionID, Parameters.ProjectNotificationExclusionID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter UserID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter AddressBookEntryID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.AddressBookEntryID, Parameters.AddressBookEntryID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter NotificationTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.NotificationTypeID, Parameters.NotificationTypeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
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


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ProjectNotificationExclusionID
		    {
				get
		        {
					if(_ProjectNotificationExclusionID_W == null)
	        	    {
						_ProjectNotificationExclusionID_W = TearOff.ProjectNotificationExclusionID;
					}
					return _ProjectNotificationExclusionID_W;
				}
			}

			public WhereParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public WhereParameter AddressBookEntryID
		    {
				get
		        {
					if(_AddressBookEntryID_W == null)
	        	    {
						_AddressBookEntryID_W = TearOff.AddressBookEntryID;
					}
					return _AddressBookEntryID_W;
				}
			}

			public WhereParameter NotificationTypeID
		    {
				get
		        {
					if(_NotificationTypeID_W == null)
	        	    {
						_NotificationTypeID_W = TearOff.NotificationTypeID;
					}
					return _NotificationTypeID_W;
				}
			}

			public WhereParameter ProjectID
		    {
				get
		        {
					if(_ProjectID_W == null)
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
					if(_ProjectGroupID_W == null)
	        	    {
						_ProjectGroupID_W = TearOff.ProjectGroupID;
					}
					return _ProjectGroupID_W;
				}
			}

			private WhereParameter _ProjectNotificationExclusionID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _AddressBookEntryID_W = null;
			private WhereParameter _NotificationTypeID_W = null;
			private WhereParameter _ProjectID_W = null;
			private WhereParameter _ProjectGroupID_W = null;

			public void WhereClauseReset()
			{
				_ProjectNotificationExclusionID_W = null;
				_UserID_W = null;
				_AddressBookEntryID_W = null;
				_NotificationTypeID_W = null;
				_ProjectID_W = null;
				_ProjectGroupID_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
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
					if(_tearOff == null)
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
				
				
				public AggregateParameter ProjectNotificationExclusionID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ProjectNotificationExclusionID, Parameters.ProjectNotificationExclusionID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter UserID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserID, Parameters.UserID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter AddressBookEntryID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.AddressBookEntryID, Parameters.AddressBookEntryID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter NotificationTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.NotificationTypeID, Parameters.NotificationTypeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
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


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ProjectNotificationExclusionID
		    {
				get
		        {
					if(_ProjectNotificationExclusionID_W == null)
	        	    {
						_ProjectNotificationExclusionID_W = TearOff.ProjectNotificationExclusionID;
					}
					return _ProjectNotificationExclusionID_W;
				}
			}

			public AggregateParameter UserID
		    {
				get
		        {
					if(_UserID_W == null)
	        	    {
						_UserID_W = TearOff.UserID;
					}
					return _UserID_W;
				}
			}

			public AggregateParameter AddressBookEntryID
		    {
				get
		        {
					if(_AddressBookEntryID_W == null)
	        	    {
						_AddressBookEntryID_W = TearOff.AddressBookEntryID;
					}
					return _AddressBookEntryID_W;
				}
			}

			public AggregateParameter NotificationTypeID
		    {
				get
		        {
					if(_NotificationTypeID_W == null)
	        	    {
						_NotificationTypeID_W = TearOff.NotificationTypeID;
					}
					return _NotificationTypeID_W;
				}
			}

			public AggregateParameter ProjectID
		    {
				get
		        {
					if(_ProjectID_W == null)
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
					if(_ProjectGroupID_W == null)
	        	    {
						_ProjectGroupID_W = TearOff.ProjectGroupID;
					}
					return _ProjectGroupID_W;
				}
			}

			private AggregateParameter _ProjectNotificationExclusionID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _AddressBookEntryID_W = null;
			private AggregateParameter _NotificationTypeID_W = null;
			private AggregateParameter _ProjectID_W = null;
			private AggregateParameter _ProjectGroupID_W = null;

			public void AggregateClauseReset()
			{
				_ProjectNotificationExclusionID_W = null;
				_UserID_W = null;
				_AddressBookEntryID_W = null;
				_NotificationTypeID_W = null;
				_ProjectID_W = null;
				_ProjectGroupID_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "InsertProjectNotificationExclusion]";
	
			CreateParameters(cmd);
			    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "UpdateProjectNotificationExclusion]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "DeleteProjectNotificationExclusion]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ProjectNotificationExclusionID);
			p.SourceColumn = ColumnNames.ProjectNotificationExclusionID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ProjectNotificationExclusionID);
			p.SourceColumn = ColumnNames.ProjectNotificationExclusionID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.UserID);
			p.SourceColumn = ColumnNames.UserID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.AddressBookEntryID);
			p.SourceColumn = ColumnNames.AddressBookEntryID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.NotificationTypeID);
			p.SourceColumn = ColumnNames.NotificationTypeID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProjectID);
			p.SourceColumn = ColumnNames.ProjectID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ProjectGroupID);
			p.SourceColumn = ColumnNames.ProjectGroupID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
