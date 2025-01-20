using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PdfDocument : Document
    {

        public PdfDocument(string названиеДокумента, string автор, DateTime дата, string тип_Документов)
        {
            НазваниеДокумента = названиеДокумента;

            Автор = автор;

            Дата = дата;

            Тип_Документов = тип_Документов;
        }
   


        public override Document Clone()
        {
            PdfDocument clone = (PdfDocument)this.MemberwiseClone();


            return clone;
        }
    }
}
