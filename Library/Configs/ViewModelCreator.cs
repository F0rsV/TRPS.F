namespace Library.Configs
{
    public class ViewModelCreator : ICreator<ViewModel.BaseWindowViewModel>
    {
        private readonly Data.LibraryContext libraryContext;

        public ViewModelCreator()
        {
            libraryContext = new Data.LibraryContext();
        }

        public ViewModel.BaseWindowViewModel Create()
        {
            Data.IUnitOfWork unitOfWork = new Data.UnitOfWork(libraryContext);

            return new ViewModel.BaseWindowViewModel(unitOfWork);
        }
    }
}