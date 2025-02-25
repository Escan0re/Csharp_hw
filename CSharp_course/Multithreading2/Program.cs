public class FooBar {
    private int n;
    private SemaphoreSlim fooSem;
    private SemaphoreSlim barSem;

    public FooBar(int n) {
        this.n = n;
        fooSem = new SemaphoreSlim(1, 1);
        barSem = new SemaphoreSlim(0, 1);
    }

    public void Foo(Action printFoo) {
        for (int i = 0; i < n; i++) {
            fooSem.Wait();
            printFoo();
            barSem.Release();
        }
    }

    public void Bar(Action printBar) {
        for (int i = 0; i < n; i++) {
            barSem.Wait();
            printBar();
            fooSem.Release();
        }
    }
}