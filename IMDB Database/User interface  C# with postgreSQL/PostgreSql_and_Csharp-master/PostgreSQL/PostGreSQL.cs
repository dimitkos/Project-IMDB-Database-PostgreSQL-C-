using System;
using System.Windows.Forms;
using Npgsql; 
using System.Collections.Generic;

namespace PgSql
{

   public class PostGreSQL
   {
      
      List<string> dataItems = new List<string>();

      public void PostgreSQL()
      {
            
       }

      public List<string> PostgreSQLtest1()   //endolse pros tin postgresql meros 1
        {
         try
         {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM movie", connection);   //edo beni i andistixi endoli tis sql
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i=0; dataReader.Read(); i++)
            {
               dataItems.Add(dataReader[0].ToString() + "," + dataReader[1].ToString() + "," + dataReader[2].ToString() + "," + dataReader[3].ToString() + "," + dataReader[4].ToString() + "," + dataReader[5].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
            }
            connection.Close();
            return dataItems;
         }
         catch (Exception msg)
         {
            MessageBox.Show(msg.ToString());
            throw;
         }
      }

      public List<string> PostgreSQLtest2()   //endoles pro tin postgresql meros 2
        {
         try
         {
            string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
            NpgsqlConnection connection = new NpgsqlConnection(connstring);
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Actor", connection);   //edo beni i andistixi endoli tis sql
            NpgsqlDataReader dataReader = command.ExecuteReader();
            for (int i = 0; dataReader.Read(); i++)
            {
                    dataItems.Add(dataReader[0].ToString() + "," + dataReader[1].ToString() + "," + dataReader[2].ToString() + "," + dataReader[3].ToString() + "," + dataReader[4].ToString() + "," + dataReader[5].ToString() + "," + dataReader[6].ToString() + "\r\n");  //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
            connection.Close();
            return dataItems;
         }
         catch (Exception msg)
         {
            MessageBox.Show(msg.ToString());
            throw;
         }
      }


        /*public List<string> PostgreSQLtest3()   //endolse pros tin postgresql meros 1
        {
            try
            {



                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb2;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("UPDATE movie SET rating = ('"+neo+"') WHERE rating = ('"+old+"')", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();  
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }*/


        public List<string> PostgreSQLtest3()   //endoles pro tin postgresql yia tin Form2 (pou diavazi)
        {
 
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM acted", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "," + dataReader[1].ToString() + "," + dataReader[2].ToString() + "," + dataReader[3].ToString() + "," + dataReader[4].ToString() + "," + dataReader[5].ToString() + "," + dataReader[6].ToString() + "\r\n");  //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }



        public List<string> PostgreSQLtest4()   //Afto ine yia to read sto acted 
        {

            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=72677267; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM acted", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "                          " + dataReader[1].ToString() + "\r\n");  //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

   
        

        public List<string> PostgreSQLtest6()   //Afto ine yia to read sto ACTOR
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM actor", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "     " + dataReader[1].ToString() + " " + dataReader[2].ToString() + "       " + dataReader[3].ToString() + "             " + dataReader[4].ToString() + "                " + dataReader[5].ToString() + "                 " + dataReader[6].ToString() + "              " + dataReader[7].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        public List<string> PostgreSQLtest7()   //Afto ine yia to read sto cateqory
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM category", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "                    " + dataReader[1].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }



        public List<string> PostgreSQLtest8()   //Afto ine yia to read sto Director
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM director", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "        " + dataReader[1].ToString() + "      " + dataReader[2].ToString() + "               " + dataReader[3].ToString() + "             " + dataReader[4].ToString() + "                                              " + dataReader[5].ToString() + "                                             " + dataReader[6].ToString()  + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }



        public List<string> PostgreSQLtest9()   //Afto ine yia to read sto Favorited
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM favorited", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "                                     " + dataReader[1].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        public List<string> PostgreSQLtest10()   //Afto ine yia to read sto Imdb_User
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM imdb_user", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "       " + dataReader[1].ToString() + "                  " + dataReader[2].ToString() + "                           " + dataReader[3].ToString() + "                            " + dataReader[4].ToString() + "                         " + dataReader[5].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }




        public List<string> PostgreSQLtest11()   //Afto ine yia to update sto actor
        {

            String oldname = Actor.oldname;
            String newname = Actor.newname;
            



            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";

                NpgsqlConnection connection = new NpgsqlConnection(connstring);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("UPDATE actor SET avg_salary = '" + newname + "' WHERE avg_salary ='" + oldname + "'", connection);

                //NpgsqlCommand command = new NpgsqlCommand("UPDATE actor SET " + column + " = " + newname + " WHERE " + column + " =" + oldname + "", connection);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                connection.Close();

                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }





        public List<string> PostgreSQLtest12()   //Afto ine yia to read sto movie
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM movie", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "                    " + dataReader[1].ToString() + "      " + dataReader[2].ToString() + "               " + dataReader[3].ToString() + "            " + dataReader[4].ToString() + "              " + dataReader[5].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public List<string> PostgreSQLtest13()   //Afto ine yia to read sto produced_by
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM produced_by", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "               " + dataReader[1].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        public List<string> PostgreSQLtest14()   //Afto ine yia to read sto production
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM production", connection);   //edo beni i andistixi endoli tis sql
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "       " + dataReader[1].ToString() + "      " + dataReader[2].ToString() + "               " + dataReader[3].ToString() + "            " + dataReader[4].ToString() + "              " + dataReader[5].ToString() + "\r\n"); //prosthese oti epistrefi i vasi ke xorise ta apotelesmata me komata gia ektiposi argotera
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }





        public List<string> PostgreSQLtest15()   //Afto ine yia to update sto cateqory
        {

            String oldname = Category.oldname;
            String newname = Category.newname;

            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";

                NpgsqlConnection connection = new NpgsqlConnection(connstring);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("UPDATE category SET name = '" + newname + "' WHERE name ='" + oldname + "'", connection);

                //NpgsqlCommand command = new NpgsqlCommand("UPDATE actor SET " + column + " = " + newname + " WHERE " + column + " =" + oldname + "", connection);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                connection.Close();

                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        public List<string> PostgreSQLtest16()   //Afto ine yia to update sto director
        {

            String oldname = Director.oldname;
            String newname = Director.newname;

            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";

                NpgsqlConnection connection = new NpgsqlConnection(connstring);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("UPDATE director SET avg_salary = '" + newname + "' WHERE avg_salary ='" + oldname + "'", connection);

                //NpgsqlCommand command = new NpgsqlCommand("UPDATE actor SET " + column + " = " + newname + " WHERE " + column + " =" + oldname + "", connection);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                connection.Close();

                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }



        public List<string> PostgreSQLtest17()   //Afto ine yia to update sto imdb users
        {

            String oldname = Imdb_user.oldname;
            String newname = Imdb_user.newname;

            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";

                NpgsqlConnection connection = new NpgsqlConnection(connstring);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("UPDATE imdb_user SET email = '" + newname + "' WHERE email ='" + oldname + "'", connection);

                //NpgsqlCommand command = new NpgsqlCommand("UPDATE actor SET " + column + " = " + newname + " WHERE " + column + " =" + oldname + "", connection);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                connection.Close();

                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        public List<string> PostgreSQLtest18()   //Afto ine yia to update sto imdb users
        {

            String oldname = Movie.oldname;
            String newname = Movie.newname;

            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";

                NpgsqlConnection connection = new NpgsqlConnection(connstring);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("UPDATE movie SET rating = '" + newname + "' WHERE rating ='" + oldname + "'", connection);

                //NpgsqlCommand command = new NpgsqlCommand("UPDATE actor SET " + column + " = " + newname + " WHERE " + column + " =" + oldname + "", connection);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                connection.Close();

                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


        public List<string> PostgreSQLtest19()   //Afto ine yia to update sto imdb users
        {

            String oldname = Production.oldname;
            String newname = Production.newname;

            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=Henry23_PG; Database=imdb;";

                NpgsqlConnection connection = new NpgsqlConnection(connstring);

                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand("UPDATE production SET phone = '" + newname + "' WHERE phone ='" + oldname + "'", connection);

                //NpgsqlCommand command = new NpgsqlCommand("UPDATE actor SET " + column + " = " + newname + " WHERE " + column + " =" + oldname + "", connection);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                connection.Close();

                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }





    }
}
