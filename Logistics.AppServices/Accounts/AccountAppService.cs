using AgileObjects.AgileMapper;
using Logistics.EF.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.AppServices
{
    public class AccountAppService : IAccountAppService
    {
        private IRepository<Account, Guid> _Repository;

        private IRepository<DataDic, Guid> _dicRepository;

        public AccountAppService(IRepository<Account, Guid> repository
                                                 , IRepository<DataDic, Guid> dicRepository)
        {
            _Repository = repository;
            _dicRepository = dicRepository;
        }

        public async Task<List<AccountDto>> GetAll(long userId)
        {
            try
            {
                var list = _Repository.GetAll().OrderByDescending(a => a.IsDefault && a.UserId == userId);
                var AccountTypeList = _dicRepository.GetAll().Where(a => a.TypeCode == "AccountType");
                var res = (from l in list
                           join at in AccountTypeList on l.AccountType equals at.ItemCode
                           select new AccountDto
                           {
                               Id = l.Id,
                               AccountNo = l.AccountNo,
                               AccountType = l.AccountType,
                               AccountTypeName = at.ItemName,
                               BankName = l.BankName,
                               IsDefault = l.IsDefault,
                               UserId = l.UserId
                           }).ToList();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<List<AccountDto>> GetByAccountType(long userId, int accountType)
        {
            try
            {
                var list = _Repository.GetAll().OrderByDescending(a => a.IsDefault && a.UserId == userId && a.AccountType == accountType);
              
                var AccountTypeList = _dicRepository.GetAll().Where(a => a.TypeCode == "AccountType");
                var res = (from l in list
                           join at in AccountTypeList on l.AccountType equals at.ItemCode
                           select new AccountDto
                           {
                               Id = l.Id,
                               AccountNo = l.AccountNo,
                               AccountType = l.AccountType,
                               AccountTypeName = at.ItemName,
                               BankName = l.BankName,
                               IsDefault = l.IsDefault,
                               UserId = l.UserId
                           }).ToList();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public async Task<List<AccountDto>> GetList()
        {
            try
            {
                var list = _Repository.GetAll().OrderByDescending(a => a.IsDefault);
                var AccountTypeList = _dicRepository.GetAll().Where(a => a.TypeCode == "AccountType");
                var res = (from l in list
                           join at in AccountTypeList on l.AccountType equals at.ItemCode
                           select new AccountDto
                           {
                               Id = l.Id,
                               AccountNo = l.AccountNo,
                               AccountType = l.AccountType,
                               AccountTypeName = at.ItemName,
                               BankName = l.BankName,
                               IsDefault = l.IsDefault,
                               UserId = l.UserId
                           }).ToList();
                return await Task.FromResult(res);
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public async Task<List<AccountDto>> GetPageList(int pageIndex, int pageSize)
        {
            var list = _Repository.GetPageList(pageIndex, pageSize).OrderByDescending(a => a.IsDefault); ;
            var AccountTypeList = _dicRepository.GetAll().Where(a => a.TypeCode == "AccountType");
            var res = (from l in list
                       join at in AccountTypeList on l.AccountType equals at.ItemCode
                       select new AccountDto
                       {
                           Id = l.Id,
                           AccountNo = l.AccountNo,
                           AccountType = l.AccountType,
                           AccountTypeName = at.ItemName,
                           BankName = l.BankName,
                           IsDefault = l.IsDefault,
                           UserId = l.UserId
                       }).ToList();
            return await Task.FromResult(res);
        }

        public async Task<AccountDto> GetById(Guid id)
        {
            var list = _Repository.GetById(id);
            var res = Mapper.Map(list).ToANew<AccountDto>();
            return await Task.FromResult(res);
        }


        public async Task<bool> Add(AccountCreateInput input)
        {
            var entity = Mapper.Map(input).ToANew<Account>();
            var res = _Repository.Add(entity);
            return await Task.FromResult(res);
        }

        public async Task<bool> Delete(Guid id)
        {
            var list = _Repository.Delete(id);
            return await Task.FromResult(list);
        }
        public async Task<bool> Update(AccountDto dto)
        {
            var entity = Mapper.Map(dto).ToANew<Account>();
            var list = _Repository.Update(entity);
            return await Task.FromResult(list);
        }
    }
}

