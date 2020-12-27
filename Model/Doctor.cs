using System.Collections.Generic;

namespace CRMBase.Model {
	public class Doctor {
		public string Name { get; set; }
		public ContactData ContactData { get; set; }
		public string Category { get; set; }
		public int Cabinet { get; set; }
		public Schedule schedule { get; set; }
		public float InterestRate { get; set; }
		public IEnumerable<Patient> Patients { get; set; }
		public IEnumerable<Procedure> Procedures { get; set; }
	}
}