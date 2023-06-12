namespace Maui.Apps.Framework.Exceptions;

public class InternetConnectionExceptions:Exception {
    public InternetConnectionExceptions() {

    }
    public InternetConnectionExceptions(string message) : base(message) {

    }
    public InternetConnectionExceptions(string m, Exception inner) : base(m, inner) {
    
    }
}
