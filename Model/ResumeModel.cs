namespace Portfolio.Model {
	public class Resume {
		public string Name { get; set; }
		public string Title { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public string Summary { get; set; }
		public int Age { get; set; }
		public string[] Languages { get; set; }
		public Links[] Links { get; set; }
		public Skills[] Skills { get; set; }
		public Education[] Education { get; set; }
		public Project[] Projects { get; set; }
		public String[] Other { get; set; }
	}

	public class Links {
		public string Name { get; set; }
		public string Icon { get; set; }
		public string Url { get; set; }
	}

	public class Skills {
		public string Title { get; set; }
		public string[] Name { get; set; }
	}

	public class Education {
		public string Name { get; set; }
		public string Location { get; set; }
		public string Degree { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string Description { get; set; }
	}

	public class Project {
		public string Name { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public string[] Technologies { get; set; }
		public string Link { get; set; }
	}
}
