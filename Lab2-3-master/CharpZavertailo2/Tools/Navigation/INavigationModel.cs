namespace CharpZavertailo2.Tools.Navigation
{
    internal enum ViewType
    {
        PersonFillInfo
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
