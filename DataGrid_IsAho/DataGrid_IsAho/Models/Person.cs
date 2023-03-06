using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_IsAho.Models
{
    public sealed class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        ///3の倍数と３のつくデータの時にtrueを返す
        public bool IsAho => Age % 3 == 0 || Age.ToString().Contains("3");
    }
}