﻿using Microsoft.EntityFrameworkCore;

namespace Jobs.Data
{
    public class JobContext: DbContext
    {
        public JobContext(DbContextOptions<JobContext> options) : base(options)
        {

        }
    }
}
