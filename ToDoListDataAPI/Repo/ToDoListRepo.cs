using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using ToDoListDataAPI.Models;
using System.Configuration;
using System.Data;

namespace ToDoListDataAPI.Repo
{
    public class ToDoListRepo
    {

        public IEnumerable<ToDoItem> GetTodoItems()
        {
            var data = new List<ToDoItem>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["todoItems"].ConnectionString;

                using (var command = new SqlCommand("GetItems", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(new ToDoItem()
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("ID")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                            });
                        }

                    }
                }
            }

            return data;
        }

        internal void EditDescription(ToDoItem toDoItem)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["todoItems"].ConnectionString;

                using (var command = new SqlCommand("UpdateItem", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter("@id", toDoItem.ID));
                    command.Parameters.Add(new SqlParameter("@description", toDoItem.Description));

                    conn.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        internal void DeleteById(int id)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["todoItems"].ConnectionString;

                using (var command = new SqlCommand("DeleteItemById", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter("@id", id));

                    conn.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public ToDoItem GetTodoItemById(int id)
        {
            ToDoItem toDoItem = new ToDoItem();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["todoItems"].ConnectionString;

                using (var command = new SqlCommand("GetItemById", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            toDoItem.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            toDoItem.Description = reader.GetString(reader.GetOrdinal("Description"));
                        }

                    }
                }
            }

            return toDoItem;
        }

        public void InsertTodoItem(ToDoItem toDoItem)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["todoItems"].ConnectionString;

                using (var command = new SqlCommand("InsertItem", conn)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter("@id", toDoItem.ID));
                    command.Parameters.Add(new SqlParameter("@description", toDoItem.Description));

                    conn.Open();

                    command.ExecuteNonQuery();
                }
            }

        }
    }
}