using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.DTO
{
    public class Document
    {
        private int id;
        private string typeDoc;
        private string numberDoc;
        private string levelDoc;
        private string highDoc;
        private string rev;
        private string name;
        private string form;
        private string department;
        private string fileName;
        private string revContext;
        private string note;
        private DateTime duaDate;

        public int Id { get => id; set => id = value; }
        public string TypeDoc { get => typeDoc; set => typeDoc = value; }
        public string NumberDoc { get => numberDoc; set => numberDoc = value; }
        public string LevelDoc { get => levelDoc; set => levelDoc = value; }
        public string HighDoc { get => highDoc; set => highDoc = value; }
        public string Rev { get => rev; set => rev = value; }
        public string Name { get => name; set => name = value; }
        public string Form { get => form; set => form = value; }
        public string Department { get => department; set => department = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string RevContext { get => revContext; set => revContext = value; }
        public string Note { get => note; set => note = value; }
        public DateTime DuaDate { get => duaDate; set => duaDate = value; }

        public Document()
        {
            
        }

    }
}
