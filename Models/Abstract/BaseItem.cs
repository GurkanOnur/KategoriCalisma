using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KategoriCalisma.Models.Abstract
{
    public enum Status { Active = 1, Modified, Passive }
    public abstract class BaseItem
    {
        public int Id { get; set; }
        private DateTime _createdDate=DateTime.Now;
        public DateTime CreatedDate 
        {
            get => _createdDate; 
            set=> _createdDate = value;
        }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        private Status _status= Status.Active;
        public Status Status
        {
            get => _status;
            set => _status = value;
        }
    }
}
