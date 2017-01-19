using Xamarin.Forms;

namespace AcikAkademiMVVM.Views
{
    public partial class PersonPage : ContentPage
    {
        //private readonly IList<PersonModel> model = 
        //    new ObservableCollection<PersonModel>();
        public PersonPage()
        {
            InitializeComponent();
            //BindData();
        }

        //Web-Service Call
        //private void BindData()
        //{
        //    model.Add(new PersonModel
        //    {
        //        Id = 1,
        //        Name = "Yiğit",
        //        Surname = "Özaksüt"
        //    });
        //    model.Add(new PersonModel
        //    {
        //        Id = 2,
        //        Name = "İbrahim",
        //        Surname = "Kıvanç"
        //    });
        //    //lstPerson.ItemsSource = model;
        //    lstPerson.BindingContext = model;
        //}

        //private void onDelete(object sender, EventArgs e)
        //{
        //    MenuItem item = (MenuItem)sender;
        //    PersonModel selectedModel = (PersonModel)item.CommandParameter;
        //    if (selectedModel != null)
        //        model.Remove(selectedModel);
        //}
        //private void onUpdate(object sender, EventArgs e)
        //{
        //    MenuItem item = (MenuItem)sender;
        //    PersonModel selectedModel = (PersonModel)item.CommandParameter;
        //    //Model'de değişiklik yapmak!
        //    if (selectedModel != null)
        //        selectedModel.Name = selectedModel.Surname.Substring(0, 1)
        //            + "." + selectedModel.Name;
        //}
    }
}