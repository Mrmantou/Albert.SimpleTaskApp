﻿using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert.SimpleTaskApp.People
{
    public class PeopleAppService : SimpleTaskAppAppServiceBase, IPeopleAppService
    {
        private readonly IRepository<Person, Guid> repository;

        public PeopleAppService(IRepository<Person, Guid> repository)
        {
            this.repository = repository;
        }

        public async Task<ListResultDto<ComboboxItemDto>> GetPeopleComboboxItems()
        {
            var people = await repository.GetAllListAsync();
            return new ListResultDto<ComboboxItemDto>(
                people.Select(p => new ComboboxItemDto(p.Id.ToString("D"), p.Name)).ToList()
                );
        }
    }
}