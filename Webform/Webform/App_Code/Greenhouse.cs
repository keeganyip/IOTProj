using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for Greenhouse
/// </summary>
public class Greenhouse
{
    //system.Configuration.ConnectionStringSettings _connStr;
    string _connStr = ConfigurationManager.ConnectionStrings["UserdbConnectionString"].ConnectionString;
    private string _gHouseID = null;
    private string _gHouseName = string.Empty;
    private int _gHouseMembers = 1;
    private string _gHouseStatus = "";

    public Greenhouse()
    {
    }

    public Greenhouse(string gHouseID, string gHouseName, int gHouseMembers, string gHouseStatus)
    {
        _gHouseID = gHouseID;
        _gHouseName = gHouseName;
        _gHouseMembers = gHouseMembers;
        _gHouseStatus = gHouseStatus;
    }

    //get/set the attributes of the Greenhouse object.
    //note the attribute name (e.g. Greenhouse_ID) is same as the actual database field name.
    //this is for ease of referencing.
    public string gHouse_ID
    {
        get { return _gHouseID; }
        set { _gHouseID = value; }
    }
    public string gHouse_Name
    {
        get { return _gHouseName; }
        set { _gHouseName = value; }
    }
    public int gHouse_Members
    {
        get { return _gHouseMembers; }
        set { _gHouseMembers = value; }
    }
    public string gHouse_Status
    {
        get { return _gHouseStatus; }
        set { _gHouseStatus = value; }
    }
   

    //below as the Class methods for some DB operations. 
    public Greenhouse getGHouse(string gHouseID)
    {
        Greenhouse gHouse_Detail = null;

        string gHouse_Name, gHouse_Status;
        int gHouse_Members;

        string queryStr = "SELECT * FROM GreenhousesTable WHERE Gid = @ProdID";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@ProdID", gHouseID);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            gHouse_Name = dr["Name"].ToString();
            gHouse_Members= int.Parse(dr["Members"].ToString());
            gHouse_Status = dr["Status"].ToString();

            gHouse_Detail = new Greenhouse(gHouseID, gHouse_Name, gHouse_Members, gHouse_Status);
        }
        else
        {
            gHouse_Detail = null;
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return gHouse_Detail;
    }

    public int UserDelete(string ID)
    {
        string queryStr = "DELETE FROM Registration WHERE ID=@ID";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@ID", ID);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }

    public int ItemDelete(string ID)
    {
        string queryStr = "DELETE FROM EL_Cart WHERE EL_ID=@ID";
        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@ID", ID);
        conn.Open();
        int nofRow = 0;
        nofRow = cmd.ExecuteNonQuery();
        conn.Close();
        return nofRow;
    }

    public int GreenhouseInsert()
    {
        int result = 0;
        string queryStr = "INSERT INTO ALL_Greenhouses(Gid, Name, Members, Status)" + "values (@Greenhouse_ID, @Greenhouse_Name, @Greenhouse_Members, @Greenhouse_Status)";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@Greenhouse_ID", this.gHouse_ID);
        cmd.Parameters.AddWithValue("@Greenhouse_Name", this.gHouse_Name);
        cmd.Parameters.AddWithValue("@Greenhouse_Members", this.gHouse_Members);
        cmd.Parameters.AddWithValue("@Greenhouse_Status", this.gHouse_Status);

        conn.Open();
        result += cmd.ExecuteNonQuery();
        conn.Close();

        return result;
    }//end Insert
}

public class Thriller
{
    //System.Configuration.ConnectionStringSettings _connStr;
    string _connStr = ConfigurationManager.ConnectionStrings["SunnyCS"].ConnectionString;
    private string _gHouseID = null;
    private string _gHouseName = string.Empty;
    private int _gHouseMembers = 0;
    private string _gHouseStatus = "";

    // Default constructor
    public Thriller()
    {
    }

    // GreenhouseS
    public Thriller(string gHouseID, string gHouseName, int gHouseMembers, string gHouseStatus)
    {
        _gHouseID = gHouseID;
        _gHouseName = gHouseName;
        _gHouseMembers = gHouseMembers;
        _gHouseStatus = gHouseStatus;
    }

    // Constructor that take in all except Greenhouse ID
    public Thriller(string gHouseName, int gHouseMembers, string gHouseStatus)
        : this(null, gHouseName, gHouseMembers, gHouseStatus)
    {
    }

    // Constructor that take in only Greenhouse ID. The other attributes will be set to 0 or empty.
    public Thriller(string gHouseID)
        : this(gHouseID, "", 0, "")
    {
    }

    // Get/Set the attributes of the Greenhouse object.
    // Note the attribute name (e.g. Greenhouse_ID) is same as the actual database field name.
    // This is for ease of referencing.
    public string Greenhouse_ID
    {
        get { return _gHouseID; }
        set { _gHouseID = value; }
    }
    public string Greenhouse_Name
    {
        get { return _gHouseName; }
        set { _gHouseName = value; }
    }

