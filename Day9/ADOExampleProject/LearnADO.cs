using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADOExampleProject
{
    public class LearnADO
    {
        readonly string connectionString = @"Data source=DESKTOP-1C1EU5R;Integrated security=true;Initial Catalog=dbCompany";
        readonly SqlConnection connection;
        List<Skill> skills;
        public LearnADO()
        {
            connection = new SqlConnection(connectionString);
        }
        public void CheckConnectedADO()
        {
            skills = new List<Skill>();
            //Query
            string strCommand = "select * from Skills";
            //Initializing the command with teh required properties
            SqlCommand sqlCommand = new SqlCommand();
            //Proving the connection to the command (or) linking the connection and teh command object
            sqlCommand.Connection = connection;
            //Proving teh command text
            sqlCommand.CommandText = strCommand;
            //opening the connection (or) establishing the connection
            connection.Open();
            Skill skill;
            //pointing the data from the database to the datareader
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            //reading the data record by record
            while (dataReader.Read())
            {
                skill = new Skill();
                //using the index to access teh columns of teh current row
                skill.Skill_name = dataReader[0].ToString() ;
                skill.Skill_Description = dataReader[1].ToString();
                skills.Add(skill);
            }
            //Winding up the connection
            connection.Close();
            PrintSkills();
        }

        public void CheckDisConnectedADO()
        {
            skills = new List<Skill>();
            //Query
            string strCommand = "select * from Skills";
            //Initializing the command with teh required properties
            SqlCommand sqlCommand = new SqlCommand();
            //Proving the connection to the command (or) linking the connection and teh command object
            sqlCommand.Connection = connection;
            //Proving teh command text
            sqlCommand.CommandText = strCommand;
            //adapter to connect with the database
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            //providing the select query
            dataAdapter.SelectCommand = sqlCommand;
            //to store result locally datase
            DataSet dataset = new DataSet();
            //use the dataadapter to connect->fetch teh data -> put it in the dataset->disconnect
            dataAdapter.Fill(dataset);
            Skill skill;
            foreach (DataRow item in dataset.Tables[0].Rows)
            {
                skill = new Skill();
                //using the index to access teh columns of teh current row
                skill.Skill_name = item[0].ToString();
                skill.Skill_Description = item[1].ToString();
                skills.Add(skill);
            }
            PrintSkills();
        }
        void PrintSkills()
        {
            foreach (var item in skills)
            {
                Console.WriteLine(item);
            }
        }
    }
}
