namespace School.UIForms.ViewModels
{
    using School.Common.Models;
    using School.Common.Services;
    using System;
    using System.Collections.ObjectModel;

    public class SubjectsViewModel
    {
        private ApiService apiService;
        public ObservableCollection<Subject> Subjects { get; set; }

        public SubjectsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadSubjects();
        }

        private async void LoadSubjects()
        {
            throw new NotImplementedException();
        }
    }
}
