using MySql.Data.MySqlClient;


namespace ComercialTDSClass
{
    public static class Banco
    {
        public static string strConn { get; set; }
       
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            if (strConn == string.Empty)
            strConn = $@"server=127.0.0.1;database=comercialtdsdb01;user=root;password=root";
            MySqlConnection cn = new();
            try
            {
                cn.Open();
                cmd.Connection = cn;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    
    }
}
