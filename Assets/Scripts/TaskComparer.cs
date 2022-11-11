using System;
using System.Collections.Generic;

	public class TaskComparer : IComparer<Task>
	{
		public int Compare(Task x, Task y)
		{
            return DateTime.Compare(x.deadline, y.deadline);
		}
	}

