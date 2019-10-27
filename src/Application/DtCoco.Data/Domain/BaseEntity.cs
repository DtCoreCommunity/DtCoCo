using System;
using System.Collections.Generic;
using System.Text;

namespace DtCoco.Data
{
    public abstract class BaseEntity
    {
    }
    public abstract class BaseEntityCreatable<T> : BaseEntity, ICreatable
    {
        public virtual T Id { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual string CreatedBy { get; set; }
    }
}