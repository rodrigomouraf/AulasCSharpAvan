using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_ClassesMetodosExtensao
{
    public static class JSONDataSet //: DataSet
    {
        //DataSet _ds;

        //public JSONDataSet(DataSet ds)
        //{
        //    this._ds = ds;
        //}

        //public void WriteJSON(string fileName)
        //{
        //    //_ds
        //}

        public static void WriteJSON(this DataSet ds, string fileName)
        {
            //ds
        }

        public static string ToUrl(this string str)
        {
            return str = "http://" + str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var ds = new DataSet();
            //ds.WriteXml("dados.xml");
            //ds.WriteJSON("dados.js");
            //var ds2 = new JSONDataSet(ds);
            //ds2.WriteJSON("lalala");
            //ds.WriteXml("dados.xml");

            string url = "lalala.com";
            Console.WriteLine(url.ToUrl());
            Console.ReadKey();
        }
    }
}
