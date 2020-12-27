using System.Collections.Generic;

namespace CRMBase.Model {
	public class RepeatableSchedule {
		public int GetRestDays() {
			int days = 0;
			foreach (var pair in WeekSchedule) {
				if (pair.Value == false) {
					days++;
				}
			}
			return days;
		}
		public int GetWorkDays() {
			int days = 0;
			foreach (var pair in WeekSchedule) {
				if (pair.Value == true) {
					days++;
				}
			}
			return days;
		}
		public void SetRestDay(DayOfWeek dayOfWeek) {
			WeekSchedule[dayOfWeek] = false;
		}
		public void SetWorkDay(DayOfWeek dayOfWeek) {
			WeekSchedule[dayOfWeek] = true;
		}
		IDictionary<DayOfWeek, bool> WeekSchedule { get; set; }
	}
}