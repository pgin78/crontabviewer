using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaciejRogozinski.CrontabViewer.Engine
{
    public class CrontabTaskList<T> : List<T> where T : CrontabTask
    {
        public int GetPosByTaskName(string taskName)
        {
            T t = this.FindByTaskName(taskName);
            return this.IndexOf(t);
        }

        public int GetPosByTaskName(string taskName, int position)
        {
            T t = this.FindByTaskName(taskName,position);
            return this.IndexOf(t);
        }

        public T FindByTaskName(string taskName)
        {
            return this.Find(
                delegate(T t)
                {
                    return t.TaskName.Contains(taskName);
                });
        }

        public T FindByTaskName(string taskName, int position)
        {
            position++;
            if (position == 0)
            {
                return this.Find(
                delegate(T t)
                {
                    return t.TaskName.Contains(taskName);
                });
            }
            return this.GetRange(position, this.Count - position).Find(
                delegate(T t)
                {
                    return t.TaskName.Contains(taskName);
                });
        }
    }
}
