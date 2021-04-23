using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    class dbAcccess
    {
        commonMethods common = new commonMethods();
        request req = new request();
        SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();
        DataSet ds;
        string query = null;
        string error_success_msg = null;
        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        public dbAcccess()
        {
            connBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connBuilder.InitialCatalog = "CallCenterDB";
            connBuilder.IntegratedSecurity = true;
        }

        /*This method is used to count the number of rows of a given table*/
        public int countTableRows(string tableName)
        {
            string query = "SELECT COUNT(*) FROM " + tableName;
            int count = 0;
            conn = new SqlConnection(connBuilder.ToString());
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                count = (int)cmd.ExecuteScalar();
            }
            return count;
        }

        // Update query - THIS WILL BE DONE WHEN WE DESIGN COMPLETE FROM (FORM IMPLEMENTATION)
        public string updateRequest(string updateType, string tableName, string colOneName, string colOneValue, string colTwoName, int colTwoValue, string colThreeName, string colThreeValue)
        {
            if (updateType == "accept")
            {
                query = @"UPDATE " + tableName + " SET " + colTwoName + "=@colTwoValue, " + colThreeName + "=@colThreeValue WHERE " + colOneName + "=@colOneValue";
            }
            else if (updateType == "complete")
            {
                query = @"UPDATE " + tableName + " SET " + colTwoName + "=@colTwoValue WHERE " + colOneName + "=@colOneValue AND " + colThreeName + "=@colThreeValue";
            }
            conn = new SqlConnection(connBuilder.ToString());

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@colTwoValue", colTwoValue);
                cmd.Parameters.AddWithValue("@colOneValue", colOneValue);
                cmd.Parameters.AddWithValue("@colThreeValue", colThreeValue);

                int res = cmd.ExecuteNonQuery();

                if (res == 1)
                {
                    if (updateType == "accept")
                    {
                        error_success_msg = "You have accpeted this request. ID " + colOneValue;
                    }
                    else if (updateType == "complete")
                    {
                        error_success_msg = "You have completed this request. ID " + colOneValue;
                    }
                }
                else
                {
                    error_success_msg = "An unexpected error occured! Please try again.";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return error_success_msg;
        }

        //THIS IS FOR INSERTING THE SMS IN THE DATABASE
        public string insertSms(string smsID, string incoming, string outgoing, string busiID, string indiID, string adminstID, string time)
        {
            string error_success = null;
            string query = "INSERT INTO sms(smsID, incoming, outgoing, businessID, individualID, adminstratorID, sentTime)";
            query += "VALUES(@smsID, @incoming, @outgoing, @businessID, @individualID, @adminstratorID, @sentTime)";
            conn = new SqlConnection(connBuilder.ToString());

            try
            {
                //Open connection
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@smsID", smsID);
                cmd.Parameters.AddWithValue("@incoming", incoming);
                cmd.Parameters.AddWithValue("@outgoing", outgoing);
                cmd.Parameters.AddWithValue("@businessID", busiID);
                cmd.Parameters.AddWithValue("@individualID", indiID);
                cmd.Parameters.AddWithValue("@adminstratorID", adminstID);
                cmd.Parameters.AddWithValue("@sentTime", time);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    error_success = "Message sent.";
                }
                else
                {
                    error_success = "An unexpected error occured";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }

            return error_success;
        }
        //This query will search for a given field based on:
        //Third Query
        /* --------------------------------------- */
        //1. Given Table name
        //2. Given column name
        //3. Given column value 'WHERE ID=ID' <- example
        //4. Given column name
        //5. Given column value 'WHERE name=name' <- example
        //6. Given column name
        //7. Given column value 'WHERE surname=surname' <- example
        public DataSet searchTable_ThreePrameters(string tablename, string coulmnName_one, string coulmnValue_one, string coulmnName_two, string coulmnValue_two, string coulmnName_three, string coulmnValue_three)
        {
            query = "SELECT * FROM " + tablename + " WHERE " + coulmnName_one + "=@coulmnValue_one AND " + coulmnName_two + "=@coulmnValue_two AND " + coulmnName_three + "=@coulmnValue_three";
            conn = new SqlConnection(connBuilder.ToString());
            try
            {
                adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@coulmnValue_one", coulmnValue_one);
                adapter.SelectCommand.Parameters.AddWithValue("@coulmnValue_two", coulmnValue_two);
                adapter.SelectCommand.Parameters.AddWithValue("@coulmnValue_three", coulmnValue_three);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return ds;
        }
        //This query will search for a given field based on:
        //Second Query - TWO Parameters
        /* --------------------------------------- */
        //1. Given Table name
        //2. Given column name
        //3. Given column value 'WHERE ID=ID' <- example
        //4. Given column name
        //5. Given column value 'WHERE name=name' <- example
        public DataSet searchTabel_twoParameters(string tablename, string coulmnName_one, string coulmnValue_one, string coulmnName_two, string coulmnValue_two, string operator_AND_OR)
        {
            if (operator_AND_OR == "AND")
            {
                query = "SELECT * FROM " + tablename + " WHERE " + coulmnName_one + "=@coulmnValue_one AND " + coulmnName_two + "=@coulmnValue_two";
            }
            if (operator_AND_OR == "OR")
            {
                query = "SELECT * FROM " + tablename + " WHERE " + coulmnName_one + "=@coulmnValue_one OR " + coulmnName_two + "=@coulmnValue_two";
            }
            conn = new SqlConnection(connBuilder.ToString());
            try
            {
                adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@coulmnValue_one", coulmnValue_one);
                adapter.SelectCommand.Parameters.AddWithValue("@coulmnValue_two", coulmnValue_two);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return ds;
        }
        //First Query
        /* --------------------------------------- */
        //1. Given Table name
        //2. Given column name
        //3. Given column value 'WHERE ID=ID'
        public DataSet searchForData(string tablename, string columnName, string columnValue, string colname_orderby)
        {
            if (colname_orderby == "")
            {
                query = "SELECT * FROM " + tablename + " WHERE " + columnName + "=@columnValue";
            }
            else
            {
                query = "SELECT * FROM " + tablename + " WHERE " + columnName + "=@columnValue ORDER BY " + colname_orderby + " DESC";
            }
            
            conn = new SqlConnection(connBuilder.ToString());
            try
            {
                adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@columnValue", columnValue);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return ds;
        }
        // This is a method that will search for data based on the table name
        // And will retrive all data if true
        public DataSet getColumnData(string tableName, string coulmnName)
        {
            query = "SELECT " + coulmnName + " FROM " + tableName;
            conn = new SqlConnection(connBuilder.ToString());
            try
            {
                adapter = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return ds;
        }
        // This is a method that will search for data based on the table name
        // And will retrive all data if true
        public DataSet getTableData(string tableName)
        {
            query = "SELECT * FROM " + tableName;
            conn = new SqlConnection(connBuilder.ToString());
            try
            {
                adapter = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return ds;
        }

        //This query will delete a row depeneding on:
        //1. Given table name
        //2. Given column name
        //3. Given column value - only ID's
        public bool deleteQuery(string tablename, string columnName, string ID)
        {
            bool status = false;
            // Connection 
            SqlConnection conn = new SqlConnection(connBuilder.ToString());
            // Query 
            query = @"DELETE FROM " + tablename + " WHERE "+columnName+"=@id";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                int count = cmd.ExecuteNonQuery();
                if (count == 0)
                {
                    //Not Updated
                    status = false;
                }
                else
                {
                    //Updated
                    status = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return status;

        }

        //REGISTRATION
        public void insertUserPhoneNumber(string userID, string userType)
        {
            //FIRST WE NEED TO STORE THE USER'S PHONE  NUMBER - START
            string phoneNumber = common.phoneNumber();
            query = "INSERT INTO phoneNumber(phoneNumber, clientNumber, clientType)";
            query += "VALUES('" + phoneNumber + "', '" + userID + "', '" + userType + "')";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                //Closing the connection
                conn.Close();
            }
            //FIRST WE NEED TO STORE THE USER'S PHONE  NUMBER - END
        }
        public string registration(string userType, string name, string surname_location, string role_email, string pass)
        {
            //This is a local variable for the success or error msg
            string success_error = "";

            /*THIS PART INVOLVE THE GENEARTION OF USER ID - ZERO PADDING* - START*/
            int users_table_count;
            string userID;
            string firstLetter;
            int idLimit = 8;
            string secondPartOfID;
            if (userType == "individual")
            {
                users_table_count = countTableRows("clientIndividual");
                firstLetter = common.randomLetter().ToString();
                secondPartOfID = common.zeroAppend("00000000" + users_table_count, + idLimit);
                //Full user ID
                userID = firstLetter + secondPartOfID;
            }
            else if (userType == "business")
            {
                users_table_count = countTableRows("businessClient");
                firstLetter = common.randomLetter().ToString();
                secondPartOfID = common.zeroAppend("00000000" + users_table_count, +idLimit);
                //Full user ID
                userID = firstLetter + secondPartOfID;
            }
            else
            {
                userID = common.generateUserID(name, surname_location);
            }
            /*THIS PART INVOLVE THE GENEARTION OF USER ID - ZERO PADDING* - END*/

            //generating username 
            int surname_location_length = surname_location.Length - 1;
            string username = name.Substring(0,1).ToLower() + surname_location.Substring(0,1).ToUpper() + surname_location.Substring(1, surname_location_length) + common.generateRandomNumber(0,10).ToString();
            int verified = 0;

            //This is for the db connection
            conn = new SqlConnection(connBuilder.ToString());
            //This is for the query
            string query = null;
            int insertResult;

            if (userType == "individual")
            {
                //FIRST WE NEED TO STORE THE USER'S PHONE  NUMBER - START
                insertUserPhoneNumber(userID, userType);
                //FIRST WE NEED TO STORE THE USER'S PHONE  NUMBER - END

                //THEN WE NEED TO STORE THE USER'S DETAILS IN INDIVIDUAL TABLE - START
                query = "INSERT INTO clientIndividual(id, name, surname, role, verified,username, password)";
                query += "VALUES(@id, @name, @surname, @role, @verified,@username, @pass)";
                try
                {
                    conn.Open();

                    cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", userID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname_location);
                    cmd.Parameters.AddWithValue("@role", role_email);
                    cmd.Parameters.AddWithValue("@verified", verified);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    insertResult = cmd.ExecuteNonQuery();

                    if (insertResult < 0)
                    {
                        success_error =  "An unexpected error occurred. Please try again.";
                    }
                    else
                    {
                        success_error = "You are in the books.\nThank you for becoming a member.\nPlease wait to be confirmed then you can login and use your account.\nPlease remeber that your username is: " + username;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    //Closing the connection
                    conn.Close();
                }
            }
            else if (userType == "business")
            {
                //FIRST WE NEED TO STORE THE USER'S PHONE  NUMBER - START
                insertUserPhoneNumber(userID, userType);
                //FIRST WE NEED TO STORE THE USER'S PHONE  NUMBER - END

                //Business
                query = "INSERT INTO businessClient(id, name, location, email, verified, username, password)";
                query += "VALUES(@id, @name, @location, @email, @verified, @username, @pass)";
                conn = new SqlConnection(connBuilder.ToString());

                try
                {
                    conn.Open();

                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@location", surname_location);
                    cmd.Parameters.AddWithValue("@email", role_email);
                    cmd.Parameters.AddWithValue("@verified", verified);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    insertResult = cmd.ExecuteNonQuery();

                    if (insertResult < 0)
                    {
                        success_error = "An unexpected error occurred. Please try again.";
                    }
                    else
                    {
                        success_error = "You are in the books.\nThank you for becoming a member.\nPlease wait to be confirmed then you can login and use your account.\nPlease remeber that your username is: " + username;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    //Closing the connection
                    conn.Close();
                }
            }
            else if (userType == "admin")
            {
                //Admin
                query = "INSERT INTO admin(id, name, surname, username, password)";
                query += "VALUES(@id, @name, @surname, @username, @password)";
                conn = new SqlConnection(connBuilder.ToString());

                try
                {
                    conn.Open();

                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", userID);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname_location);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", pass);

                    insertResult = cmd.ExecuteNonQuery();

                    if (insertResult < 0)
                    {
                        success_error = "An unexpected error occurred. Please try again.";
                    }
                    else
                    {
                        success_error = "You are in the books.\nThank you for becoming a member.\nPlease wait to be confirmed then you can login and use your account.\nPlease remeber that your username is: " + username;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    //Closing the connection
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong User Type!!!");
            }

            return success_error;
        }

        // LOGIN

        // BUSINESS CLIENT - LOGIN
        public dynamic getLoginPerson(string userLvl, string username, string password)
        {
            if (userLvl == "adminstrators")
            {
                // LIST FOR ADMINSTRATOR INFROMATION
                List<adminstrator> checkAdminstratorList = new List<adminstrator>();
                //DATABASE CONNECTION
                SqlConnection conn = new SqlConnection(connBuilder.ToString());
                //SQL QUERY
                string checkUserQuery = @"SELECT TOP 1 * FROM " + userLvl + " WHERE username=@name AND password=@password";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(checkUserQuery, conn);
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string adminId = reader.GetString(0);
                            string adminName = reader.GetString(1);
                            string adminSurname = reader.GetString(2);
                            int adminVerified = reader.GetInt32(3);
                            string adminUsername = reader.GetString(4);
                            string adminPassword = reader.GetString(5);

                            if (adminVerified == 0)
                            {
                                checkAdminstratorList = null;
                            }
                            else
                            {
                                checkAdminstratorList.Add(new adminstrator(adminId, adminName, adminSurname, adminVerified, adminUsername, adminPassword));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return checkAdminstratorList;

            }
            else if (userLvl == "admin")
            {
                //list for admin
                List<admin> adm = new List<admin>();
                //Connection
                SqlConnection conn = new SqlConnection(connBuilder.ToString());
                //Query
                string query = @"SELECT * FROM admin WHERE username=@username AND password=@password";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string id = reader.GetString(0);
                            string name = reader.GetString(1);
                            string surname = reader.GetString(2);
                            string usernm = reader.GetString(3);
                            string pass = reader.GetString(4);

                            adm.Add(new admin(id, name, surname, usernm, pass));
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }

                return adm;
            }
            else if(userLvl == "businessClient")
            {
                // LIST FOR ADMINSTRATOR INFROMATION
                List<BusinessClient> checkBusiClient = new List<BusinessClient>();
                //DATABASE CONNECTION
                SqlConnection conn = new SqlConnection(connBuilder.ToString());
                //SQL QUERY
                string checkUserQuery = @"SELECT TOP 1 * FROM " + userLvl + " WHERE username=@name AND password=@password";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(checkUserQuery, conn);
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string busiClientId = reader.GetString(0);
                            string busiClientName = reader.GetString(1);
                            string busiClientLocation = reader.GetString(2);
                            string busiClientEmail = reader.GetString(3);
                            int busiClientVerified = reader.GetInt32(4);
                            string busiClientUsername = reader.GetString(5);
                            string busiClientPassword = reader.GetString(6);

                            if (busiClientVerified == 0)
                            {
                                checkBusiClient = null;
                            }
                            else
                            {
                                checkBusiClient.Add(new BusinessClient(busiClientId, busiClientName, busiClientLocation, busiClientEmail, busiClientVerified, busiClientUsername, busiClientPassword));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return checkBusiClient;
            }
            else if (userLvl == "technician")
            {
                //Create lost to store technician details
                List<Technician> technician = new List<Technician>();
                //Connection
                SqlConnection conn = new SqlConnection(connBuilder.ToString());
                //Query
                string query = @"SELECT TOP 1 * FROM " + userLvl + " WHERE username=@username AND password=@password";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string technicianID = reader.GetString(0);
                            string technicianName = reader.GetString(1);
                            string technicianSurname = reader.GetString(2);
                            string serviceID = reader.GetString(3);
                            int technicianVerified = reader.GetInt32(4);
                            string technicianUsername = reader.GetString(5);
                            string technicianPassword = reader.GetString(6);

                            if (technicianVerified == 0)
                            {
                                technician = null;
                            }
                            else
                            {
                                technician.Add(new Technician(technicianID, technicianName, technicianSurname, serviceID, technicianVerified, technicianUsername, technicianPassword));
                            }
                        }
                    }
                 }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return technician;
            }
            else
            {
                // This is a list to store indi client info if he/she exists
                List<individualClient> checkIndiClientList = new List<individualClient>();
                // This is the connetion string
                SqlConnection conn = new SqlConnection(connBuilder.ToString());
                // This is the query to fetch user
                string checkUserQuery = @"SELECT TOP 1 * FROM " + userLvl + " WHERE username=@username AND password=@password";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(checkUserQuery, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string indiClientID = reader.GetString(0);
                            string indiClientName = reader.GetString(1);
                            string indiClientSurname = reader.GetString(2);
                            string indiClientRole = reader.GetString(3);
                            int indiClientVerified = reader.GetInt32(4);
                            string indiClientUsername = reader.GetString(5);
                            string indiClientPassword = reader.GetString(6);

                            if (indiClientVerified == 0)
                            {
                                checkIndiClientList = null;
                            }
                            else
                            {
                                checkIndiClientList.Add(new individualClient(indiClientID, indiClientName, indiClientSurname, indiClientRole, indiClientVerified, indiClientUsername, indiClientPassword));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return checkIndiClientList;
            }
        }


        /************************************************/
        /* THIS INVOLVES THE CALL FUNCTIONALITY - START */
        /************************************************/

        //insert request in database
        public string insertRequest(string clientType, string clientID, string callEmployeeID)
        {
            //Connection to database
            conn = new SqlConnection(connBuilder.ToString());
            //request ID
            string reqID = common.generateID(10);
            //request issue
            string reqIssue = req.generateUserIssue();
            query = "INSERT INTO techRequest(id, request, clientType, clientID, callEmployeeID, completed, accepted, acceptedTechnicianID)";
            query += "VALUES(@id,@request,@clientType,@clientID,@callEmpID,0,0,null)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", reqID);
                cmd.Parameters.AddWithValue("@request", reqIssue);
                cmd.Parameters.AddWithValue("@clientType", clientType);
                cmd.Parameters.AddWithValue("@clientID", clientID);
                cmd.Parameters.AddWithValue("@callEmpID", callEmployeeID);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return reqID;
        }

        //Insert call in database
        public string insertCall(List<calls> insertCallList, string stat)
        {
            //Connection
            SqlConnection conn = new SqlConnection(connBuilder.ToString());
            string query = null;
            string error_success_msg = null;

            //INSERTING THE CALL - START
            foreach (calls cls in insertCallList)
            {
                //FIRST OF ALL WE NEED TO INSERT THE REQUEST MADE BY THE CLIENT SO WE CAN GET THAT REQUEST'S ID
                //SO WE CAN INSERT THE ID IN THE CALL TABLE

                //INSERTING THE REUQEST - START
                string clientType = "";
                string clientID = "";
                if (cls.BusiID == null)
                {
                    clientType = "individual";
                    clientID = cls.IndiID;
                }
                else
                {
                    clientType = "business";
                    clientID = cls.BusiID;
                }
                string reqID = insertRequest(clientType, clientID, cls.EmpID);
                //INSERTING THE REUQEST - END

                if (stat == "Answered")
                {
                    cls.CallStatus = stat;
                    if (cls.BusiID == null)
                    {
                        query = "insert into calls(callID, callLength, callTime, callStat,indiID,empID,requestID)";
                        query += "VALUES('"+cls.CallID+ "', '" + cls.CallLength + " min', '" + cls.CallTime + "', '" + cls.CallStatus + "', '" + cls.IndiID + "', '" + cls.EmpID + "','" + reqID + "')";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            conn.Open();

                            try
                            {
                                int res = cmd.ExecuteNonQuery();
                                if (res > 0)
                                {
                                    error_success_msg = "Call have been recoreded successfully";
                                }
                            }
                            catch (Exception e)
                            {
                                error_success_msg = e.ToString();
                            }
                            
                            
                        }
                    }
                    else
                    {
                        query = "insert into calls(callID, callLength, callTime, callStat, busiID,empID,requestID)";
                        query += "VALUES('" + cls.CallID + "', '" + cls.CallLength + " min', '" + cls.CallTime + "', '" + cls.CallStatus + "', '" + cls.BusiID + "', '" + cls.EmpID + "','" + reqID + "')";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            conn.Open();

                            try
                            {
                                int res = cmd.ExecuteNonQuery();
                                if (res > 0)
                                {
                                    error_success_msg = "Call have been recoreded successfully";
                                }
                            }
                            catch (Exception e)
                            {
                                error_success_msg = e.ToString();
                            }


                        }
                    }
                }
                else if (stat == "Canceled")
                {
                    cls.CallStatus = stat;
                    if (cls.BusiID == null)
                    {
                        query = "insert into calls(callID, callLength, callTime, callStat,indiID,empID,requestID)";
                        query += "VALUES('" + cls.CallID + "', '" + cls.CallLength + " min', '" + cls.CallTime + "', '" + cls.CallStatus + "', '" + cls.IndiID + "', '" + cls.EmpID + "','" + reqID + "')";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            conn.Open();

                            try
                            {
                                int res = cmd.ExecuteNonQuery();
                                if (res > 0)
                                {
                                    error_success_msg = "Call have been recoreded successfully";
                                }
                            }
                            catch (Exception e)
                            {
                                error_success_msg = e.ToString();
                            }


                        }
                    }
                    else
                    {
                        query = "insert into calls(callID, callLength, callTime, callStat, busiID,empID,requestID)";
                        query += "VALUES('" + cls.CallID + "', '" + cls.CallLength + " min', '" + cls.CallTime + "', '" + cls.CallStatus + "', '" + cls.BusiID + "', '" + cls.EmpID + "','" + reqID + "')";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            conn.Open();

                            try
                            {
                                int res = cmd.ExecuteNonQuery();
                                if (res > 0)
                                {
                                    error_success_msg = "Call have been recoreded successfully";
                                }
                            }
                            catch (Exception e)
                            {
                                error_success_msg = e.ToString();
                            }


                        }
                    }
                }
            }
            //INSERTING THE CALL - END
            return error_success_msg;
        }

        //This is for selecting the users for makeing a call
        //a user can either be individual or business
        //i will start with the individual client
        public dynamic getClientInfo()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                //Individual List
                List<individualClient> indiClient = new List<individualClient>();

                SqlConnection conn = new SqlConnection(connBuilder.ToString());

                string query = "SELECT TOP 1 PERCENT * FROM clientIndividual ORDER BY newid()";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string id = reader.GetString(0);
                            string name = reader.GetString(1);
                            string surname = reader.GetString(2);
                            string role = reader.GetString(3);
                            string username = reader.GetString(5);

                            indiClient.Add(new individualClient(id, name, surname, role, username));
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error has occurred: {0}", ex.Message.ToString());
                }

                return indiClient;
            }
            else
            {
                //Business List
                List<BusinessClient> busiClient = new List<BusinessClient>();
                //Connection
                SqlConnection conn = new SqlConnection(connBuilder.ToString());
                //Query 
                string query1 = "SELECT TOP 1 PERCENT * FROM businessClient ORDER BY newid()";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query1, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string id = reader.GetString(0);
                            string name = reader.GetString(1);

                            busiClient.Add(new BusinessClient(id, name));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occurred: {0}", ex.Message.ToString());
                }
                return busiClient;
            }
            
        }
        
        
    }
}
