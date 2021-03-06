﻿/*
'===============================================================================
'  Generated From - CSharp_dOOdads_View.vbgen
'
'  The supporting base class SqlClientEntity is in the 
'  Architecture directory in "dOOdads".
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
	public class ActivityLogView : SqlClientEntity
	{
		public ActivityLogView()
		{
			this.QuerySource = "ActivityLogView";
			this.MappingName = "ActivityLogView";
		}	
	
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			return base.Query.Load();
		}
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
	
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ActivityLogID
			{
				get
				{
					return new SqlParameter("@ActivityLogID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ActivityTypeID
			{
				get
				{
					return new SqlParameter("@ActivityTypeID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ObjectID
			{
				get
				{
					return new SqlParameter("@ObjectID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ObjectReferenceID
			{
				get
				{
					return new SqlParameter("@ObjectReferenceID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserID
			{
				get
				{
					return new SqlParameter("@UserID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter UserName
			{
				get
				{
					return new SqlParameter("@UserName", SqlDbType.VarChar, 100);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.VarChar, 8000);
				}
			}
			
			public static SqlParameter DateLog
			{
				get
				{
					return new SqlParameter("@DateLog", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ActivityTypeName
			{
				get
				{
					return new SqlParameter("@ActivityTypeName", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ObjectName
			{
				get
				{
					return new SqlParameter("@ObjectName", SqlDbType.VarChar, 100);
				}
			}
			
			public static SqlParameter Login
			{
				get
				{
					return new SqlParameter("@Login", SqlDbType.VarChar, 50);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ActivityLogID = "ActivityLogID";
            public const string ActivityTypeID = "ActivityTypeID";
            public const string ObjectID = "ObjectID";
            public const string ObjectReferenceID = "ObjectReferenceID";
            public const string UserID = "UserID";
            public const string UserName = "UserName";
            public const string Description = "Description";
            public const string DateLog = "DateLog";
            public const string ActivityTypeName = "ActivityTypeName";
            public const string ObjectName = "ObjectName";
            public const string Login = "Login";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ActivityLogID] = ActivityLogView.PropertyNames.ActivityLogID;
					ht[ActivityTypeID] = ActivityLogView.PropertyNames.ActivityTypeID;
					ht[ObjectID] = ActivityLogView.PropertyNames.ObjectID;
					ht[ObjectReferenceID] = ActivityLogView.PropertyNames.ObjectReferenceID;
					ht[UserID] = ActivityLogView.PropertyNames.UserID;
					ht[UserName] = ActivityLogView.PropertyNames.UserName;
					ht[Description] = ActivityLogView.PropertyNames.Description;
					ht[DateLog] = ActivityLogView.PropertyNames.DateLog;
					ht[ActivityTypeName] = ActivityLogView.PropertyNames.ActivityTypeName;
					ht[ObjectName] = ActivityLogView.PropertyNames.ObjectName;
					ht[Login] = ActivityLogView.PropertyNames.Login;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ActivityLogID = "ActivityLogID";
            public const string ActivityTypeID = "ActivityTypeID";
            public const string ObjectID = "ObjectID";
            public const string ObjectReferenceID = "ObjectReferenceID";
            public const string UserID = "UserID";
            public const string UserName = "UserName";
            public const string Description = "Description";
            public const string DateLog = "DateLog";
            public const string ActivityTypeName = "ActivityTypeName";
            public const string ObjectName = "ObjectName";
            public const string Login = "Login";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ActivityLogID] = ActivityLogView.ColumnNames.ActivityLogID;
					ht[ActivityTypeID] = ActivityLogView.ColumnNames.ActivityTypeID;
					ht[ObjectID] = ActivityLogView.ColumnNames.ObjectID;
					ht[ObjectReferenceID] = ActivityLogView.ColumnNames.ObjectReferenceID;
					ht[UserID] = ActivityLogView.ColumnNames.UserID;
					ht[UserName] = ActivityLogView.ColumnNames.UserName;
					ht[Description] = ActivityLogView.ColumnNames.Description;
					ht[DateLog] = ActivityLogView.ColumnNames.DateLog;
					ht[ActivityTypeName] = ActivityLogView.ColumnNames.ActivityTypeName;
					ht[ObjectName] = ActivityLogView.ColumnNames.ObjectName;
					ht[Login] = ActivityLogView.ColumnNames.Login;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ActivityLogID = "s_ActivityLogID";
            public const string ActivityTypeID = "s_ActivityTypeID";
            public const string ObjectID = "s_ObjectID";
            public const string ObjectReferenceID = "s_ObjectReferenceID";
            public const string UserID = "s_UserID";
            public const string UserName = "s_UserName";
            public const string Description = "s_Description";
            public const string DateLog = "s_DateLog";
            public const string ActivityTypeName = "s_ActivityTypeName";
            public const string ObjectName = "s_ObjectName";
            public const string Login = "s_Login";

		}
		#endregion	
		
		#region Properties
			public virtual int ActivityLogID
	    {
			get
	        {
				return base.Getint(ColumnNames.ActivityLogID);
			}
			set
	        {
				base.Setint(ColumnNames.ActivityLogID, value);
			}
		}

		public virtual int ActivityTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.ActivityTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.ActivityTypeID, value);
			}
		}

		public virtual int ObjectID
	    {
			get
	        {
				return base.Getint(ColumnNames.ObjectID);
			}
			set
	        {
				base.Setint(ColumnNames.ObjectID, value);
			}
		}

		public virtual int ObjectReferenceID
	    {
			get
	        {
				return base.Getint(ColumnNames.ObjectReferenceID);
			}
			set
	        {
				base.Setint(ColumnNames.ObjectReferenceID, value);
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

		public virtual string UserName
	    {
			get
	        {
				return base.Getstring(ColumnNames.UserName);
			}
			set
	        {
				base.Setstring(ColumnNames.UserName, value);
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

		public virtual DateTime DateLog
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.DateLog);
			}
			set
	        {
				base.SetDateTime(ColumnNames.DateLog, value);
			}
		}

		public virtual int ActivityTypeName
	    {
			get
	        {
				return base.Getint(ColumnNames.ActivityTypeName);
			}
			set
	        {
				base.Setint(ColumnNames.ActivityTypeName, value);
			}
		}

		public virtual string ObjectName
	    {
			get
	        {
				return base.Getstring(ColumnNames.ObjectName);
			}
			set
	        {
				base.Setstring(ColumnNames.ObjectName, value);
			}
		}

		public virtual string Login
	    {
			get
	        {
				return base.Getstring(ColumnNames.Login);
			}
			set
	        {
				base.Setstring(ColumnNames.Login, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ActivityLogID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ActivityLogID) ? string.Empty : base.GetintAsString(ColumnNames.ActivityLogID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ActivityLogID);
				else
					this.ActivityLogID = base.SetintAsString(ColumnNames.ActivityLogID, value);
			}
		}

		public virtual string s_ActivityTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ActivityTypeID) ? string.Empty : base.GetintAsString(ColumnNames.ActivityTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ActivityTypeID);
				else
					this.ActivityTypeID = base.SetintAsString(ColumnNames.ActivityTypeID, value);
			}
		}

		public virtual string s_ObjectID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ObjectID) ? string.Empty : base.GetintAsString(ColumnNames.ObjectID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ObjectID);
				else
					this.ObjectID = base.SetintAsString(ColumnNames.ObjectID, value);
			}
		}

		public virtual string s_ObjectReferenceID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ObjectReferenceID) ? string.Empty : base.GetintAsString(ColumnNames.ObjectReferenceID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ObjectReferenceID);
				else
					this.ObjectReferenceID = base.SetintAsString(ColumnNames.ObjectReferenceID, value);
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

		public virtual string s_UserName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.UserName) ? string.Empty : base.GetstringAsString(ColumnNames.UserName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.UserName);
				else
					this.UserName = base.SetstringAsString(ColumnNames.UserName, value);
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
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_DateLog
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.DateLog) ? string.Empty : base.GetDateTimeAsString(ColumnNames.DateLog);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.DateLog);
				else
					this.DateLog = base.SetDateTimeAsString(ColumnNames.DateLog, value);
			}
		}

		public virtual string s_ActivityTypeName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ActivityTypeName) ? string.Empty : base.GetintAsString(ColumnNames.ActivityTypeName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ActivityTypeName);
				else
					this.ActivityTypeName = base.SetintAsString(ColumnNames.ActivityTypeName, value);
			}
		}

		public virtual string s_ObjectName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ObjectName) ? string.Empty : base.GetstringAsString(ColumnNames.ObjectName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ObjectName);
				else
					this.ObjectName = base.SetstringAsString(ColumnNames.ObjectName, value);
			}
		}

		public virtual string s_Login
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Login) ? string.Empty : base.GetstringAsString(ColumnNames.Login);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Login);
				else
					this.Login = base.SetstringAsString(ColumnNames.Login, value);
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
				
				
				public WhereParameter ActivityLogID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ActivityLogID, Parameters.ActivityLogID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ActivityTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ActivityTypeID, Parameters.ActivityTypeID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ObjectID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ObjectID, Parameters.ObjectID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ObjectReferenceID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ObjectReferenceID, Parameters.ObjectReferenceID);
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

				public WhereParameter UserName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.UserName, Parameters.UserName);
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

				public WhereParameter DateLog
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.DateLog, Parameters.DateLog);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ActivityTypeName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ActivityTypeName, Parameters.ActivityTypeName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ObjectName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ObjectName, Parameters.ObjectName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Login
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Login, Parameters.Login);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ActivityLogID
		    {
				get
		        {
					if(_ActivityLogID_W == null)
	        	    {
						_ActivityLogID_W = TearOff.ActivityLogID;
					}
					return _ActivityLogID_W;
				}
			}

			public WhereParameter ActivityTypeID
		    {
				get
		        {
					if(_ActivityTypeID_W == null)
	        	    {
						_ActivityTypeID_W = TearOff.ActivityTypeID;
					}
					return _ActivityTypeID_W;
				}
			}

			public WhereParameter ObjectID
		    {
				get
		        {
					if(_ObjectID_W == null)
	        	    {
						_ObjectID_W = TearOff.ObjectID;
					}
					return _ObjectID_W;
				}
			}

			public WhereParameter ObjectReferenceID
		    {
				get
		        {
					if(_ObjectReferenceID_W == null)
	        	    {
						_ObjectReferenceID_W = TearOff.ObjectReferenceID;
					}
					return _ObjectReferenceID_W;
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

			public WhereParameter UserName
		    {
				get
		        {
					if(_UserName_W == null)
	        	    {
						_UserName_W = TearOff.UserName;
					}
					return _UserName_W;
				}
			}

			public WhereParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter DateLog
		    {
				get
		        {
					if(_DateLog_W == null)
	        	    {
						_DateLog_W = TearOff.DateLog;
					}
					return _DateLog_W;
				}
			}

			public WhereParameter ActivityTypeName
		    {
				get
		        {
					if(_ActivityTypeName_W == null)
	        	    {
						_ActivityTypeName_W = TearOff.ActivityTypeName;
					}
					return _ActivityTypeName_W;
				}
			}

			public WhereParameter ObjectName
		    {
				get
		        {
					if(_ObjectName_W == null)
	        	    {
						_ObjectName_W = TearOff.ObjectName;
					}
					return _ObjectName_W;
				}
			}

			public WhereParameter Login
		    {
				get
		        {
					if(_Login_W == null)
	        	    {
						_Login_W = TearOff.Login;
					}
					return _Login_W;
				}
			}

			private WhereParameter _ActivityLogID_W = null;
			private WhereParameter _ActivityTypeID_W = null;
			private WhereParameter _ObjectID_W = null;
			private WhereParameter _ObjectReferenceID_W = null;
			private WhereParameter _UserID_W = null;
			private WhereParameter _UserName_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _DateLog_W = null;
			private WhereParameter _ActivityTypeName_W = null;
			private WhereParameter _ObjectName_W = null;
			private WhereParameter _Login_W = null;

			public void WhereClauseReset()
			{
				_ActivityLogID_W = null;
				_ActivityTypeID_W = null;
				_ObjectID_W = null;
				_ObjectReferenceID_W = null;
				_UserID_W = null;
				_UserName_W = null;
				_Description_W = null;
				_DateLog_W = null;
				_ActivityTypeName_W = null;
				_ObjectName_W = null;
				_Login_W = null;

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
				
				
				public AggregateParameter ActivityLogID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ActivityLogID, Parameters.ActivityLogID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ActivityTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ActivityTypeID, Parameters.ActivityTypeID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ObjectID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ObjectID, Parameters.ObjectID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ObjectReferenceID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ObjectReferenceID, Parameters.ObjectReferenceID);
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

				public AggregateParameter UserName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.UserName, Parameters.UserName);
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

				public AggregateParameter DateLog
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.DateLog, Parameters.DateLog);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ActivityTypeName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ActivityTypeName, Parameters.ActivityTypeName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ObjectName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ObjectName, Parameters.ObjectName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Login
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Login, Parameters.Login);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ActivityLogID
		    {
				get
		        {
					if(_ActivityLogID_W == null)
	        	    {
						_ActivityLogID_W = TearOff.ActivityLogID;
					}
					return _ActivityLogID_W;
				}
			}

			public AggregateParameter ActivityTypeID
		    {
				get
		        {
					if(_ActivityTypeID_W == null)
	        	    {
						_ActivityTypeID_W = TearOff.ActivityTypeID;
					}
					return _ActivityTypeID_W;
				}
			}

			public AggregateParameter ObjectID
		    {
				get
		        {
					if(_ObjectID_W == null)
	        	    {
						_ObjectID_W = TearOff.ObjectID;
					}
					return _ObjectID_W;
				}
			}

			public AggregateParameter ObjectReferenceID
		    {
				get
		        {
					if(_ObjectReferenceID_W == null)
	        	    {
						_ObjectReferenceID_W = TearOff.ObjectReferenceID;
					}
					return _ObjectReferenceID_W;
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

			public AggregateParameter UserName
		    {
				get
		        {
					if(_UserName_W == null)
	        	    {
						_UserName_W = TearOff.UserName;
					}
					return _UserName_W;
				}
			}

			public AggregateParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter DateLog
		    {
				get
		        {
					if(_DateLog_W == null)
	        	    {
						_DateLog_W = TearOff.DateLog;
					}
					return _DateLog_W;
				}
			}

			public AggregateParameter ActivityTypeName
		    {
				get
		        {
					if(_ActivityTypeName_W == null)
	        	    {
						_ActivityTypeName_W = TearOff.ActivityTypeName;
					}
					return _ActivityTypeName_W;
				}
			}

			public AggregateParameter ObjectName
		    {
				get
		        {
					if(_ObjectName_W == null)
	        	    {
						_ObjectName_W = TearOff.ObjectName;
					}
					return _ObjectName_W;
				}
			}

			public AggregateParameter Login
		    {
				get
		        {
					if(_Login_W == null)
	        	    {
						_Login_W = TearOff.Login;
					}
					return _Login_W;
				}
			}

			private AggregateParameter _ActivityLogID_W = null;
			private AggregateParameter _ActivityTypeID_W = null;
			private AggregateParameter _ObjectID_W = null;
			private AggregateParameter _ObjectReferenceID_W = null;
			private AggregateParameter _UserID_W = null;
			private AggregateParameter _UserName_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _DateLog_W = null;
			private AggregateParameter _ActivityTypeName_W = null;
			private AggregateParameter _ObjectName_W = null;
			private AggregateParameter _Login_W = null;

			public void AggregateClauseReset()
			{
				_ActivityLogID_W = null;
				_ActivityTypeID_W = null;
				_ObjectID_W = null;
				_ObjectReferenceID_W = null;
				_UserID_W = null;
				_UserName_W = null;
				_Description_W = null;
				_DateLog_W = null;
				_ActivityTypeName_W = null;
				_ObjectName_W = null;
				_Login_W = null;

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
			return null;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
			return null;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
			return null;
		}
	}
}
