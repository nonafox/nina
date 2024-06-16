namespace Nina;

static class NinaCLI {
    public static void Main(string[] _args) {
        NinaError.env(() => {
            if (_args.Length > 0) {
                NinaCore.execute(_args[0]);
            }
            else {
                NinaError.error("命令行参数不足.", 248902);
            }
        });
    }
}