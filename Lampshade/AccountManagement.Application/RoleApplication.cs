﻿using _0_FrameWork.Application;
using AccountManagement.Appllication.Contract.Role;
using AccountManagement.Domain.RoleAgg;
using System;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class RoleApplication : IRoleApplication
    {
        private readonly IRoleRepository _roleRepository;

        public RoleApplication(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public OperationResult Create(CreateRole command)
        {
            var operation=new OperationResult();
            
            var role = new Role(command.Name);
            if(_roleRepository.Exists(x=>x.Name==command.Name))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            _roleRepository.Create(role);
            _roleRepository.SaveChanges();

            return operation.Succedded();
        }

        public OperationResult Edit(EditRole command)
        {
            var operation = new OperationResult();

            var role = _roleRepository.Get(command.Id);
            if(role ==null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (_roleRepository.Exists(x => x.Name == command.Name&&x.Id!=command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            role.Edit(command.Name);
            _roleRepository.SaveChanges();

            return operation.Succedded();
        }

        public EditRole GetDetails(long id)
        {
            return _roleRepository.GetDetails(id);
        }

        public List<RoleViewModel> List()
        {
            return _roleRepository.List();
        }
    }
}
