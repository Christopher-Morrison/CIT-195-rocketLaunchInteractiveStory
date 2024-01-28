using System;
using System.Reflection.PortableExecutable;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace rocketLaunch
{
    class Rocket
    {
        static void InitValues( ref int fuel, ref int sysCheck, Random r)
        {
            fuel = r.Next(1, 5) *10;
            sysCheck = r.Next(1, 4) *10;
        }

        static int ChooseAction()
        {
            Console.WriteLine("Press 1 to fuel the rocket! Press 2 to check systems!");
            int action = int.Parse(Console.ReadLine()); 
            while (action != 1 && action != 2) 
            {
                Console.WriteLine("That is an invalid number. Please select 1 or 2");
                action = int.Parse(Console.ReadLine());
            }
            return action;
        }
        static void UserActions(int num, ref int fuel, ref int sysCheck)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine("Over venting in progress!");
                    Console.WriteLine("Rocket fuel decreases by %5");
                    fuel -= 5;
                    break;
                case 1:
                    Console.WriteLine("Some large valves have been opened!");
                    Console.WriteLine("Rocket fuel increases by %10");
                    fuel += 10;
                    break;
                case 2:
                    Console.WriteLine("Some pumps have been engaged!");
                    Console.WriteLine("Rocket fuel increases by %10");
                    fuel += 10;
                    break;
                case 3:
                    Console.WriteLine("The main fuel pump has been engaged!");
                    Console.WriteLine("Rocket fuel increases by %20");
                    fuel += 20;
                    break;
                case 4:
                    Console.WriteLine("A large section of the tank farm springs to life!");
                    Console.WriteLine("Rocket fuel increases by %30");
                    fuel += 30;
                    break;
                case 5:
                    Console.WriteLine("Minor communication link failure.");
                    Console.WriteLine("Total rocket systems check decreases by %10");
                    sysCheck -= 10;
                    break;
                case 6:
                    Console.WriteLine("Performing electrical system diagnostic");
                    Console.WriteLine("Total rocket systems check increases by %20");
                    sysCheck += 20;
                    break;
                case 7:
                    Console.WriteLine("Grid fins and action surfaces examined.");
                    Console.WriteLine("Total rocket systems check increases by %20");
                    sysCheck += 20;
                    break;
                case 8:
                    Console.WriteLine("Navigation systems engaged");
                    Console.WriteLine("Total rocket systems check increases by %25");
                    sysCheck += 25;
                    break;
                case 9:
                    Console.WriteLine("Fuel and propultion hardware approved");
                    Console.WriteLine("Total rocket systems check increases by %30");
                    sysCheck += 30;
                    break;
            }
        }
        static void PrintGUI()
        {
            Console.WriteLine("" +
                "                   _ _       \r\n" +
                "                  | | |      \r\n" +
                "  __ _ _ __   ___ | | | ___  \r\n" +
                " / _` | '_ \\ / _ \\| | |/ _ \\ \r\n" +
                "| (_| | |_) | (_) | | | (_) |\r\n" +
                " \\__,_| .__/ \\___/|_|_|\\___/ \r\n" +
                "      | |                    \r\n" +
                "      |_|                    ");
        }
        static void LiftOffSuccess()
        {
            Console.WriteLine("" +
                " ___      ___   _______  _______  _______  _______  _______ \r\n" +
                "|   |    |   | |       ||       ||       ||       ||       |\r\n" +
                "|   |    |   | |    ___||_     _||   _   ||    ___||    ___|\r\n" +
                "|   |    |   | |   |___   |   |  |  | |  ||   |___ |   |___ \r\n" +
                "|   |___ |   | |    ___|  |   |  |  |_|  ||    ___||    ___|\r\n" +
                "|       ||   | |   |      |   |  |       ||   |    |   |    \r\n" +
                "|_______||___| |___|      |___|  |_______||___|    |___|    ");
            string rocketImage = "Image b y apx :\r\n\r\n \r\n \r\n                                   A\r\n                                   M\r\n                                   M\r\n                                   M\r\n                                   M\r\n                                   M\r\n                                   M\r\n                                   M\r\n                                  /M\\\r\n                                 '[V]'\r\n                                  [A]\r\n                                 [,-']\r\n                                 [/\"\\]\r\n                                 / _ \\\r\n                                / / | \\\r\n                               / /_O_| \\\r\n                              /______|__\\\r\n                              |=_==_==_=|\r\n                              |  |   |  |\r\n                             V|  |.V.|__|V\r\n                             A|  |'A'| =|A\r\n                              |__|___|= |\r\n                              |__|___| =|\r\n                              |####|####|\r\n                             |    o|     |\r\n                             |     |     |\r\n                             |     |     |\r\n                            |      |      |\r\n                            |      |      |\r\n                            |      |      |\r\n                           |       |       |\r\n                           |       |       |\r\n                           |-------|-------|\r\n                          |        |        |\r\n                          |        |        |\r\n                          |___.____|____.___|\r\n                         |                   |\r\n                         |___________________|\r\n                        /|HH|      |HH][HHHHHI\r\n                        [|##|      |##][#####I\r\n                        [|##|      |#########I\r\n                        [|##|______|#######m#I\r\n                        [I|||||||||||||||||||I\r\n                        [I|||||||||||||||||||I\r\n                        [|                   |\r\n                        [|    H  H          H|\r\n                        [|    H  H          H|\r\n                        [|    \\hdF          V|\r\n                        [|     `'            |\r\n                        [|    d##b          d|\r\n                        [|    #hn           #|\r\n                        [|     \"\"#          }|\r\n                        [|    \\##/          V|\r\n                        [|                   |\r\n                        [|     dh           d|\r\n                        [|    d/\\h          d|\r\n                        [|    H\"\"H          H|\r\n                        [|    \"  \"          \"|\r\n                        [|________.^.________|\r\n                        [I########[ ]########I\r\n                        [I###[]###[.]########I\r\n                        [I###|||||[_]####||||I\r\n                        [####II####|        n |\r\n                       /###########|         \" \\\r\n                       ############|           |\r\n                      /############|            \\\r\n                      ######\"######|            |\r\n                     /             |####### #####\\\r\n                     |             |#######.######\r\n                    /              |##############\\\r\n                    |              |###############\r\n                   /_______________|###############\\\r\n                   I|||||||||||||||||||||||||||||||I\r\n                   I|||||||||||||||||||||||||||||||I\r\n                   I|||||||||||||||||||||||||||||||I\r\n                   I|||||||||||||||||||||||||||||||I\r\n                   |                               |\r\n                   |-------------------------------|\r\n                   |                               |\r\n                   | [                  U          |\r\n                   | [                  N          |\r\n                   | !                  I          |\r\n                   | [                  T          |\r\n                   | [                  E          |\r\n                   | }                  D          |\r\n                   |                               |\r\n                   |                               |\r\n                   | {                  S          |\r\n                   | [                  T          |\r\n                   | :                  A          |\r\n                   | [                  T          |\r\n                   | [                  E          |\r\n                  /| {  /|              S    |\\    |\r\n                 | |   | |                   | |   |\r\n                 | |   | |                   | |   |\r\n                 | |   | |                   | |   |\r\n                 |_|___|_|___________________|_|___|\r\n                 | |   | |                   | |   |\\\r\n                 | |___| |___________________| |___|]\r\n                 | |###| |###################| |###|]\r\n                 | |###| |###################| |###|]\r\n                 | |###| |\"\"\"\"\"\"\"\"\"\"#########| |\"\"\"|]\r\n                 | |###| |         |#########| |   |]\r\n                  \\|####\\|---------|#########|/----|]\r\n                   |#####|         |#########|     |/\r\n                   |#####|         |#########|     |\r\n                  /]##### |        | ######## |    [\\\r\n                  []##### |        | ######## |    []\r\n                  []##### |        | ######## |    []\r\n                  []##### |        | ######## |    []\r\n                  []##### |        | ######## |    []\r\n                   |#####|---------|#########|-----|\r\n                   |#####|         |#########|     |\r\n                   |#####|         |##H######|     |\r\n                   |#####|         |##H######|     |\r\n                   |#####|         |##H######|     |\r\n                   |#####|_________|##H######|_____|\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |     ####\"\"\"\"\"\"\"  H            |\r\n                   |     ####\"\"\"\"\"\"\"  H            |\r\n                   |     \"\"\"\"\"\"\"\"\"\"\"  H            |\r\n                   |     \"\"\"\"\"\"\"\"\"\"\"  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |                  H            |\r\n                   |__________________H____________|\r\n                   |                  H            |\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   I||||||||||||||||||H||||||||||||I\r\n                   |#####|         |##H######|     |\r\n                   |#####|         |##H######|     |\r\n                   |#####|  H   H  |##H######|   H |\r\n                   |#####|  H   H  |##H######|   H |\r\n                   |#####|  H   H  |##H######|   H |\r\n                   |#####|  \\h_dF  |##H######|   Vm|\r\n                   |#####|   `\"'   |##H######|    \"|\r\n                   |#####|         |##H######|     |\r\n                   |#####|  /###\\  |##H######|   /#|\r\n                   |#####|  #   '  |##H######|   # |\r\n                   |#####|  \\###\\  |##H######|   \\#|\r\n                   |#####|  .   #  |##H######|   . |\r\n                   |#####|  \\###/  |##H######|   \\#|\r\n                   |#####|         |##H######|     |\r\n                   |#####|    H    |##H######|     [\r\n                   |#####|   dAh   |##H######|    H|\r\n                   |#####|  dF qL  |##H######|   dF|\r\n                   |#####|  HhmdH  |##H######|   Hm|\r\n                   |#####|  H   H  [%]H#apx##|   H |\r\n                   |#####|         |##H######|     |\r\n                   |#####A         |##H######A     |\r\n                   |####| |        |##H#####|#|    |\r\n                   |####| |        |##H#####|#|    |\r\n                   |###|   |       |##H####|###|   |\r\n                   |###|   |       |##H####|###|   |\r\n                   |##|     |      |##H###|#####|  |\r\n                   |#-|     |      |##H###|#####|-_|\r\n                _-\"==|       |     |##H##|#######|==\"-_\r\n             _-\"=[]==|       |     |##H##|#######|==[]=\"-_\r\n            |========|_______|_____|##H##|#######|========|\r\n            !=======|=========|____|##H#|=========|=======!\r\n                    !=========! /#####\\ !=========!\r\n                     /#######\\ /#######\\ /#######\\\r\n                    d#########V#########V#########h\r\n                    H#########H#########H#########H\r\n                   |###########H#######H###########|\r\n                   |###########|\"\"\"\"\"\"\"|###########|\r\n                    \"\"\"\"\"\"\"\"\"\"\"         \"\"\"\"\"\"\"\"\"\"\"";
            var imageList = rocketImage.Split('\n');
            for (int i = 0; i < imageList.Length; i++) 
            {
                Console.WriteLine(imageList[i]);
                Thread.Sleep(70);  
            }


        }
        static void CheckResults(ref int countdown, ref int fuel, ref int sysCheck, ref bool liftOff)
        {
            countdown -= 10;
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"COUNTDOWN: {countdown} seconds!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Fuel: %{fuel}, Systems Checked: %{sysCheck}");
            if ( countdown == 0 ) 
            {
                liftOff = true;
            }
            return;
        }
        static void Main(string[] args )
        {
            int countdown = 100, fuel = 0, sysCheck = 0, action=0;
            Random r = new Random();
            bool liftOff = false;
            PrintGUI();
            Console.WriteLine("Fuel the rocket to at least 90%");
            Console.WriteLine("Check at least 80% of rocket systems");
            Console.WriteLine("Don't worry about over fueling, excess fuel is vented.");
            InitValues(ref fuel, ref sysCheck, r);
            CheckResults(ref countdown, ref fuel, ref sysCheck, ref liftOff);

            while (liftOff == false)
            {
                action = ChooseAction();
                //player can choose to fuel or do sysCheck
                if (action == 1)
                {
                    Console.Clear();
                    PrintGUI();
                    UserActions(r.Next(5), ref fuel, ref sysCheck);
                }
                else if (action == 2) 
                {
                    Console.Clear();
                    PrintGUI();
                    UserActions(r.Next(5, 10), ref fuel, ref sysCheck);
                }
                CheckResults(ref countdown, ref fuel, ref sysCheck, ref liftOff);
            }


            if (liftOff == true && fuel >= 90 && sysCheck >= 80)
            {
                Thread.Sleep(100);
                LiftOffSuccess();
            }

            else if (fuel < 90)
                Console.WriteLine("The rocket does not have enough fuel to make it to orbit! Aborting Launch");
            else if (sysCheck < 80)
                Console.WriteLine("The rocket systems haven't been properly checked! Aborting Launch");
            else
            {
                Console.WriteLine("The Rocket has been sufficently fueled and checked. Prepare for launch!");
            }
                
        }
    }
}