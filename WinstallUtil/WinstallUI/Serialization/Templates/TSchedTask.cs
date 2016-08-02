namespace WinstallUI.Serialization.Templates
{
    public struct TSchedTask
    {
        public string Name;
        public string FileToRun;
        public TaskTrigger Trigger;
        public int? Hour;
        public int? Minute;

        public TSchedTask(string Name, string FileToRun, TaskTrigger Trigger)
        {
            this.Name = Name;
            this.FileToRun = FileToRun;
            this.Trigger = Trigger;

            Hour = null;
            Minute = null;
        }

        public TSchedTask(string Name, string FileToRun, TaskTrigger Trigger, int Hour, int Minute)
        {
            this.Name = Name;
            this.FileToRun = FileToRun;
            this.Trigger = Trigger;

            if ((Hour >= 0 && Hour <= 24) && (Minute >= 0 && Minute <= 60))
            {
                this.Hour = Hour;
                this.Minute = Minute;
            }
            else
            {
                this.Hour = null;
                this.Minute = null;
            }
        }
    }
}