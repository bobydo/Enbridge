using Enbridge.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Enbridge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string columnName = DataColumnName.first;
                var result = ShortColumn(columnName);
            }
            catch(Exception ex)
            {
                //Log
                throw ex;
            }
        }

        public static List<Data> ShortColumn(string columnName)
        {
            List<Data> listData = InitilizeData();
            List<Data> sortedListData = null;
            if (SelectColumnIsNotValid(columnName))
                throw new Exception("SelectColumnIsNotValid");
            switch (columnName)
            {
                case DataColumnName.first:
                    {
                        sortedListData=listData.OrderBy(x => x.First).ToList();
                        break;
                    }
                case DataColumnName.last:
                    {
                        sortedListData=listData.OrderBy(x => x.Last).ToList();
                        break;
                    }
                case DataColumnName.phone:
                    {
                        sortedListData=listData.OrderBy(x => x.Phone).ToList();
                        break;
                    }
                case DataColumnName.alive:
                    {
                        sortedListData = listData.OrderBy(x => x.Alive).ToList();
                        break;
                    }
                case DataColumnName.age:
                    {
                        sortedListData = listData.OrderBy(x => x.Age).ToList();
                        break;
                    }
            }
            return sortedListData;
        }


        private static bool SelectColumnIsNotValid(string columnName)
        {
            if (columnName == null || (columnName != DataColumnName.first && columnName != DataColumnName.last &&
                columnName != DataColumnName.phone && columnName != DataColumnName.alive
                && columnName != DataColumnName.age))
                return true;
            return false;
        }
        private static List<Data> InitilizeData()
        {
            List<string> data = new List<string>() {
            "Jason, Ewasiuk, 780-123-4567, 40, yes",
            "Wesley, Burwash, 780-987-6543, 30, yes",
            "Stephen, Yu, 780-555-0000, 20, yes",
            "Adam, Smith, 888-456-1234, 60, no",
            "David, Bowie, 877-555-4242, 65, no"
            };

            List<Data> listData = new List<Data>();
            foreach (var item in data)
            {
                string[] value = item.Split(",");
                listData.Add(new Data(value[0], value[1], value[2], value[3], value[4]));
            }

            return listData;
        }
    }
}
