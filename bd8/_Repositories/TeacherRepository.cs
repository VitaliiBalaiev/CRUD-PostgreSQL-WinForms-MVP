﻿using bd8.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bd8._Repositories
{
    public class TeacherRepository : BaseRepository, ITeacherRepository
    {
        public TeacherRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(TeacherModel teacherModel) // Add new teacher
        {
            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "INSERT INTO teacher VALUES (DEFAULT, '" + teacherModel.Surname + "'," +
                                                                     "'" + teacherModel.Name + "'," +
                                                                      "'" + teacherModel.Patronymic + "'," +
                                                                      "'" + teacherModel.DateOfBirth.ToString() + "'," +
                                                                      "'" + teacherModel.Gender + "'," +
                                                                      "'" + teacherModel.IdDegree + "'," +
                                                                      "'" + teacherModel.IdSchool + "');";
                command.ExecuteNonQuery();
            }
        }

        public void Delete(TeacherModel teacherModel) // Delete teacher
        {
            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "DELETE FROM teacher WHERE surname ='" + teacherModel.Surname + "'";
                command.ExecuteNonQuery();
            }
        }

        public void Edit(TeacherModel teacherModel) // Edit teacher's details
        {
            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = "UPDATE teacher SET surname = '" + teacherModel.Surname + "',"
                                                          + "name = '" + teacherModel.Name + "', "
                                                          + "patronymic = '" + teacherModel.Patronymic + "', "
                                                          + "date_of_birth = '" + teacherModel.DateOfBirth + "', "
                                                          + "gender = '" + teacherModel.Gender + "', "
                                                          + "id_degree = '" + teacherModel.IdDegree + "',"
                                                          + "id_school = '" + teacherModel.IdSchool + "' "
                                                          + "WHERE id_teacher =" + @"@id_teacher";

                command.Parameters.Add("@id_teacher", NpgsqlTypes.NpgsqlDbType.Integer).Value = teacherModel.IdTeacher;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TeacherModel> GetAll() // Method for getting all columns in table
        {
            var teacherList = new List<TeacherModel>();

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                //command.CommandText = @"SELECT * FROM teacher ORDER BY id_teacher ASC;";
                command.CommandText = @"SELECT t.id_teacher, t.surname, t.name, t.patronymic, t.date_of_birth, t.gender, t.id_degree, d.description, t.id_school, s.name
                                        FROM teacher t
                                        JOIN degree d ON t.id_degree = d.id_degree
                                        JOIN school s ON t.id_school = s.id_school
                                        ORDER BY id_teacher ASC;";

                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var teacherModel = new TeacherModel
                        {
                            IdTeacher = (int)reader[0],
                            Surname = reader[1].ToString(),
                            Name = reader[2].ToString(),
                            Patronymic = reader[3].ToString(),
                            DateOfBirth = (DateTime)reader[4],
                            Gender = reader[5].ToString(),
                            IdDegree = (int)reader[6],
                            DegreeDescription = reader[7].ToString(),
                            IdSchool = (int)reader[8],
                            SchoolName = reader[9].ToString()
                        };
                        teacherList.Add(teacherModel);
                    }
                }
            }
            return teacherList;
        }

        public IEnumerable<TeacherModel> GetByValue(string value) // Method for getting specific field
        {
            var teacherList = new List<TeacherModel>();

            int teacherId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string teacherName = value;
            string teacherSurname = value;
            string teacherPatronymic = value;

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT t.id_teacher, t.surname, t.name, t.patronymic, t.date_of_birth, t.gender, t.id_degree, d.description, t.id_school, s.name
                                        FROM teacher t
                                        JOIN degree d ON t.id_degree = d.id_degree
                                        JOIN school s ON t.id_school = s.id_school
                                        WHERE t.id_teacher = @id OR t.name iLIKE @name || '%' OR t.surname iLIKE @surname || '%' OR t.patronymic iLIKE @patronymic || '%'
                                        ORDER BY t.name, t.id_teacher ASC;";

                command.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = teacherId;
                command.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar).Value = teacherName;
                command.Parameters.Add("@surname", NpgsqlTypes.NpgsqlDbType.Varchar).Value = teacherSurname;
                command.Parameters.Add("@patronymic", NpgsqlTypes.NpgsqlDbType.Varchar).Value = teacherPatronymic;


                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var teacherModel = new TeacherModel
                        {
                            IdTeacher = (int)reader[0],
                            Surname = reader[1].ToString(),
                            Name = reader[2].ToString(),
                            Patronymic = reader[3].ToString(),
                            DateOfBirth = (DateTime)reader[4],
                            Gender = reader[5].ToString(),
                            IdDegree = (int)reader[6],
                            DegreeDescription = reader[7].ToString(),
                            IdSchool = (int)reader[8],
                            SchoolName = reader[9].ToString()
                        };
                        teacherList.Add(teacherModel);
                    }
                }
            }
            return teacherList;
        }
        public IEnumerable<TeacherModel> SortBySurnameTeacher() // Method for sorting table by SURNAME (A-Z)
        {
            var teacherList = new List<TeacherModel>();

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT t.id_teacher, t.surname, t.name, t.patronymic, t.date_of_birth, t.gender, t.id_degree, d.description, t.id_school, s.name
                                        FROM teacher t
                                        JOIN degree d ON t.id_degree = d.id_degree
                                        JOIN school s ON t.id_school = s.id_school
                                        ORDER BY t.surname ASC;";

                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var teacherModel = new TeacherModel
                        {
                            IdTeacher = (int)reader[0],
                            Surname = reader[1].ToString(),
                            Name = reader[2].ToString(),
                            Patronymic = reader[3].ToString(),
                            DateOfBirth = (DateTime)reader[4],
                            Gender = reader[5].ToString(),
                            IdDegree = (int)reader[6],
                            DegreeDescription = reader[7].ToString(),
                            IdSchool = (int)reader[8],
                            SchoolName = reader[9].ToString()
                        };
                        teacherList.Add(teacherModel);
                    }
                }
            }
            return teacherList;
        }

        public IEnumerable<TeacherModel> SortByNameTeacher() // Method for sorting table by NAME (A-Z)
        {
            var teacherList = new List<TeacherModel>();

            // Open connection
            using (var connection = new NpgsqlConnection(connectionString))
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // SQL Query
                command.CommandText = @"SELECT t.id_teacher, t.surname, t.name, t.patronymic, t.date_of_birth, t.gender, t.id_degree, d.description, t.id_school, s.name
                                        FROM teacher t
                                        JOIN degree d ON t.id_degree = d.id_degree
                                        JOIN school s ON t.id_school = s.id_school
                                        ORDER BY t.name ASC;";

                // Reading from DB
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var teacherModel = new TeacherModel
                        {
                            IdTeacher = (int)reader[0],
                            Surname = reader[1].ToString(),
                            Name = reader[2].ToString(),
                            Patronymic = reader[3].ToString(),
                            DateOfBirth = (DateTime)reader[4],
                            Gender = reader[5].ToString(),
                            IdDegree = (int)reader[6],
                            DegreeDescription = reader[7].ToString(),
                            IdSchool = (int)reader[8],
                            SchoolName = reader[9].ToString()
                        };
                        teacherList.Add(teacherModel);
                    }
                }
            }
            return teacherList;
        }

        public IEnumerable<TeacherModel> ResetFilters()
        {
            return GetAll();
        }
    }
}
