﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $safeprojectname$
{
    class Student
    {
        // Alternative way to specify setter / getter
        private int idNum;

        public int IdNum
        {
            set
            {
                idNum = value;
            }
            get
            {
                return idNum;
            }
        }
    }
}
