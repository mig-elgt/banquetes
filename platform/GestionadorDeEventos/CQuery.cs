using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

using Npgsql;
using NpgsqlTypes;

using IBM.Data.DB2;
using IBM.Data.DB2Types;
using System.Data;

namespace GestionadorDeEventos
{
    class CQuery
    {
        //Objectos de Conexion
        private MySqlConnection conexionMysql_EL; //Conector MySql
        private MySqlConnection conexionMariaDB_S3; //Conector  MariaDB
        private NpgsqlConnection conexionPos_S2; //Conector PosgreSQL
        private DB2Connection conexionDB2_S1; //Conector DB2

        private List<string> datos;
        private string nameEntidad;
        private int posCampoCon;
        private int idFragmento;
        private string nameFragmento;
        private int sitioFragmento;
        private DataTable fragmentos;
        private DataTable resultQuery;
        private int clavePrimaria;
        private int tipoUpdate;
        private string campoCondicionAnt;
        private string campoCondicionNuevo;
        private List<string> Entidades;
        private string nameClavePrimaria;
        private string nameClavePrimariaAnt;

        public CQuery(string T,int posC)
        {
            this.nameEntidad = T;
            this.posCampoCon = posC;
            crearObjectosConexion();
            resultQuery = new DataTable();
            tipoUpdate = 0;
        }

        public void setNameLlavePrimaria(string name)
        {
            nameClavePrimaria = name;
        }

        public void setEntidades(List<string> E)
        {
            Entidades = E;
        }

        public void setCampoCondicionAnt(string c)
        {
            campoCondicionAnt = c;
        }

        public void setCampoCondicionNew(string c)
        {
            campoCondicionNuevo = c;
        }

        public void setTipoUpdate(int type)
        {
            this.tipoUpdate = type;
        }

        public DataTable getDataQuery()
        {
            return resultQuery;
        }

        public int getLlavePrimaria()
        {
            return clavePrimaria;
        }

        public void setNombreEntidad(string ent)
        {
            nameEntidad = ent;
        }

        public void setDatos(List<string> D)
        {
            datos = D;
        }
        
        private void crearObjectosConexion()
        {
            conexionMysql_EL = new MySqlConnection("server=localhost; Uid=root; password=root; database=esquemaloc; port=3306");
            conexionMariaDB_S3 = new MySqlConnection("server=localhost; Uid=root; password=root; database=eventos_s3; port=3380");
            conexionPos_S2 = new NpgsqlConnection("Server=127.0.0.1; User Id=postgres; Password=postgres; Database=Eventos_S2; Port=5432;");
            conexionDB2_S1 = new DB2Connection("Database=Event_S1; UserID=db2admin; Password=password");
        }

