using System;

class Program {
  public static void Main (string[] args) {
    
    int place;
    string[] dash = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
    string o = "o";
    string x = "x";
    Console.WriteLine (dash[0] + "  |  "  + dash[1] +  "  |  "  + dash[2] + "\n");
    Console.WriteLine("--------------");
    Console.WriteLine (dash[3] + "  |  "  + dash[4] +  "  |  "  + dash[5] + "\n");
    Console.WriteLine("--------------");
    Console.WriteLine (dash[6] + "  |  "  + dash[7] +  "  |  "  + dash[8] + "\n");
    Console.WriteLine("u are x answer where u want to be on the grid");
    place = Convert.ToInt32(Console.ReadLine());
    place -= 1;
    if(place >= 8 && place <= -1){
      if(dash[place] != "x" && dash[place] != "o"){
        dash[place] = x;
        Console.WriteLine (dash[0] + "  |  "  + dash[1] +  "  |  "  + dash[2] + "\n");
        Console.WriteLine("--------------");
        Console.WriteLine (dash[3] + "  |  "  + dash[4] +  "  |  "  + dash[5] + "\n");
        Console.WriteLine("--------------");
        Console.WriteLine (dash[6] + "  |  "  + dash[7] +  "  |  "  + dash[8] + "\n");
      }
      
    }
    
    
  }
}