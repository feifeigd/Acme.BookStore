using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Acme.BookStore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStore.EntityFrameworkCore
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookStoreDbContext>
    {
        public BookStoreDbContext CreateDbContext(string[] args)
        {
            var currentDir = Directory.GetCurrentDirectory();
            var configBuilder = new ConfigurationBuilder();
            configBuilder.SetBasePath(currentDir);
            configBuilder.AddJsonFile("appsettings.json");
            var config = configBuilder.Build();
            var _dbConnection = config.GetConnectionString("Default");

            var builder = new DbContextOptionsBuilder<BookStoreDbContext>();
            builder.UseMySql(_dbConnection);
            var context = new BookStoreDbContext(builder.Options);
            return context;
        }
    }
}
