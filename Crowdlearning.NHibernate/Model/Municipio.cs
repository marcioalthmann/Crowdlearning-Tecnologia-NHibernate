﻿using System.Collections.Generic;

namespace Crowdlearning.Model
{
    public class Municipio
    {
        public virtual int Handle { get; set; }
        public virtual string Nome { get; set; }
        public virtual Estado Estado { get; set; }
    }
}