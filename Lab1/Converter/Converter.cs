using System;

namespace Lab1.Converter
{
    internal class ServiceException : Exception
    {
        private string message;
        public ServiceException(string message)
        {
            this.message = message;
        }
        public string GetInfo()
        {
            return message;
        }

    }
    internal interface IService
    {
        double Convert(CountryType type1, CountryType type2, bool female);
    }
    internal class Service : IService
    {
        private static Service instance = new Service();

        private CountryType from;
        public CountryType From
        {
            get
            {
                return from;
            }
            set
            {
                if (value as CountryType != null)
                {
                    from = value;
                }
                else
                {
                    throw new ServiceException("Wrong type");
                }
            }
        }
        private CountryType to;
        public CountryType To
        {
            get
            {
                return to;
            }
            set
            {
                if (value as CountryType != null)
                {
                    to = value;
                }
                else
                {
                    throw new ServiceException("Wrong type");
                }
            }
        }

        private Service()
        {

        }
        public double Convert(CountryType type1, CountryType type2, bool female)
        {
            if (type1 is Europe)
            {
                if (type2 is Russia)
                {
                    return (type1 as Europe).ToRussia(type1.size, female);
                }
                else if (type2 is USA)
                {
                    return (type1 as Europe).ToUSA(type1.size, female);
                }
                else
                {
                    throw new ServiceException("Can not covert to this type");
                }
                
            }
            else if (type1 is Russia)
            {
                if (type2 is Europe)
                {
                    return (type1 as Russia).ToEurope(type1.size, female);
                }
                else if (type2 is USA)
                {
                    return (type1 as Russia).ToUSA(type1.size, female);
                }
                else
                {
                    throw new ServiceException("Can not covert to this type");
                }
            }
            else if (type1 is USA)
            {
                if (type2 is Russia)
                {
                    return (type1 as USA).ToRussia(type1.size, female);
                }
                else if (type2 is Europe)
                {
                    return (type1 as USA).ToEurope(type1.size, female);
                }
                else
                {
                    throw new ServiceException("Can not covert to this type");
                }
            }
            else
            {
                throw new ServiceException("Unknown type");
            }
        }

        public static Service GetInstance()
        {
            if (instance == null)
            {
                instance = new Service();
            }
            return instance;
        }
    }
}
