﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Core.UnitOfWork
{
    public  interface IunitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
