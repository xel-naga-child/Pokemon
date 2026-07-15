using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using PokeCommonHelper.Services;
using PokeDbConn.Types

namespace PokeDbConn.Interfaces
{
    public interface IBaseConn: IDisposable
    {
        IDbTransaction BeginTrans();
        void Commit();
        void Rollback();
        void Close();
        void Open();
        bool IsIgnoredError(Exception ex);
        IsolationLevel IsolationLevelAsing();
        ApplicationMessages Messages();
        IEnumerable<dynamic> ExecProc(string procedureName, Parameters param);
        int ExecSqlCommand(string sql, Parameters param = null);
        IEnumerable<dynamic> ExecSqlQuery(string sql, Parameters param = null);
        Task<IEnumerable<dynamic>> ExecProcAsync(string procedureName, Parameters param);
    }
}
