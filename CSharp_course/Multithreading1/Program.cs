public class Foo {
    private SemaphoreSlim _semSecond;
    private SemaphoreSlim _semThird;
    
    public Foo() {
        _semSecond = new SemaphoreSlim(0, 1);
        _semThird = new SemaphoreSlim(0, 1);
    }

    public void First(Action printFirst) {
        printFirst();
        _semSecond.Release();
    }

    public void Second(Action printSecond) {
        _semSecond.Wait();
        printSecond();
        _semThird.Release();
    }

    public void Third(Action printThird) {
        _semThird.Wait();
        printThird();
    }
}