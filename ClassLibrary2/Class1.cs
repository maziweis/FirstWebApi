using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ClassLibrary2
{
    public class Class1
    {
        public int FirstSql()
        {
            using (var data = new MetaDataEntities())
            {
                var da = data.Meta_CodeTable.Where(w => w.TableName== "tb_Code_ListTable3").FirstOrDefault();
                return da.ID;
            }
                
        }
    }
}
