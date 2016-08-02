namespace WinstallUI.Serialization.Templates
{
    public struct TInstallProgram
    {
        public byte[] Installer;
        public bool SilentInstall;

        public TInstallProgram(byte[] Installer, bool SilentInstall)
        {
            this.Installer = Installer;
            this.SilentInstall = SilentInstall;
        }
    }
}