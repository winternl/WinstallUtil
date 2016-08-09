namespace WinstallUI.Serialization
{
    /// <summary>
    /// Defines base behavior for serialization classes.
    /// </summary>
    public abstract class ModuleSerializer<T>
    {
        public ModuleSerializer(T TemplateStructure) { Template = TemplateStructure; }
        public ModuleSerializer(byte[] SerializedData) { SerializedTemplate = SerializedData; }
        public virtual T Template { get; set; }
        public virtual byte[] SerializedTemplate { get; set; }
        public abstract byte[] Serialize();
        public abstract T Deserialize();
    }
}