    public int Greenhouse_Members
    {
        get { return _gHouseMembers; }
        set { _gHouseMembers = value; }
    }

    public string Greenhouse_Status
    {
        get { return _gHouseStatus; }
        set { _gHouseStatus = value; }
    }

    //public int ThrillerInsert()
    //{
    //    int result = 0;
    //    string queryStrThriller = "INSERT INTO EL_Thriller(EL_ID, EL_Image, EL_Title, EL_Studio)" + "values (@Greenhouse_ID, @Greenhouse_Name, @Greenhouse_Image, @Book_Author)";

    //    SqlConnection conn = new SqlConnection(_connStr);
    //    SqlCommand cmd = new SqlCommand(queryStrThriller, conn);
    //    cmd.Parameters.AddWithValue("@Greenhouse_ID", this.Greenhouse_ID);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Image", this.Greenhouse_Image);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Name", this.Greenhouse_Name);
    //    cmd.Parameters.AddWithValue("@Book_Author", this.Book_Author);

    //    conn.Open();
    //    result += cmd.ExecuteNonQuery();
    //    conn.Close();

    //    return result;
    //}//end Insert

    //public int ActionInsert()
    //{
    //    int result = 0;
    //    string queryStrThriller = "INSERT INTO EL_Action(EL_ID, EL_Image, EL_Title, EL_Studio)" + "values (@Greenhouse_ID, @Greenhouse_Name, @Greenhouse_Image, @Book_Author)";

    //    SqlConnection conn = new SqlConnection(_connStr);
    //    SqlCommand cmd = new SqlCommand(queryStrThriller, conn);
    //    cmd.Parameters.AddWithValue("@Greenhouse_ID", this.Greenhouse_ID);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Image", this.Greenhouse_Image);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Name", this.Greenhouse_Name);
    //    cmd.Parameters.AddWithValue("@Book_Author", this.Book_Author);

    //    conn.Open();
    //    result += cmd.ExecuteNonQuery();
    //    conn.Close();

    //    return result;
    //}//end Insert

    //public int ComedyInsert()
    //{
    //    int result = 0;
    //    string queryStrThriller = "INSERT INTO EL_Comedy(EL_ID, EL_Image, EL_Title, EL_Studio)" + "values (@Greenhouse_ID, @Greenhouse_Name, @Greenhouse_Image, @Book_Author)";

    //    SqlConnection conn = new SqlConnection(_connStr);
    //    SqlCommand cmd = new SqlCommand(queryStrThriller, conn);
    //    cmd.Parameters.AddWithValue("@Greenhouse_ID", this.Greenhouse_ID);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Image", this.Greenhouse_Image);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Name", this.Greenhouse_Name);
    //    cmd.Parameters.AddWithValue("@Book_Author", this.Book_Author);

    //    conn.Open();
    //    result += cmd.ExecuteNonQuery();
    //    conn.Close();

    //    return result;
    //}//end Insert

    //public int RomanceInsert()
    //{
    //    int result = 0;
    //    string queryStrThriller = "INSERT INTO EL_Romance(EL_ID, EL_Image, EL_Title, EL_Studio)" + "values (@Greenhouse_ID, @Greenhouse_Name, @Greenhouse_Image, @Book_Author)";

    //    SqlConnection conn = new SqlConnection(_connStr);
    //    SqlCommand cmd = new SqlCommand(queryStrThriller, conn);
    //    cmd.Parameters.AddWithValue("@Greenhouse_ID", this.Greenhouse_ID);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Image", this.Greenhouse_Image);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Name", this.Greenhouse_Name);
    //    cmd.Parameters.AddWithValue("@Book_Author", this.Book_Author);

    //    conn.Open();
    //    result += cmd.ExecuteNonQuery();
    //    conn.Close();

    //    return result;
    //}//end Insert

    //public int HorrorInsert()
    //{
    //    int result = 0;
    //    string queryStrThriller = "INSERT INTO EL_Horror(EL_ID, EL_Image, EL_Title, EL_Studio)" + "values (@Greenhouse_ID, @Greenhouse_Name, @Greenhouse_Image, @Book_Author)";

    //    SqlConnection conn = new SqlConnection(_connStr);
    //    SqlCommand cmd = new SqlCommand(queryStrThriller, conn);
    //    cmd.Parameters.AddWithValue("@Greenhouse_ID", this.Greenhouse_ID);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Image", this.Greenhouse_Image);
    //    cmd.Parameters.AddWithValue("@Greenhouse_Name", this.Greenhouse_Name);
    //    cmd.Parameters.AddWithValue("@Book_Author", this.Book_Author);

    //    conn.Open();
    //    result += cmd.ExecuteNonQuery();
    //    conn.Close();

    //    return result;
    //}//end Insert
}