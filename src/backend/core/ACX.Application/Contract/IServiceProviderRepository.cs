﻿using ACX.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Contract
{
    public interface IServiceProviderRepository
    {
        Task<IEnumerable<ServiceProvider>> GetAllServiceProviderAsync(bool trackChanges);
        Task<ServiceProvider> GetServiceProviderByIdAsync(Guid id, bool trackChanges);
        Task<ServiceProvider> GetServiceProviderByRegNumberAsync(string regNumber, bool trackChanges);
        Task<ServiceProvider> GetServiceProviderByEmailAsync(string email, bool trackChanges);
        void CreateServiceProvider(ServiceProvider serviceProvider);
        void UpdateServiceProvider(ServiceProvider serviceProvider);
        void DeleteServiceProvider(ServiceProvider serviceProvider);
    }
}
