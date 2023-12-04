namespace U10803___Assessment_1;
internal static class Program {
    [STAThread]
    static void Main() {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
interface DictAPI<TValue> {
    Dictionary<string, TValue> Accounts { get; }
}