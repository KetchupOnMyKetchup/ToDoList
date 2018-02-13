using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using ToDoListDataAPI.Models;
using System.Configuration;
using System.Data;
using Dapper;

namespace ToDoListDataAPI.Repo
{
    public class ToDoListRepo
    {
        public T DbConnection<T>(Func<IDbConnection, T> getData)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["todoItems"].ConnectionString;
                conn.Open();

                return getData(conn);
            }
        }

        public IEnumerable<ToDoItem> GetTodoItems()
        {
            return DbConnection(conn =>
                conn.Query<ToDoItem>("dbo.GetItems", commandType: CommandType.StoredProcedure).ToList());
        }


        public void EditDescription(ToDoItem toDoItem)
        {
            DbConnection(conn =>
                conn.Execute("dbo.UpdateItem", toDoItem, commandType: CommandType.StoredProcedure));
        }

        public void DeleteById(int id)
        {
            DbConnection(conn =>
                conn.Execute("dbo.DeleteItemById", new { id }, commandType: CommandType.StoredProcedure));
        }

        public ToDoItem GetTodoItemById(int id)
        {
            return DbConnection(conn =>
                conn.QuerySingle<ToDoItem>("dbo.GetItemById", new { id }, commandType: CommandType.StoredProcedure));
        }

        public void InsertTodoItem(ToDoItem toDoItem)
        {
            int id;
            DbConnection(conn =>
                id = conn.ExecuteScalar<int>("dbo.InsertItem", new {toDoItem.Description}, commandType: CommandType.StoredProcedure));
        }
    }
}