using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public enum ErrorCodes
{
    NONE = 0,
    WRONG_TYPE,
    WRONG_ITEM,
    WRONG_VALUE
}

namespace ManagementTaskProject
{
    public class DailyItem
    {
        public string Name;
        protected double _Calories;

        public double Calories
        {
            get { return this._Calories; }
            set
            {
                if (value < 0)
                    value = 0;
                this._Calories = value;
            }
        }
    }

    interface CalculateCalories
    {
        double Compute();
    }

    public class Intake : DailyItem
    {
        public string Remark;
        public Intake(string name, float carlories, string remark)
        {
            this.Name = name;
            this.Calories = carlories;
            this.Remark = remark;
        }
    }

    public class Expenditure : DailyItem, CalculateCalories
    {
        public double Time;
        public Expenditure(string name, double time)
        {
            this.Name = name;
            this.Time = time;
        }
        public double Compute() // 各類運動消耗熱量表運動30分鐘消耗的熱量(大卡) : https://www.hpa.gov.tw/Pages/Detail.aspx?nodeid=571&pid=9738
        {
            double CaloriesPerMin = 0;
            if (Name == "走路")
                CaloriesPerMin = 122.5 / 30;
            else if (Name == "慢跑")
                CaloriesPerMin = 287 / 30;
            else if (Name == "騎腳踏車")
                CaloriesPerMin = 140 / 30;
            else if (Name == "游泳")
                CaloriesPerMin = 220.5 / 30;

            return Time * CaloriesPerMin;
        }
    }
    class ManagementTask
    {
        public List<Object> Item = new List<Object>();

        public void LoadTaskFile(String FileName)
        {
            if (!File.Exists(FileName))
            {
                FileStream CurFile = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                CurFile.Close();
            }
            else
            {
                String CurLine;
                StreamReader TaskText = new StreamReader(FileName);
                while (TaskText.Peek() >= 0)
                {
                    CurLine = TaskText.ReadLine();
                    Add_daily_item(CurLine);
                }
                TaskText.Close();
            }
        }

        public void Add_daily_item(string CurLine)
        {
            String[] Piecewise;
            if (CurLine.Contains("攝取"))
            {
                Piecewise = CurLine.Trim().Split(':');
                Piecewise = Piecewise[1].Trim().Split(' ');
                Item.Add(new Intake(Piecewise[0], Convert.ToSingle(Piecewise[1]), Piecewise[2]));
            }
            else if (CurLine.Contains("消耗"))
            {
                Piecewise = CurLine.Trim().Split(':');
                Piecewise = Piecewise[1].Trim().Split(' ');
                Item.Add(new Expenditure(Piecewise[0], Convert.ToInt32(Piecewise[1])));
            }
        }
    }
}
