namespace InitVsReadOnlyProperty
{
    public class SomeModel
    {
        public SomeModel(string readOnly = "", string init = "")
        {
            ReadOnly = readOnly;
            Init = init;
        }

        //read-only property
        public string ReadOnly { get; }

        //init-only property
        public string Init { get; init; }
    }
}
