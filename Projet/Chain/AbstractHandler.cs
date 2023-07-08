public abstract class AbstractHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        this._nextHandler = handler;
        return handler;
    }

    public virtual bool Handle(string request)
    {
        if (this._nextHandler != null)
        {
            return this._nextHandler.Handle(request);
        }
        
        return false;
    }
}
