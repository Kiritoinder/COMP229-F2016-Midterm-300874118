using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMP229_F2016_MidTerm_300874118.Models;
/* Author: Inderjeet Singh
 * Student ID: 300874118
 * Date Modified: 19-Oct-2016
 * version 1.0.0.1
 * file:TodoList.aspx
 */
namespace COMP229_F2016_MidTerm_300874118
{
    public partial class TodoList : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get the student data
                this.GetTodo();
            }
        }

        /// <summary>
        /// This method gets the student data from the DB
        /// </summary>
        private void GetTodo()
        {
            // connect to EF DB
            using ( TodoConnection db = new TodoConnection())
            {
                // query the Student Table using EF and LINQ
                var Todo = (from allTodo in db.ToDo select allTodo);

                // bind the result to the Students GridView
                TodoListGridView.DataSource = Todo.ToList();
                TodoListGridView.DataBind();
            }
        }
        protected void TodoListGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            // store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected StudentID using the Grid's DataKey collection
            int TodoID = Convert.ToInt32(TodoListGridView.DataKeys[selectedRow].Values["Todo ID"]);

            // use EF and LINQ to find the selected student in the DB and remove it
            using (TodoConnection db = new TodoConnection())
            {
                // create object ot the student clas and store the query inside of it
                ToDo deletednote = (from todoRecords in db.ToDo
                                          where todoRecords.TodoID == TodoID
                                    select todoRecords).FirstOrDefault();

                // remove the selected student from the db
                db.ToDo.Remove(deletednote);

                // save my changes back to the db
                db.SaveChanges();

                // refresh the grid
                this.GetTodo();
            }


        }


    }
}