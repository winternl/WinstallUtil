using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TaskScheduler;

namespace WinstallUI.Modules
{
    public static class ScheduledTask
    {
        public static void test()
        {
            ITaskService taskService = new TaskSchedulerClass();
            taskService.Connect();
            ITaskDefinition taskDefinition = taskService.NewTask(0);
            taskDefinition.Settings.Enabled = true;
            taskDefinition.Settings.Compatibility = _TASK_COMPATIBILITY.TASK_COMPATIBILITY_V2_1;

            ITriggerCollection _iTriggerCollection = taskDefinition.Triggers;
            ITrigger _trigger = _iTriggerCollection.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_TIME);
            _trigger.StartBoundary = DateTime.Now.AddSeconds(15).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
            _trigger.EndBoundary = DateTime.Now.AddMinutes(1).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss");
            _trigger.Enabled = true;

            IActionCollection actions = taskDefinition.Actions;
            _TASK_ACTION_TYPE actionType = _TASK_ACTION_TYPE.TASK_ACTION_EXEC;

            IAction action = actions.Create(actionType);
            IExecAction execAction = action as IExecAction;
            execAction.Path = @"C:\Windows\System32\notepad.exe";
            ITaskFolder rootFolder = taskService.GetFolder(@"\");

            rootFolder.RegisterTaskDefinition("test", taskDefinition, (int)_TASK_ACTION_TYPE.TASK_ACTION_EXEC, null, null, _TASK_LOGON_TYPE.TASK_LOGON_NONE, null);
        }
    }
}
