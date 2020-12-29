namespace ExampleApplication.Model
{
    public class Monkey : BaseModel
    {
        private string _name;
        private string _location;
        private string _imageUrl;

        public string Name
        {
            get => _name;
            set => OnPropertyChanged(ref _name, value);
        }

        public string Location
        {
            get => _location;
            set => OnPropertyChanged(ref _location, value);
        }

        public string ImageUrl
        {
            get => _imageUrl;
            set => OnPropertyChanged(ref _imageUrl, value);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
