using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class WordDocument : Document
    {
        public WordDocument(string названиеДокумента, string автор, DateTime дата, string тип_Документов)
        {
            НазваниеДокумента = названиеДокумента;

            Автор = автор;

            Дата = дата;

            Тип_Документов = тип_Документов;
        }


        public override Document Clone()
        {
            WordDocument clone = (WordDocument)this.MemberwiseClone();


            return clone;
        }
    }
}
