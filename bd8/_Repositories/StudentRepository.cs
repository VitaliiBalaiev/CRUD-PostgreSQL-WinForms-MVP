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
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(StudentModel studentModel) // Add new student
        {
            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "INSERT INTO student VALUES (DEFAULT, '" + studentModel.Surname + "'," +
                                                                     "'" + studentModel.Name + "'," +
                                                                      "'" + studentModel.Patronymic + "'," +
                                                                      "'" + studentModel.DateOfBirth.ToString() + "'," +
                                                                      "'" + studentModel.Gender + "'," +
                                                                      "" + studentModel.IdForm + ");";
                command.ExecuteNonQuery();
            }
        }

        public void Delete(StudentModel studentModel) // Delete student
        {
            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "DELETE FROM student WHERE surname ='" + studentModel.Surname + "'";
                command.ExecuteNonQuery();
            }
        }

        public void Edit(StudentModel studentModel) // Edit student info 
        {
            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "UPDATE student SET surname = '" + studentModel.Surname + "',"
                                                          + "name = '" + studentModel.Name + "', "
                                                          + "patronymic = '" + studentModel.Patronymic + "', "
                                                          + "date_of_birth = '" + studentModel.DateOfBirth + "', "
                                                          + "gender = '" + studentModel.Gender + "', "
                                                          + "id_form = '" + studentModel.IdForm + "'"
                                                          + "WHERE id_student =" + @"@id_student";

                command.Parameters.Add("@id_student", NpgsqlTypes.NpgsqlDbType.Integer).Value = studentModel.IdStudent;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<StudentModel> GetAll() // Method for getting ALL table columns
        {
            var studentList = new List<StudentModel>();

            // Open DB connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT * FROM student ORDER BY id_student ASC;";

                // Reading from DB
                using (var reader=command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.IdStudent = (int)reader[0];
                        studentModel.Surname = reader[1].ToString();
                        studentModel.Name = reader[2].ToString();
                        studentModel.Patronymic = reader[3].ToString();
                        studentModel.DateOfBirth = (DateTime)reader[4];
                        studentModel.Gender = reader[5].ToString();
                        studentModel.IdForm = (int) reader[6];
                        studentList.Add(studentModel);
                    }
                }
            }
                return studentList;
        }

        public IEnumerable<StudentModel> GetByValue(string value) // Method for getting specific table field (student)
        {
            var studentList = new List<StudentModel>();

            int studentId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string studentName = value;
            string studentSurname = value;
            string studentPatronymic = value;

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT * FROM student 
                        WHERE id_student = @id OR name iLIKE @name || '%' OR surname iLIKE @surname || '%' OR patronymic iLIKE @patronymic || '%'
                        ORDER BY name, id_student ASC;";

                command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = studentId;
                command.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = studentName;
                command.Parameters.Add("@surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = studentSurname;
                command.Parameters.Add("@patronymic", NpgsqlTypes.NpgsqlDbType.Varchar).Value = studentPatronymic;


                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.IdStudent = (int)reader[0];
                        studentModel.Surname = reader[1].ToString();
                        studentModel.Name = reader[2].ToString();
                        studentModel.Patronymic = reader[3].ToString();
                        studentModel.DateOfBirth = (DateTime)reader[4];
                        studentModel.Gender = reader[5].ToString();
                        studentModel.IdForm = (int)reader[6];
                        studentList.Add(studentModel);
                    }
                }
            }
            return studentList;
        }

        public IEnumerable<StudentModel> SortBySurname() // Метод для сортування таблиці по прізвищу (А-Я)
        {
            var studentList = new List<StudentModel>();

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT * FROM student ORDER BY surname, id_student ASC;";

                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.IdStudent = (int)reader[0];
                        studentModel.Surname = reader[1].ToString();
                        studentModel.Name = reader[2].ToString();
                        studentModel.Patronymic = reader[3].ToString();
                        studentModel.DateOfBirth = (DateTime)reader[4];
                        studentModel.Gender = reader[5].ToString();
                        studentModel.IdForm = (int)reader[6];
                        studentList.Add(studentModel);
                    }
                }
            }
            return studentList;
        }

        public IEnumerable<StudentModel> SortByName() // Метод для сортування таблиці по імені (А-Я)
        {
            var studentList = new List<StudentModel>();

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT * FROM student ORDER BY name ASC;";

                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentModel = new StudentModel();
                        studentModel.IdStudent = (int)reader[0];
                        studentModel.Surname = reader[1].ToString();
                        studentModel.Name = reader[2].ToString();
                        studentModel.Patronymic = reader[3].ToString();
                        studentModel.DateOfBirth = (DateTime)reader[4];
                        studentModel.Gender = reader[5].ToString();
                        studentModel.IdForm = (int)reader[6];
                        studentList.Add(studentModel);
                    }
                }
            }
            return studentList;
        }

        public IEnumerable<StudentModel> ResetFilters()
        { 
            return GetAll();
        }
    }

    
}
