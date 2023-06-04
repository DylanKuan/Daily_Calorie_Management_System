using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManagementTaskProject
{
    public class DailyItem
    {
        public string Name;
        public float Calories;
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
    public class Expenditure : DailyItem
    {
        public int Time;
        public Expenditure(string name, int time)
        {
            this.Name = name;
            this.Time = time;
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
