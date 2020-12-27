namespace CRMBase.Model {
	public class DaySchedule {
		private float? beginOfDay;
		public float? BeginOfDay {
			get {
				if (IsRestDay) {
					return null;
				}
				return beginOfDay;
			}
			set {
				beginOfDay = value;
			}
		}
		private float? endOfDay;
		public float? EndOfDay {
			get {
				if (IsRestDay) {
					return null;
				}
				return endOfDay;
			}
			set {
				endOfDay = value;
			}
		}
		public bool IsRestDay { get; set; }
	}
}