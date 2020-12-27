using System;
using System.Collections.Generic;

namespace CRMBase.Model {
	public class Procedure {
		public string Name { get; set; }
		public string Category { get; set; }
		public int Cabinet { get; set; }
		public float Price { get; set; }
		public int DurationInMinutes { get; set; }
		public IEnumerable<Medicines> Medicines { get; set; }
		public IEnumerable<Equipment> Equipment { get; set; }
		public string Recipe { get; set; }
		public IEnumerable<Analysis> Analyses { get; set; }
		public DateTime? RecordProcedureTimestamp { get; set; }
		public DateTime? EndOfProcedureTimestamp { get; set; }
	}
}