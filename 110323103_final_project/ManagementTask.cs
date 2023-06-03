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
            }
            else
            {
                String CurLine;
                StreamReader TaskText = new StreamReader(FileName);
                String[] Piecewise;
                while (TaskText.Peek() >= 0)
                {
                    CurLine = TaskText.ReadLine();
                    if (CurLine.ToUpper().Contains("INTAKE"))
                    {
                        Piecewise = CurLine.Trim().Split(':');
                        Piecewise = Piecewise[1].Trim().Split(' ');
                        Item.Add(new Intake(Piecewise[0], Convert.ToSingle(Piecewise[1]), Piecewise[2]));
                    }
                    else if (CurLine.ToUpper().Contains("EXPENDITURE"))
                    {
                        Piecewise = CurLine.Trim().Split(':');
                        Piecewise = Piecewise[1].Trim().Split(' ');
                        Item.Add(new Expenditure(Piecewise[0], Convert.ToInt32(Piecewise[1])));
                    }
                }
            }


        }
    }
}
