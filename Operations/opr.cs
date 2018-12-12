using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using Information;
using System.Data;
using System.Data.SqlClient;

namespace Operations
{
    public class opr
    {
        public dbc ndbc = new dbc();
        public info ninfo = new info();
        

        public object Login(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select position from [Employee] where username = '"+ninfo.username+"' and password = '"+ninfo.password+"'";
            return ndbc.ExeScaler(com);
        
        }
        

        public DataTable NewUser(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into [Employee] (name, position, username, password, address, mobile,team_id) values ('"+ninfo.name+"','"+ninfo.role+"','"+ninfo.username+"','"+ninfo.password+"','"+ninfo.address+"','"+ninfo.mobile+"','"+ninfo.team_id+"')";
            return ndbc.ExeReader(com);
        }

        public DataTable viewSupervisor(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [Employee] where position = 'Supervisor' ";
            return ndbc.ExeReader(com);
        }

        public DataTable viewManager(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [Employee] where position = 'Manager' ";
            return ndbc.ExeReader(com);
        }

        public DataTable viewOwner(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [Employee] where position = 'Owner' ";
            return ndbc.ExeReader(com);
        }

        public DataTable UpdateUser(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [Employee] set name = '" + ninfo.name+"', position = '"+ninfo.role+"',username = '"+ninfo.username+"',password = '"+ninfo.password+"',address = '"+ninfo.address+"',mobile = '"+ninfo.mobile+"',team_id = '"+ninfo.team_id+"' where username = '"+ninfo.username+"'";
            return ndbc.ExeReader(com);
        }

        public DataTable DeleteUser(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from [Employee] where username = '" + ninfo.username+"'";
            return ndbc.ExeReader(com);
        }

        public DataTable NewWorker(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into [worker] (name, address, mobile, position, performance) values ('" + ninfo.name + "','" + ninfo.address + "','" + ninfo.mobile + "', '" + ninfo.position + "','" + ninfo.performance + "')";
            return ndbc.ExeReader(com);
        }

        public DataTable viewWorker(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [worker]";
            return ndbc.ExeReader(com);
        }

        public DataTable UpdateWorker(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [worker] set name = '" + ninfo.name + "', address = '" + ninfo.address + "',mobile = '" + ninfo.mobile + "',position = '" + ninfo.position + "',performance = '" + ninfo.performance + "' where name = '" + ninfo.name + "'";
            return ndbc.ExeReader(com);
        
        }

        public DataTable DeleteWorker(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from [worker] where name = '" + ninfo.name + "'";
            return ndbc.ExeReader(com);
        }



        public DataTable NewTeam(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into [Team] (Team_id, No_Of_employee, starting_date, closing_date, product_id) values ('" + ninfo.team_id + "','" + ninfo.noofemp + "','" + ninfo.startingdate + "','" + ninfo.closingdate + "','" + ninfo.product_id + "')";
            return ndbc.ExeReader(com);
        }


        public DataTable viewTeam(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [team] ";
            return ndbc.ExeReader(com);
        }

        public DataTable UpdateTeam(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [team] set Team_id = '" + ninfo.team_id + "', No_Of_employee = '" + ninfo.noofemp + "',starting_date = '" + ninfo.startingdate + "',closing_date = '" + ninfo.closingdate + "',product_id = '" + ninfo.product_id + "' where Team_id = '" + ninfo.team_id + "'";
            return ndbc.ExeReader(com);
        }

        public DataTable DeleteTeam(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from [Team] where Team_id = '" + ninfo.team_id + "'";
            return ndbc.ExeReader(com);
        }


        public DataTable NewProduct(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into [product] (product_id, team_id, style_no, order_qty, product,label,smv,first_out,style_changes,plan_man,target_input,target_output) values ('" + ninfo.product_id + "','" + ninfo.team_id + "','" + ninfo.style_no + "','" + ninfo.order_qty + "','" + ninfo.product + "','" + ninfo.label + "','" + ninfo.smv + "','" + ninfo.first_out + "','" + ninfo.style_changes + "','" + ninfo.plan_man + "','" + ninfo.target_input + "','" + ninfo.target_output + "')";
            return ndbc.ExeReader(com);
        }


        public DataTable viewProduct(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [Product] ";
            return ndbc.ExeReader(com);
        }

        public DataTable UpdateProduct(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Update [product] set product_id = '" + ninfo.product_id + "', team_id = '" + ninfo.team_id + "',style_no = '" + ninfo.style_no + "',order_qty = '" + ninfo.order_qty + "',product = '" + ninfo.product + "',label = '" + ninfo.label + "', smv = '" + ninfo.smv + "',first_out = '" + ninfo.first_out + "',style_changes = '" + ninfo.style_changes + "',plan_man = '" + ninfo.plan_man + "',target_input = '"+ninfo.target_input+"', target_output = '"+ninfo.target_output+"' where product_id = '" + ninfo.product_id + "'";
            return ndbc.ExeReader(com);
        }

        public DataTable DeleteProduct(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete from [product] where product_id = '" + ninfo.product_id + "'";
            return ndbc.ExeReader(com);
        }

        public DataTable WorkerLog(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [WorkersLog] ";
            return ndbc.ExeReader(com);
        }

        public DataTable ProductLog1(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [Product_log] ";
            return ndbc.ExeReader(com);
        }

        public DataTable ProductLog2(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [ProductLog2] ";
            return ndbc.ExeReader(com);
        }

        public DataTable TeamLog(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [Teamlog] ";
            return ndbc.ExeReader(com);
        }

        public DataTable SuperLog(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from [SupervisorLog] ";
            return ndbc.ExeReader(com);
        }

        public DataTable DSuperLog(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete  from [SupervisorLog] ";
            return ndbc.ExeReader(com);
        }

        public DataTable DWorkerLog(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete  from [WorkersLog] ";
            return ndbc.ExeReader(com);
        }

        public DataTable DProductLog1(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete  from [Product_log] ";
            return ndbc.ExeReader(com);
        }

        public DataTable DProductLog2(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete  from [ProductLog2] ";
            return ndbc.ExeReader(com);
        }

        public DataTable DTeamLog(info ninfo)
        {
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Delete  from [Teamlog] ";
            return ndbc.ExeReader(com);
        }

    }
}
