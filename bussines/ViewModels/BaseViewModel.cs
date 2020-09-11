﻿using bussines.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace bussines.ViewModels
{
    [DataContract]
    public abstract class BaseViewModel
    {
        [Column(visible: false)]
        [DataMember]
        public int Id { get; set; }
        public abstract List<string> Properties();

    }
}
