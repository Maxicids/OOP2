using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Converter
{
    internal abstract class CountryType
    {
        public double size;
    }
    
    internal class Russia : CountryType
    {
        public double ToEurope(double russia, bool female)
        {
            return female ? (russia - 5) : (russia + 1);
        }
        public double ToUSA(double russia, bool female)
        {
            return female ? (russia - 37) : (russia - 9);
        }
    }
    internal class Europe : CountryType
    {
        public double ToRussia(double europe, bool female)
        {
            return female ?  (europe + 5) : (europe - 1);
        }
        public double ToUSA(double europe, bool female)
        {
            return female ? (europe - 32) : (europe - 10);
        }
    }
    internal class USA : CountryType
    {
        public double ToRussia(double usa, bool female)
        {
            return female ? (usa + 37) : (usa + 9);
        }
        public double ToEurope(double usa, bool female)
        {
            return female ? (usa + 32) : (usa + 10);
        }
    }

    internal abstract class Creator
    {
        public static CountryType GetCountry(string type)
        {
            if (type == "USA")
            {
                return new USA();
            }
            if (type == "Russia")
            {
                return new Russia();
            }
            if (type == "Europe")
            {
                return new Europe();
            }
            throw new ServiceException("Unknown type");
        }
        public abstract CountryType Factory();
    }
    internal class UsaCreator : Creator
    {
        public override CountryType Factory() { return new USA(); }
    }
    internal class EuropeCreator : Creator
    {
        public override CountryType Factory() { return new Europe(); }
    }
    internal class RussiaCreator : Creator
    {
        public override CountryType Factory() { return new Russia(); }
    }
}
