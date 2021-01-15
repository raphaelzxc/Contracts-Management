﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContractsManagement.Models;
using ContractsManagement.Helpers;
using System.Threading;

namespace ContractsManagement.Data
{
    public class ContractsContext : DbContext
    {
        private ICurrentUserService currentUserService;

        public ContractsContext (DbContextOptions<ContractsContext> options,
             ICurrentUserService currentUserService)
            : base(options)
        {
            this.currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public DbSet<ContractsManagement.Models.MiningContracts> MiningContracts { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ProcessSave();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void ProcessSave()
        {
            var currentTime = DateTime.UtcNow;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is Entity))
            {
                var entity = item.Entity as Entity;
                entity.CreatedDate = currentTime;
                entity.CreatedByUser = currentUserService.GetCurrentUsername();
                entity.ModifiedDate = currentTime;
                entity.ModifiedByUser = currentUserService.GetCurrentUsername();
            }
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified && e.Entity is Entity))
            {
                var entity = item.Entity as Entity;
                entity.ModifiedDate = currentTime;
                entity.ModifiedByUser = currentUserService.GetCurrentUsername();
                item.Property(nameof(entity.CreatedDate)).IsModified = false;
                item.Property(nameof(entity.CreatedByUser)).IsModified = false;
            }
        }
    }
}
