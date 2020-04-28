using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Models
{
    class Machine
    {

        private int id;

        private bool DangerousStatus = false;
        private bool CriticalStatus = false;

        private List<string> TempLog;
        private List<string> VibrLog;
        private List<string> PowerLog;
        private List<string> LoadLog;
        private List<string> WorkTimeLog;

        public Machine(int id)
        {
            this.id = id;
        }

        public void addTempLog(string str)
        {
            TempLog.Add(str);
        }
        public void addVibrLog(string str)
        {
            VibrLog.Add(str);
        }
        public void addPowerLog(string str)
        {
            PowerLog.Add(str);
        }
        public void addLoadLog(string str)
        {
            LoadLog.Add(str);
        }
        public void addWorkTimeLog(string str)
        {
            WorkTimeLog.Add(str);
        }


        public bool isDangerous() { return DangerousStatus; }
        public bool isCritical() { return CriticalStatus; }


        public float getTempByDate(string date)
        {
            for (int i = 0; i < TempLog.Count; i++)
            {
                if (TempLog[i].Split(new char[] { ' ' })[0] == date)
                {
                    return float.Parse(TempLog[i].Split(new char[] { ' ' })[1]);
                }
            }
            return -1;

        }
        public float getVibrByDate(string date)
        {
            for (int i = 0; i < VibrLog.Count; i++)
            {
                if (VibrLog[i].Split(new char[] { ' ' })[0] == date)
                {
                    return float.Parse(VibrLog[i].Split(new char[] { ' ' })[1]);
                }
            }
            return -1;

        }
        public float getPowerByDate(string date)
        {
            for (int i = 0; i < PowerLog.Count; i++)
            {
                if (PowerLog[i].Split(new char[] { ' ' })[0] == date)
                {
                    return float.Parse(PowerLog[i].Split(new char[] { ' ' })[1]);
                }
            }
            return -1;

        }
        public int getLoadByDate(string date)
        {
            for (int i = 0; i < LoadLog.Count; i++)
            {
                if (LoadLog[i].Split(new char[] { ' ' })[0] == date)
                {
                    return int.Parse(LoadLog[i].Split(new char[] { ' ' })[1]);
                }
            }
            return -1;

        }
        public int getWorkTimeByDate(string date)
        {
            for (int i = 0; i < WorkTimeLog.Count; i++)
            {
                if (WorkTimeLog[i].Split(new char[] { ' ' })[0] == date)
                {
                    return int.Parse(WorkTimeLog[i].Split(new char[] { ' ' })[1]);
                }
            }
            return -1;

        }
    }
}
