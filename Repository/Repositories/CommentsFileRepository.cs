﻿using Domain;
using Repository.Interfaces;
using Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class CommentsFileRepository : Repository<CommentsFile>, ICommentsFileRepository
    {
        public CommentsFileRepository(AppDBContext context) : base(context)
        {

        }
    }
}
