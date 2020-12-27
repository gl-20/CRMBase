using System.Collections.Generic;

namespace CRMBase.Model {
	public class Patient {
		public string Name { get; set; }
		public ContactData ContactData { get; set; }
		public PersonalInfo PersonalInfo { get; set; }
		public IEnumerable<string> Diagnostic { get; set; }
		public IEnumerable<Analysis> Analyses { get; set; }
		public IEnumerable<Procedure> Procedures { get; set; }
		public IEnumerable<Procedure> ProceduresHistory { get; set; }
	}
}