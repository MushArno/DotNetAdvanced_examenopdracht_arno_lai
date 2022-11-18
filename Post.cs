using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DotNetAdvanced_examenopdracht_arno_lai
{
    internal class Post
    {
        public int PostId { get; set; }

        //public bool InGebruik { get; set; }
        public string PostCategory { get; set; }
        public string PostTitle { get; set; }
        public DateTime PostDate { get; set; }

        private Boolean isToegevoegd { get; set; }
        public Boolean isGewijzigd;

        //public List<Transactie> Transacties { get; set; }

        public bool werdToegevoegd()
        {
            return isToegevoegd;
        }
        public void Toevoegen(bool toevoegen = true)
        {
            isToegevoegd = toevoegen;
        }
    }
}
