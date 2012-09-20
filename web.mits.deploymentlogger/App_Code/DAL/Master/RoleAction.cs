
// Generated by MyGeneration Version # (1.1.5.1)

using System;
using DL_DAL.Master;
using System.Collections.Specialized;
using System.Data;

namespace DL_WEB.DAL.Master
{
    public class RoleAction : _RoleAction
    {
        public RoleAction()
        {
            base.ConnectionString = Master.DBConnectionString;
        }

        public virtual DataTable LoadRoleActionsByRoleID(int RoleID)
        {
            ListDictionary parameters = new ListDictionary(); 
            parameters.Add(Parameters.RoleID, RoleID);
            base.LoadFromSql("[" + base.SchemaStoredProcedure + "LoadRoleActionsByRoleID]", parameters); 
            return base.DataTable;		
            /*

            DataTable dt;
            using (SqlConnection conClient = new SqlConnection(MyGeneration.dOOdads.BusinessEntity.StaticConnectionString))
            {
                conClient.Open();
                SqlCommand cmdLoadRoles = new SqlCommand("LoadRoleActionsByRoleID", conClient);
                cmdLoadRoles.CommandType = CommandType.StoredProcedure;
                cmdLoadRoles.Parameters.Add("RoleID", SqlDbType.Int);
                cmdLoadRoles.Parameters["RoleID"].Value = RoleID;
                SqlDataAdapter da = new SqlDataAdapter(cmdLoadRoles);
                dt = new DataTable();
                da.Fill(dt);
            }
            return dt;
             */
        }
    }
}