using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.CodeFirstModels
{
    /// <summary>
    /// 二级学院的实体
    /// </summary>
    public class Department
    {
       
        public Guid ID { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string SortCode { get; set; }

        public Department()
        {
            ID = Guid.NewGuid();
        }
    }
}