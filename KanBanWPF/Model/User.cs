﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanBanWPF.Model
{
    class User
    {
        public string Name { get; private set; }

        public User(string name)
        {
            Name = name;            
        }
    }
}
