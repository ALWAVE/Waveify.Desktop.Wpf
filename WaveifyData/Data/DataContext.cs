﻿using System;
using WaveifyData.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WaveifyData.Data
{
    public class DataContext : DbContext
    {
#nullable disable
        public DbSet<MediaEntity> Songs { get; set; }
        public DbSet<PlaylistEntity> Playlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlite(@"Data source=data/player");
        }
    }
}