        public void obtenerDatos(DataGridView tabla)
        {
            List<DataTable> tablasDatos = new List<DataTable>(); 
            
            try
            {
                conexionMysql_EL.Open();
                MySqlDataReader reader = ejecutaQueryEL("SELECT * FROM fragmentos where tabla = '" + nameEntidad + "';");
                DataTable t;
                int sitio;
                string fragmento;
                string aux = "";

                while (reader.Read())
                {
                    sitio = (int)reader[4];
                    fragmento = reader[1].ToString();

                    if (aux.CompareTo(fragmento) != 0)
                    {
                        aux = fragmento;
                        switch (sitio)
                        {
                            case 1: //Sitio 1 -> db2
                                DB2Command comdando = new DB2Command("SELECT * FROM " + fragmento, conexionDB2_S1);
                                try
                                {
                                    conexionDB2_S1.Open();
                                    t = new DataTable();
                                    t.Load(comdando.ExecuteReader());
                                    tablasDatos.Add(t);
                                    conexionDB2_S1.Close();
                                }
                                catch (DB2Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                break;
                            case 2: //Sitio 2 -> PostgreSQL
                                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM " + fragmento, conexionPos_S2);
                                try
                                {
                                    conexionPos_S2.Open();
                                    t = new DataTable();
                                    t.Load(cmd.ExecuteReader());
                                    tablasDatos.Add(t);
                                    conexionPos_S2.Close();
                                }
                                catch (NpgsqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                break;
                            case 3: //Sitio 3 -> MariaDB
                                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM " + fragmento, conexionMariaDB_S3);
                                try
                                {
                                    conexionMariaDB_S3.Open();
                                    t = new DataTable();
                                    t.Load(cmd2.ExecuteReader());
                                    tablasDatos.Add(t);
                                    conexionMariaDB_S3.Close();
                                }
                                catch (MySqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                break;
                        }
                    }
                }

                conexionMysql_EL.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (nameEntidad.CompareTo("Platillo") == 0)
                InnerJoin(tablasDatos,tabla); //Hacer inner join entre platillo
            else
            {
                //Recuperar los registros de fragmentos horizontales
                //Crear el encabezado
                resultQuery = new DataTable();
                for (int i = 0; i < tablasDatos[0].Columns.Count; i++)
                    resultQuery.Columns.Add(tablasDatos[0].Columns[i].ColumnName);
                    //tabla.Columns.Add(tablasDatos[0].Columns[i].ColumnName, tablasDatos[0].Columns[i].ColumnName);
                    
                //Agregar registros
                foreach (DataTable T in tablasDatos)
                    for (int i = 0; i < T.Rows.Count; i++)
                        resultQuery.Rows.Add(T.Rows[i].ItemArray);
                        //tabla.Rows.Add(T.Rows[i].ItemArray);
             }
        }

        public void InnerJoin(List<DataTable> listaTablas,DataGridView tabla)
        {
            DataTable T1 = listaTablas[0];
            DataTable T2 = listaTablas[1];
            DataTable TRes;

            /*TRes = new DataTable();

            //Crear Columnas
            for (int i = 0; i < listaTablas.Count; i++)
            {
                DataTable T = listaTablas[i];
                for (int j = 0; j < T.Columns.Count; j++)
                    TRes.Columns.Add(T.Columns[j].ColumnName);
            }

            for (int i = 0; i < T1.Rows.Count; i++)
            {
                object[] obj = new object[T1.Columns.Count + T2.Columns.Count];
                int w = 0;

                for (; w < T1.Columns.Count; w++)
                    obj[w] = T1.Rows[i].ItemArray[w];

                for (int x =0; w < 8; w++,x++)
                    obj[w] = T2.Rows[i].ItemArray[x];

                TRes.Rows.Add(obj);
            }
            */
            TRes = Consulta.Interseccion(T1, T2, "id_platillo");
            resultQuery = TRes;
        }

        //tipoTrans: 1=Insert, 2:Delte, 3:Update
        public void ExecuteQuery(List<string> D,int tipoTrans)
        {
            this.datos = D;
            obtenerFragmentos();
            
            switch (tipoTrans)
            { 
                case 1:
                    Insert();
                break;
                case 2:
                    Delete();
                break;
                case 3:
                    if (tipoUpdate == 0)
                        Update();
                    else
                        updateOptimizado();
                break;
            }
        }

        private void updateOptimizado()
        { 
            //Quitar nombres de los atributos en el array de datos
            List<string> newDatos = new List<string>();

            nameClavePrimariaAnt = datos[2];
            //Delete del registros
            datos[0] = campoCondicionAnt;
            obtenerFragmentos();
            Delete();
            //Insert del cambio
            
            newDatos.Add(datos[0]);
            int N = datos.Count;
            for (int i = 1; i < N; i++)
                if (i % 2 == 0)
                    newDatos.Add(datos[i]);

            datos = newDatos;
            datos[0] = campoCondicionNuevo;
            datos.RemoveAt(1);
           
            obtenerFragmentos();
            Insert();

            //Update de llave primaria
            datos.Clear();
            datos.Add("X");
            datos.Add(nameClavePrimaria);
            datos.Add(clavePrimaria.ToString());

            foreach (string E in Entidades)
            {
                setNombreEntidad(E);
                UpdateLlavePrimaria();
            }
        }

        public void ActualizaCostoTotal(int tipoOpe)
        {
            string query;
            int sitioFrag;
        
            string ope = "+";
            obtenerFragmentos();
            for (int i = 0; i < fragmentos.Rows.Count; i++)
            {
                query = "UPDATE " + fragmentos.Rows[i].ItemArray[1].ToString() + " SET costo_total = costo_total";

                if (tipoOpe == 0)
                    ope = "-";

                query += ope + datos[1];

                sitioFrag = Convert.ToInt32(fragmentos.Rows[i].ItemArray[4]);
                ExecuteQueryOnSitio(query, sitioFrag);
            }
        }

        private void UpdateLlavePrimaria()
        {
            string query;
            int sitioFrag;
            string tipoFrag;
           
            obtenerFragmentos();
            for (int i = 0; i < fragmentos.Rows.Count; i++)
            {
                query = "UPDATE " + fragmentos.Rows[i].ItemArray[1].ToString() + " SET " + datos[1] + "=" + datos[2] + " WHERE "+ datos[1] + "=" + nameClavePrimariaAnt;
                tipoFrag = fragmentos.Rows[i].ItemArray[3].ToString();
                sitioFrag = Convert.ToInt32(fragmentos.Rows[i].ItemArray[4]);
                ExecuteQueryOnSitio(query, sitioFrag);
            }
        }

        private void Update()
        {
            string query;
            string valores;
            int posI, posF;
            int sitioFrag;
            int w = 2;
            string tipoFrag;

            posI = 0;
            posF = 10;
            
            for (int i = 0; i < fragmentos.Rows.Count; i++)
            {
                query = "UPDATE " + fragmentos.Rows[i].ItemArray[1].ToString() + " SET ";
                tipoFrag = fragmentos.Rows[i].ItemArray[3].ToString();
                valores = "";

                if (tipoFrag.CompareTo("1") == 0)//Fragmento Horizontal
                {
                    w = 3;
                    posI = 1;
                    posF = datos.Count;
                }

                for (; w < posF; w+=2 )
                    valores += datos[w] + "=" + datos[w+1] + ",";

                if (tipoFrag.CompareTo("2") == 0)//Fragmento Vertical
                    query += valores.Substring(0, valores.Length - 1) + " WHERE " + datos[posI] + "=" + datos[posF - w + 1];
                else
                    query += valores.Substring(0, valores.Length - 1) + " WHERE " + datos[posI] + "=" + datos[posF - w + 2];
               
               posF = datos.Count;
            
               sitioFrag = Convert.ToInt32(fragmentos.Rows[i].ItemArray[4]);
               ExecuteQueryOnSitio(query, sitioFrag);
           }
       }

        private void Delete()
        {
            string query;
            int sitioFrag;

            for (int i = 0; i < fragmentos.Rows.Count; i++)
            {
                query = "DELETE FROM " + fragmentos.Rows[i].ItemArray[1].ToString() + " WHERE " + datos[1] + "=" + datos[2];

                if (fragmentos.Rows[i].ItemArray[3].ToString().CompareTo("4") == 0)
                {
                    for (int j = 3; j < datos.Count; j += 2)
                    {
                        query += " AND " + datos[j] + "=" + datos[j + 1];
                    }

                }

                sitioFrag = Convert.ToInt32(fragmentos.Rows[i].ItemArray[4]);
                
                ExecuteQueryOnSitio(query, sitioFrag);
            }
        }

        public void Insert()
        { 
            string query;
            string valores;
            int posI, posF;
            int sitioFrag;
            string tipoFragmento;
            bool band = false;

            posI = 0;
            posF = 5;
            clavePrimaria = obtenerClavePrimaria();

            for (int i = 0; i < fragmentos.Rows.Count; i++)
            {
                query = "INSERT INTO " + fragmentos.Rows[i].ItemArray[1].ToString() + " VALUES(";
                valores = "";
                sitioFrag = Convert.ToInt32(fragmentos.Rows[i].ItemArray[4]);
                tipoFragmento = fragmentos.Rows[i].ItemArray[3].ToString();

                if(tipoFragmento.CompareTo("1")==0)//Fragmento horizontal
                {
                    datos.Insert(1, clavePrimaria.ToString());
                    posI = 1;
                    posF = datos.Count;
                }
                else
                    if (tipoFragmento.CompareTo("3")==0 || tipoFragmento.CompareTo("4")==0)//Fragmentacion Vertical y None
                    {
                        if (!band && clavePrimaria != -1)
                        {
                            datos.Insert(0, clavePrimaria.ToString());
                            band = true;
                        }
                        posI = 0;
                        posF = datos.Count;

                    }else
                        datos.Insert(posI, clavePrimaria.ToString());
                
                for (;  posI < posF; posI++)
                    valores += datos[posI] + ",";

                query += valores.Substring(0, valores.Length-1) + ")";
                posF = datos.Count+1;
                ExecuteQueryOnSitio(query, sitioFrag);
            }
        }

        private void ExecuteQueryOnSitio(string query, int sitioFragmento)
        {
            switch (sitioFragmento)
            {
                case 1: //Sitio 1 con DB2
                    try
                    {
                        DB2Command comando = new DB2Command(query,conexionDB2_S1); 
                        conexionDB2_S1.Open();
                        comando.ExecuteNonQuery();
                        conexionDB2_S1.Close();
                    
                    }catch(DB2Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                break;
                case 2: //Sitio 2 con PostreSQL
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand(query, conexionPos_S2);
                        conexionPos_S2.Open();
                        cmd.ExecuteNonQuery();
                        conexionPos_S2.Close();
                    }catch(NpgsqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }finally
                    {
                        conexionPos_S2.Close();
                    }

                break;
                case 3: //Sitio 3 con MariaDB
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conexionMariaDB_S3);
                        conexionMariaDB_S3.Open();
                        cmd.ExecuteNonQuery();
                        conexionMariaDB_S3.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conexionMariaDB_S3.Close();
                    }

                break;
            }
        }

        private int obtenerClavePrimaria()
        {
            int id = -1;
            MySqlCommand comando = new MySqlCommand();
            try
            {
                conexionMysql_EL.Open();
                comando = new MySqlCommand("incrementaSecuencia", conexionMysql_EL);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new MySqlParameter("nameEntidad", nameEntidad));
                MySqlParameter cod = new MySqlParameter("id", 0);
                cod.Direction = ParameterDirection.Output;
                comando.Parameters.Add(cod);
                comando.ExecuteNonQuery();

                try
                {
                    id = Int32.Parse(comando.Parameters["id"].Value.ToString());
                }
                catch (FormatException )
                { 
                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionMysql_EL.Close();
            }

            return id;
        }

        public void obtenerFragmentos()
        {
            try
            { 
                conexionMysql_EL.Open();
                establecerDatosFragmento();
                conexionMysql_EL.Close();
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void establecerDatosFragmento()
        {
            MySqlDataReader frag = ejecutaQueryEL("SELECT * FROM fragmentos where tabla = '" + nameEntidad + "';");
            int cont;
            fragmentos = new DataTable();
            
            for (int i = 0; i < 5; i++)
                fragmentos.Columns.Add(i.ToString());

            cont = 0;
            while (frag.Read())
            {
                object[] obj = new object[5];
                cont++;

                for (int i = 0; i < 5; i++)
                   obj[i] = frag[i];

                fragmentos.Rows.Add(obj);

                if (frag[3].ToString().CompareTo("1") == 0)//El fragmento es horizontal
                {
                    //Checar que la condicion de fragmentación
                    if (frag[5].ToString().CompareTo(datos[posCampoCon]) == 0)
                    {
                        //Se encontro el fragmento horizontal
                        idFragmento = (int)frag[0];
                        nameFragmento = frag[1].ToString();
                        sitioFragmento = (int)frag[4];

                        //Eliminar fragmentos 
                        for (int i = 0; i < cont - 1; i++)
                            fragmentos.Rows.RemoveAt(0);

                        break;
                    }
                }
            }
        }

        private MySqlDataReader ejecutaQueryEL(string query)
        {
            MySqlDataReader reader;
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = query;
            comando.Connection = conexionMysql_EL;
            reader = comando.ExecuteReader();

            return reader;
        }

    }
}
