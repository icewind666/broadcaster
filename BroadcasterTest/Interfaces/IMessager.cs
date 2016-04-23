namespace BroadcasterTest.Interfaces
{
    public interface IMessager
    {
        void ShowMessage( string message );
        void ShowExclamation( string message );
        void ShowError( string message );
        string ChangeConfigName( string name );
    }
}
