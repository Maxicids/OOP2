using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab2.Banking
{
    public class AccountList
    {
        private static AccountList accountList;
        private List<BankAccount> list;
        private readonly DataContractJsonSerializer jsonSerializer;
        private List<BankAccount> resultList;

        private AccountList()
        {
            this.list = new List<BankAccount>();
            this.jsonSerializer = new DataContractJsonSerializer(typeof(List<BankAccount>));
        }
        
        public static AccountList GetAccountList()
        {
            return accountList ?? (accountList = new AccountList());
        }

        #region List

        private bool Contains(BankAccount account)
        {
            foreach (var bankAccount in list)
            {
                if (bankAccount.Number == account.Number)
                {
                    return true;
                }
            }

            return false;
        }

        public int Count()
        {
            return list.Count();
        }
        public void Add(BankAccount account)
        {
            if (!accountList.Contains(account))
            {
                list.Add(account);
            }
        }
        
        public void Remove(BankAccount account)
        {
            list.Remove(account);
        }
        

        #endregion

        #region Serialization
        public void SerialData(int index = 0)
        {
            if (index == 0)
            {
                string[] str = File.ReadAllLines("Accounts.json");
            
                if (str.Length == 0)
                {
                    using (var file = new FileStream("Accounts.json", FileMode.OpenOrCreate))
                    {
                        jsonSerializer.WriteObject(file, list);
                    }
                }
                else
                {
                    DeSerialData();
                    using (var file = new FileStream("Accounts.json", FileMode.Create))
                    {
                        jsonSerializer.WriteObject(file, list);
                    }
                }
            }
            else
            {
                string[] str = File.ReadAllLines("ResultAccounts.json");
            
                if (str.Length == 0)
                {
                    using (var file = new FileStream("ResultAccounts.json", FileMode.OpenOrCreate))
                    {
                        jsonSerializer.WriteObject(file, resultList);
                    }
                }
                else
                {
                    DeSerialData();
                    using (var file = new FileStream("ResultAccounts.json", FileMode.Create))
                    {
                        jsonSerializer.WriteObject(file, resultList);
                    }
                }
            }
            
            
        }

        public void DeSerialData()
        {
            using (var file = new FileStream("Accounts.json", FileMode.OpenOrCreate))
            {
                if (jsonSerializer.ReadObject(file) is List<BankAccount> newList)
                {
                    foreach(BankAccount bankAccount in newList)
                    {
                        accountList.Add(bankAccount);
                    }
                }
            }
        }
        

        #endregion

        #region Staff

        public int Commit(int number, int amount)
        {
            return list.Sum(bankAccount => bankAccount.Commit(number, amount));
        }

        private static string ListToString(List<BankAccount> lst)
        {
            return lst.Aggregate("", 
                (current, bankAccount) => string.Concat(current, bankAccount.ToString(), Environment.NewLine));
        }
        public string GetList()
        {
            return ListToString(list);
        }

        #endregion
        
        #region Sort

        public int Sort(int type)
        {
            if (type == 0)
            {
                SortByOpenDataTime();
                return 1;
            }
            if (type == 1)
            {
                SortByBirthDate();
                return 1;
            }
            if (type == 2)
            {
                SortByName();
                return 1;
            }
            if (type == 3)
            {
                SortByOpeningDate();
                return 1;
            }
            return 0;
        }

        private void SortByOpeningDate()
        {
            list = list.OrderBy(x => x.Number).ToList();
        }
        private void SortByBirthDate()
        {
            list = list.OrderBy(x => x.Owner.BirthDateTime).ToList();
        }
        private void SortByName()
        {
            list = list.OrderBy(x => x.Owner.Name).ToList();
        }
        private void SortByOpenDataTime()
        {
            list = list.OrderBy(x => x.OpenDateTime).ToList();
        }
        #endregion
        
        #region Search

        public string Search(bool regex, string reg)
        {
            return ListToString(regex ? RegexSearch(reg) : LinqSearch(reg));
        }
        private List<BankAccount> RegexSearch(string reg)
        {
            Regex regex = new Regex(reg);
            resultList = list.Where(bankAccount => regex.IsMatch(bankAccount.ToString())).ToList();
            return resultList;
        }

        private List<BankAccount> LinqSearch(string search)
        {
            resultList = list.Where(x => x.ToString().Contains(search)).ToList();
            return resultList;
        }

        #endregion
    }
}