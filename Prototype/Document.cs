using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Document
    {
         public string НазваниеДокумента {  get; set; }
         public string Автор { get; set; }
         public DateTime    Дата { get; set; }

         public string Тип_Документов   { get; set; }


        public abstract Document  Clone();


        public override string ToString()
        {
            return $"Название Документа: {НазваниеДокумента}, Автор: {Автор}, Дата: {Дата},  Тип_Документов: {Тип_Документов} ";
        }
    }
}
