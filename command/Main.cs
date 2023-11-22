namespace command
{
    using System;

    class Main
    {
        static void Main(string[] args)
        {
            //initialization
            //Resources creation
            RemoteController remote = new RemoteController();
            Light light = new Light();
            Thermostat thermostat = new Thermostat();
            
            LightOnCommand lightOnCom = new LightOnCommand(light);
            LightOffCommand lightOffCom = new LightOffCommand(light);
            
            ThermostatIncreaseCommand tic = new ThermostatIncreaseCommand(thermostat);
            ThermostatDecreaseCommand tdc = new ThermostatDecreaseCommand(thermostat);
            
            CombinedOnCommand conc = new CombinedOnCommand(light, thermostat);
            CombinedOffCommand coffc = new CombinedOffCommand(light, thermostat);
//button assignment
            remote.SetCommand(0, tic, tdc);
            remote.SetCommand(1, lightOnCom, lightOffCom);
            remote.SetCommand(1, conc, coffc);
//Remote controller starting
            Console.WriteLine(remote);
            light.DisplayLampStatus();
            thermostat.DisplayTemperature();
//loop
while (check)
{
    Console.WriteLine(remote);
    //choice of the command/device
    Console.WriteLine("please, use a number between 0 and 6 to select the action");
    Scanner button = new Scanner(System.in);
    int pressed = button.nextInt();
    if ((pressed < 7) && (pressed >= 0))
    {
        //choice of the function (on/off)
        Console.WriteLine("use 1 for on, 0 for off");
        int type = button.nextInt();
        if (type == 1) { remote.onButtonWasPushed(pressed); }
        else if (type == 0) { remote.offButtonWasPushed(pressed); }
        else { Console.WriteLine("please, use a correct number"); }
    }
    else { Console.WriteLine("please, use a correct number"); }

    Console.WriteLine("press 1 to continue, 0 to finish");
    int choice = button.nextInt();
    if (choice == 1) { }
    else if (choice == 0) { check = false; }
    else { Console.WriteLine("please, use a correct number"); }
    light.displayLampStatus();
    thermostat.displayTemperature();
}}}}



