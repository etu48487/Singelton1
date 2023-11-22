using System;

namespace Command
{
    public class RemoteController
    {
        private Command[] onCommands;
        private Command[] offCommands;

        public RemoteController()
        {
            onCommands = new Command[5];
            offCommands = new Command[5];
            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }
        //button assignment
        public void SetCommand(int slot, Command onCommand, Command offCommand) {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        //button selection
        public void OnButtonWasPushed(int slot) {
            onCommands[slot].Execute();
        }
        public void OffButtonWasPushed(int slot){
            offCommands[slot].Execute();
        }
        //button assignment display
        public override string ToString(){
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control -------\n");
        for (int i = 0; i < onCommands.Length; i++){
        stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().Name + " " + offCommands[i].GetType().Name + "\n");
        }
        return stringBuff.ToString();
        }
    }
}