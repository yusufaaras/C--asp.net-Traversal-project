﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-S1QPNRR;Database=TraversalDb;Integrated Security=True;TrustServerCertificate=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactUs> contactUses { get; set; }
        public DbSet<Destination_yerler> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Features2 { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<TestiMonial> TestiMonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet <Reservation> Reservations { get; set; }
        public DbSet <Announcement> Announcements { get; set; }
        public DbSet <Account> Accounts { get; set; }
    }
}
