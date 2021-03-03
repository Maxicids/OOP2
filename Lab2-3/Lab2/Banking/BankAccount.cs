using System;
using System.Runtime.Serialization;

namespace Lab2.Banking
{
    [DataContract]
    [KnownType(typeof(SavingBankAccount))]
    [KnownType(typeof(CurrentBankAccount))]
    [KnownType(typeof(TermBankAccount))]
    public abstract class BankAccount
    {
        [DataMember]
        protected int number;
        [DataMember]
        protected DepositType depositType;
        [DataMember]
        protected int balance;
        [DataMember]
        protected DateTime openDateTime;
        [DataMember] 
        protected bool hasSmsAlert;
        [DataMember]
        protected bool hasInternetBanking;
        [DataMember]
        protected Owner owner;

        public Owner Owner => owner;

        public int Balance => balance;
        public int Number => number;

        public DateTime OpenDateTime => openDateTime;
        

        public void AddToAccount(int num)
        {
            this.balance += num;
        }

        public int Commit(int num, int amount)
        {
            if (this.number != num) return 0;
            this.balance += amount;
            return 1;
        }

        public override string ToString()
        {
            return string.Concat("Owner: ", 
                owner.ToString(), " has ", balance, " on balance(", number, ") ", OpenDateTime);
        }

        public static BankAccount GetBankAccount(int bankAccount,
            Owner owner, bool hasSmsAlert, bool hasInternetBanking)
        {
            if (bankAccount == 0)
            {
                return new SavingBankAccount(owner, hasSmsAlert, hasInternetBanking);
            }
            if (bankAccount == 1)
            {
                return new CurrentBankAccount(owner, hasSmsAlert, hasInternetBanking);
            }
            if (bankAccount == 2)
            {
                return new TermBankAccount(owner, hasSmsAlert, hasInternetBanking);
            }
            return null;
        }
    }
    
    [DataContract]
    public class SavingBankAccount : BankAccount
    {
        public SavingBankAccount(Owner owner, bool hasSmsAlert, bool hasInternetBanking)
        {
            this.owner = owner;
            this.number = owner.PassportNumber;
            this.openDateTime = DateTime.Now;
            this.depositType = DepositType.Saving;
            this.balance = 0;
            this.hasInternetBanking = hasInternetBanking;
            this.hasSmsAlert = hasSmsAlert;
        }
    }

    [DataContract]
    public class CurrentBankAccount : BankAccount
    {
        public CurrentBankAccount(Owner owner, bool hasSmsAlert, bool hasInternetBanking)
        {
            this.owner = owner;
            this.number = owner.PassportNumber;
            this.openDateTime = DateTime.Now;
            this.depositType = DepositType.Current;
            this.balance = 0;
            this.hasInternetBanking = hasInternetBanking;
            this.hasSmsAlert = hasSmsAlert;
        }
    }

    [DataContract]
    public class TermBankAccount : BankAccount
    {
        public TermBankAccount(Owner owner, bool hasSmsAlert, bool hasInternetBanking)
        {
            this.owner = owner;
            this.number = owner.PassportNumber;
            this.openDateTime = DateTime.Now;
            this.depositType = DepositType.Term;
            this.balance = 0;
            this.hasInternetBanking = hasInternetBanking;
            this.hasSmsAlert = hasSmsAlert;
        }
    }
    
}
