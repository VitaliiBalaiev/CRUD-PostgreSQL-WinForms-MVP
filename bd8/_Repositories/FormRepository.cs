using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bd8.Models;
using Npgsql;

namespace bd8._Repositories
{
    public class FormRepository : BaseRepository, IFormRepository
    {
        public FormRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(FormModel formModel) // Add new form
        {
            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "INSERT INTO form VALUES (DEFAULT, '" + formModel.FormName + "'," +
                                                                     "'" + formModel.NumberOfStudents + "'," +
                                                                      "" + formModel.IdTeacher + ");";
                command.ExecuteNonQuery();
            }
        }

        public void Delete(FormModel formModel) // Delete form
        {
            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "DELETE FROM form WHERE name ='" + formModel.FormName + "'";
                command.ExecuteNonQuery();
            }
        }

        public void Edit(FormModel formModel) // Edit form info 
        {
            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "UPDATE form SET name = '" + formModel.FormName + "',"
                                                          + "number_of_students = '" + formModel.NumberOfStudents + "', "
                                                          + "id_teacher = " + formModel.IdTeacher
                                                          + " WHERE id_form =" + @"@id_form";

                command.Parameters.Add("@id_form", NpgsqlTypes.NpgsqlDbType.Integer).Value = formModel.IdForm;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<FormModel> GetAll() // Method for getting ALL table columns
        {
            var formList = new List<FormModel>();

            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT form.*, teacher.surname
                                        FROM form
                                        JOIN teacher ON form.id_teacher = teacher.id_teacher
                                        ORDER BY id_form;";

                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var formModel = new FormModel
                        {
                            IdForm = (int)reader[0],
                            FormName = reader[1].ToString(),
                            NumberOfStudents = (int) reader[2],
                            IdTeacher = (int) reader[3],
                            TeacherSurname = reader[4].ToString()
                        };
                        formList.Add(formModel);
                    }
                }
            }
            return formList;
        }

        public IEnumerable<FormModel> GetByValue(string value) // Method for getting specific table field (form)
        {
            var formList = new List<FormModel>();

            int IdForm = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string FormName = value;
            int NumberOfStudents = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            int IdTeacher = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string TeacherSurname = value;

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"
                                        SELECT f.*, t.surname
                                        FROM form f
                                        JOIN teacher t ON f.id_teacher = t.id_teacher
                                        WHERE f.id_form = @id_form 
                                        OR f.name iLIKE @name || '%' 
                                        OR (CAST(f.number_of_students AS TEXT) = CAST(@number_of_students AS TEXT)) 
                                        OR t.surname iLIKE @surname || '%'
                                        ORDER BY f.id_form ASC;";

                command.Parameters.Add("@id_form", NpgsqlTypes.NpgsqlDbType.Integer).Value = IdForm;
                command.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = FormName;
                command.Parameters.Add("@number_of_students", NpgsqlTypes.NpgsqlDbType.Text).Value = NumberOfStudents.ToString();
                command.Parameters.Add("@surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = TeacherSurname;


                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var formModel = new FormModel
                        {
                            IdForm = (int)reader[0],
                            FormName = reader[1].ToString(),
                            NumberOfStudents = (int)reader[2],
                            IdTeacher = (int)reader[3],
                            TeacherSurname = reader[4].ToString()
                        };
                        formList.Add(formModel);
                    }
                }
            }
            return formList;
        }

        public IEnumerable<FormModel> SortByStudentsNumber() // Sorting table by number of students (1-9)
        {
            var formList = new List<FormModel>();

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT form.*, teacher.surname
                                        FROM form
                                        JOIN teacher ON form.id_teacher = teacher.id_teacher
                                        ORDER BY number_of_students, id_form ASC;";

                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var formModel = new FormModel
                        {
                            IdForm = (int)reader[0],
                            FormName = reader[1].ToString(),
                            NumberOfStudents = (int)reader[2],
                            IdTeacher = (int)reader[3],
                            TeacherSurname = reader[4].ToString()
                        };
                        formList.Add(formModel);
                    }
                }
            }
            return formList;
        }

        public IEnumerable<FormModel> ResetFilters()
        {
            return GetAll();
        }
    }
}
