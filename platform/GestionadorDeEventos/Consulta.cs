using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GestionadorDeEventos
{
    public static class Consulta
    {
        public static DataTable Proyeccion(DataTable T, List<string> campos)
        {
            List<string> columns = new List<string>();
            string nameCol;

            for (int i = 0; i < T.Columns.Count; i++)
            {
                nameCol = T.Columns[i].ColumnName.ToLower();

                if (!campos.Contains(nameCol))
                    columns.Add(nameCol);
            }

            foreach (string c in columns)
                T.Columns.Remove(c);

            return T;
        }

        public static DataTable Seleccion(DataTable T, List<string> campos)
        {
            List<DataRow> reg = new List<DataRow>();
            string nameCol = campos[0];
            int col = -1;

            for (int i = 0; i < T.Columns.Count; i++)
                if (nameCol.CompareTo(T.Columns[i].ColumnName) == 0)
                {
                    col = i;
                    break;
                }

            for (int i = 0; i < T.Rows.Count; i++)
                if (T.Rows[i].ItemArray[col].ToString().CompareTo(campos[1]) != 0)
                    reg.Add(T.Rows[i]);

            foreach (DataRow r in reg)
                T.Rows.Remove(r);

            return T;
        }

        public static DataTable Interseccion(DataTable TA, DataTable TB, string campo)
        {
            DataTable Tres = new DataTable();
            int posId, posId2;
            string clave1, clave2;

            posId = crearEncabezado(TA, ref Tres, campo);
            posId2 = crearEncabezado(TB, ref Tres, campo);

            for (int i = 0; i < TA.Rows.Count; i++)
            {
                clave1 = TA.Rows[i].ItemArray[posId].ToString();

                for (int w = 0; w < TB.Rows.Count; w++)
                {
                    clave2 = TB.Rows[w].ItemArray[posId2].ToString();
                    if(clave1.CompareTo(clave2)==0)
                        agregarRegistro(TA.Rows[i].ItemArray, TB.Rows[w].ItemArray, Tres,posId2);
                }
            }

            return Tres;
        }

        public static void agregarRegistro(object []dtA, object []dtB, DataTable Tres,int posLlave2)
        {
            object[] datos = new object[(dtA.Length+dtB.Length)-1];
            int cont = 0;

            for (int i = 0; i < dtA.Length; i++)
                datos[cont++] = dtA[i];

            for (int i = 0; i < dtB.Length; i++)
            {
                if(i != posLlave2)
                    datos[cont++] = dtB[i];
            }

            Tres.Rows.Add(datos);
        }


        public static int crearEncabezado(DataTable TA, ref DataTable TRes,string campo)
        {
            int column = -1;
            string nameColumn;

            for (int i = 0; i < TA.Columns.Count; i++)
            {
                nameColumn = TA.Columns[i].ColumnName.ToLower();
                
                if(!TRes.Columns.Contains(nameColumn))
                    TRes.Columns.Add(nameColumn);

                if (nameColumn.CompareTo(campo) == 0)
                    column = i;
            }

            return column;
        }
    }
}







