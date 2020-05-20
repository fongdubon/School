namespace School.UIForms.ViewModels
{
	public class MainViewModel
	{
		public LoginViewModel Login { get; set; }
		public SubjectsViewModel Subjects { get; set; }
		public MainViewModel()
		{
			this.Login = new LoginViewModel();
		}
	}
}
